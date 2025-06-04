using Astrolabe.models;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text.Json;
using System.Windows.Forms;

namespace Astrolabe
{
    public partial class MainForm : Form
    {
        Astronomy astronomy;
        bool FileOpened = false;
        private bool isModified = false;

        public MainForm()
        {
            InitializeComponent();
            astronomy = new Astronomy();
            this.FormClosing += MainForm_FormClosing;
            this.AcceptButton = ApplyAdvancedFilterButton;
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //astronomy.Fill(100);
            dataGridView1.Visible = false;
            label4.Visible = true;
        }

        //private void textBox10_TextChanged(object sender, EventArgs e)
        //{
        //    updateSearch();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    updateSearch();
        //}

        private void updateSearch()
        {
            string search_target = "";//textBox10.Text;
            List<Star> result = Filters.FindAllByName(search_target, astronomy.stars);
            starBindingSource1.DataSource = result;
            if (FileOpened)
            {
                dataGridView1.Visible = true;
                label4.Visible = false;
            }
            else
            {
                dataGridView1.Visible = false;
                label4.Visible = true;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var form = new forms.DataEditorForm(astronomy);
            form.ShowDialog();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                astronomy.stars = JsonSerializer.Deserialize<List<Star>>(json);
                FileOpened = true;
                isModified = false;
                updateSearch();
                astronomy.InitConstellations();
                starBindingSource2.DataSource = astronomy.constellations;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти базу зірок";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.Serialize(astronomy.stars, options);
                File.WriteAllText(saveFileDialog.FileName, json);
                MessageBox.Show("saved");
                isModified = false;
            }
        }

        private void EditBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new forms.DataEditorForm(astronomy);
            form.ShowDialog();
            if (form.isDataChanged)
            {
                if (!FileOpened)
                {
                    FileOpened = true;
                }
                isModified = true;
                updateSearch();

            }
            astronomy = form.astronomy;
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    if (!FileOpened)
        //    {
        //        MessageBox.Show("Спочатку відкрий або створи базу зірок.");
        //        return;
        //    }

        //    if (!double.TryParse(textBoxLatitude.Text, out double latitude) || latitude < -90 || latitude > 90)
        //    {
        //        MessageBox.Show("Введіть коректну широту (-90 до 90).");
        //        return;
        //    }

        //    var visibleStars = GetVisibleStars(astronomy.stars, latitude);

        //    if (visibleStars.Count == 0)
        //    {
        //        MessageBox.Show("Жодної видимої зірки не знайдено для заданих параметрів.");
        //    }

        //    starBindingSource1.DataSource = visibleStars;
        //    dataGridView1.Visible = true;
        //    label4.Visible = false;
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    starBindingSource1.DataSource = astronomy.stars;
        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FileOpened || listBox1.SelectedItem == null)
                return;

            string selectedConstellation = listBox1.SelectedItem.ToString();

            var starsInConstellation = astronomy?.stars
                ?.Where(s => s.Constellation == selectedConstellation)
                ?.ToList();

            // На випадок, якщо starsInConstellation також null:
            starBindingSource.DataSource = starsInConstellation ?? new List<Star>();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                var result = MessageBox.Show(
                    "Ви маєте незбережені зміни. Бажаєте зберегти їх перед закриттям?",
                    "Зберегти зміни?",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void buttonApplyAdvancedFilter_Click(object sender, EventArgs e)
        {
            string search_target = richTextBox1.Text ?? string.Empty;
            List<Star> firstFiltration = Filters.ApplyAdvancedFilter(search_target, astronomy);

            double lat = 0, lon = 0;
            bool coordsParsed = false;

            if (!string.IsNullOrWhiteSpace(textBoxLatitude.Text))
            {
                string[] parts = textBoxLatitude.Text.Split(',');
                if (parts.Length == 2 &&
                    double.TryParse(parts[0].Trim().Replace(".", ","), out lat) &&
                    double.TryParse(parts[1].Trim().Replace(".", ","), out lon))
                {
                    coordsParsed = true;
                }
            }

            if (coordsParsed)
            {
                DateTime time = dateTimePicker1.Value;
                List<Star> secondFiltration = Filters.FindVisibleStars(firstFiltration, lat, lon, time);
                starBindingSource1.DataSource = null;
                starBindingSource1.DataSource = secondFiltration;
            }
            else
            {
                starBindingSource1.DataSource = null;
                starBindingSource1.DataSource = firstFiltration;
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;

            richTextBox1.TextChanged -= richTextBox1_TextChanged;

            string text = richTextBox1.Text;
            richTextBox1.SelectAll();
            richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;

            string[] keywords =
                {
                    "distance:", "dist:",
                    "name:",
                    "magnitude:", "mag:",
                    "constellation:", "cons:",
                    "isvisible:", "visible:"
                };

            foreach (string keyword in keywords)
            {
                int index = 0;
                while ((index = text.IndexOf(keyword, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    richTextBox1.Select(index, keyword.Length);
                    richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    richTextBox1.SelectionColor = Color.Blue;
                    index += keyword.Length;
                }
            }

            richTextBox1.Select(selectionStart, selectionLength);
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            updateSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);

            List<Star> sorted = list.OrderByDescending(x => x.ApparentMagnitude).Reverse().ToList();

            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);

            List<Star> sorted = list.OrderByDescending(x => x.Name).Reverse().ToList();

            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);

            List<Star> sorted = list.OrderByDescending(x => x.Constellation).Reverse().ToList();

            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);

            List<Star> sorted = list.OrderByDescending(x => x.DistanceLightYears).Reverse().ToList();

            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double lat = 0, lon = 0;
            bool coordsParsed = false;

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string[] parts = textBox1.Text.Split(',');
                if (parts.Length == 2 &&
                    double.TryParse(parts[0].Trim().Replace(".", ","), out lat) &&
                    double.TryParse(parts[1].Trim().Replace(".", ","), out lon))
                {
                    coordsParsed = true;
                }
            }

            if (!coordsParsed)
            {
                MessageBox.Show("Введіть координати у форматі: широта, довгота");
                return;
            }

            DateTime time = dateTimePicker2.Value;
            List<string> visibleConstellations = new List<string>();

            foreach (var constellation in astronomy.constellations)
            {
                var starsInConstellation = astronomy.stars
                    .Where(s => s.Constellation == constellation)
                    .ToList();

                if (starsInConstellation.Count == 0)
                    continue;

                var visibleStars = Filters.FindVisibleStars(starsInConstellation, lat, lon, time);

                // Якщо всі зірки видимі — додаємо сузір’я
                if (visibleStars.Count == starsInConstellation.Count)
                {
                    visibleConstellations.Add(constellation);
                }
            }

            if (visibleConstellations.Count == 0)
            {
                MessageBox.Show("Жодне сузір’я повністю не видно з обраної точки.");
            }

            starBindingSource2.DataSource = null;
            starBindingSource2.DataSource = visibleConstellations;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            starBindingSource2.DataSource = null;
            starBindingSource2.DataSource = astronomy.constellations;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabMain_Click(object sender, EventArgs e)
        {
            this.AcceptButton = ApplyAdvancedFilterButton;
        }

        private void tabSearchByStar_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button6;
        }
    }
}
