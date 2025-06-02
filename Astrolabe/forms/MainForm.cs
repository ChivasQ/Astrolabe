using Astrolabe.models;
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
            string search_target = textBox10.Text;
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

        private void button8_Click(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            updateSearch();
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
                MessageBox.Show("awda");
                if (!FileOpened)
                {
                    FileOpened = true;
                }
                isModified = true;
                updateSearch();

            }
            astronomy = form.astronomy;
        }
        public List<Star> GetVisibleStars(List<Star> allStars, double observerLatitude)
        {
            return allStars
                .Where(star =>
                    star.Declination >= (observerLatitude - 90) &&
                    star.Declination <= (observerLatitude + 90) &&
                    (star.ApparentMagnitude <= 6.5))
                .ToList();
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
                    saveAsToolStripMenuItem_Click(null, null);
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

            double lat = double.Parse(textBoxLatitude.Text.Replace(".", ","));
            double lon = double.Parse(textBoxLongitude.Text.Replace(".", ","));
            DateTime time = DateTime.Parse(dateTimePicker1.Text);
            List<Star> secondFiltration = Filters.FindVisibleStars(firstFiltration, lat, lon, time);

            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = secondFiltration;
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
                    "constellation:", "cons:"
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
    }
}
