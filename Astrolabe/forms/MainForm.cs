using Astrolabe.forms;
using Astrolabe.models;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Astrolabe
{
    public partial class MainForm : Form
    {
        Astronomy astronomy;
        bool FileOpened = false;
        private bool isModified = false;
        Settings settings = Settings.Load();

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
            dataGridView1.Visible = false;
            label4.Visible = true;


            if (!string.IsNullOrWhiteSpace(settings.LastOpenedFile) && File.Exists(settings.LastOpenedFile))
            {
                try
                {
                    string json = File.ReadAllText(settings.LastOpenedFile);
                    astronomy.stars = JsonSerializer.Deserialize<List<Star>>(json);

                    FileOpened = true;
                    isModified = false;

                    astronomy.InitConstellations();

                    updateSearch();
                    this.Text = "Астролябія - " + settings.GetLastOpenedFileName();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося відкрити останній файл:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateSearch()
        {
            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = astronomy.stars;
            starBindingSource2.DataSource = null;
            starBindingSource2.DataSource = astronomy.constellations;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                astronomy.Deserialize(openFileDialog.FileName);
                FileOpened = true;
                isModified = false;
                updateSearch();
                astronomy.InitConstellations();
                starBindingSource2.DataSource = astronomy.constellations;
                settings.LastOpenedFile = openFileDialog.FileName;
                settings.Save();
                this.Text = "Астролябія - " + settings.GetLastOpenedFileName();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти базу зірок";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                astronomy.Serialize(saveFileDialog.FileName);

                MessageBox.Show("Збережено успішно.");
                isModified = false;

                settings.LastOpenedFile = saveFileDialog.FileName;
                settings.Save();
                this.Text = "Астролябія - " + settings.GetLastOpenedFileName();
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

            }
            astronomy = form.astronomy;
            RemoveNullNames();
            updateSearch();
        }

        public void RemoveNullNames()
        {
            astronomy.stars.RemoveAll(s => string.IsNullOrWhiteSpace(s.Name));
        }
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
                if (checkBox1.Checked)
                {
                    secondFiltration = secondFiltration.Where(s => comboBox1.Text == s.Constellation).ToList();
                }
                starBindingSource1.DataSource = null;
                starBindingSource1.DataSource = secondFiltration;
                if (secondFiltration.Count == 0)
                    MessageBox.Show("По вашому запиту нічого не знайдено");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBoxLatitude.Text))
                    MessageBox.Show("Введіть координати у форматі: широта, довгота\nАбо зайдіть на Google maps та скопіюйте координати та вставте рядок у поле",
                        "Фільтр координат буде проігноровано",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                if (checkBox1.Checked)
                {
                    firstFiltration = firstFiltration.Where(s => comboBox1.Text == s.Constellation).ToList();
                }
                starBindingSource1.DataSource = null;
                starBindingSource1.DataSource = firstFiltration;
                if (firstFiltration.Count == 0)
                    MessageBox.Show("По вашому запиту нічого не знайдено");
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

            List<Star> sorted = list.OrderByDescending(x => x.Distance).Reverse().ToList();

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
                MessageBox.Show("Введіть координати у форматі: широта, довгота\nАбо зайдіть на Google maps та скопіюйте координати та вставте рядок у поле",
                        "Некоректно заповнене поле",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            DateTime time = dateTimePicker2.Value;
            List<string> visibleConstellations = new List<string>();

            foreach (var constellation in astronomy.constellations)
            {
                List<Star> starsInConstellation = astronomy.stars
                    .Where(s => s.Constellation == constellation)
                    .ToList();

                if (starsInConstellation.Count == 0)
                    continue;

                List<Star> visibleStars = Filters.FindVisibleStars(starsInConstellation, lat, lon, time);

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

        private void tabMain_Click(object sender, EventArgs e)
        {
            this.AcceptButton = ApplyAdvancedFilterButton;
        }

        private void tabSearchByStar_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button6;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Star selectedStar)
            {
                EditStarForm editForm = new EditStarForm(astronomy, selectedStar);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Refresh();
                    isModified = true;
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть зірку для редагування.");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Star selectedStar)
            {
                DialogResult result = MessageBox.Show(
                                            $"Ви бажаєте видалити зірку {selectedStar.Name}?",
                                            "Видалити зірку?",
                                            MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Warning
                                            );

                if (result == DialogResult.Yes)
                {
                    astronomy.stars.Remove(selectedStar);
                    updateSearch();
                    dataGridView1.Refresh();
                    isModified = true;
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть зірку для видалення.");
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditStarForm form = new EditStarForm(astronomy, null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Star newStar = form.NewStar;
                astronomy.stars.Add(newStar);
                updateSearch();
                isModified = true;
            }
        }
    }
}
