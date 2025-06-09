using Astrolabe.Forms;
using Astrolabe.models;
using Astrolabe.Models;

namespace Astrolabe
{
    public partial class MainForm : Form
    {
        Astronomy astronomy;
        bool FileOpened = false;
        private bool isModified = false;
        Settings settings = Settings.Load();
        private double? selectedLatitude = null;
        private double? selectedLongitude = null;


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
                    astronomy.Deserialize(settings.LastOpenedFile);

                    FileOpened = true;
                    isModified = false;

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
            starBindingSource1.DataSource = astronomy.Stars;

            starBindingSource2.DataSource = null;
            starBindingSource2.DataSource = astronomy.Constellations;

            comboBox1.DataSource = null;
            comboBox1.DataSource = astronomy.Constellations;

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
            var form = new DataEditorForm(astronomy);
            form.ShowDialog();
            if (form.isDataChanged)
            {
                if (!FileOpened)
                {
                    FileOpened = true;
                }
                isModified = true;

            }
            RemoveNullNames();
            updateSearch();
        }

        public void RemoveNullNames()
        {
            astronomy.Stars.RemoveAll(s => string.IsNullOrWhiteSpace(s.Name));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FileOpened || listBox1.SelectedItem == null)
                return;

            Constellation selectedConstellation = listBox1.SelectedItem as Constellation;

            if (selectedConstellation != null)
            {
                var starsInConstellation = astronomy?.Stars
                    ?.Where(s => s.ConstellationId == selectedConstellation.Id)
                    ?.ToList();

                starBindingSource.DataSource = starsInConstellation ?? new List<Star>();
            }
            else
            {
                starBindingSource.DataSource = new List<Star>();
            }
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

            if (selectedLatitude.HasValue && selectedLongitude.HasValue)
            {
                lat = selectedLatitude.Value;
                lon = selectedLongitude.Value;
                coordsParsed = true;
            }


            if (coordsParsed)
            {
                DateTime time = dateTimePicker1.Value;
                List<Star> secondFiltration = Filters.FindVisibleStars(firstFiltration, lat, lon, time);
                if (checkBox1.Checked)
                {
                    if (comboBox1.SelectedItem is Constellation selectedFilterConstellation)
                    {
                        secondFiltration = secondFiltration.Where(s => s.ConstellationId == selectedFilterConstellation.Id).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, виберіть сузір’я для фільтрації.", "Помилка фільтрації", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                starBindingSource1.DataSource = null;
                starBindingSource1.DataSource = secondFiltration;
                if (secondFiltration.Count == 0)
                    MessageBox.Show("По вашому запиту нічого не знайдено");
            }
            else
            {
                if (checkBox1.Checked)
                {
                    if (comboBox1.SelectedItem is Constellation selectedFilterConstellation)
                    {
                        firstFiltration = firstFiltration.Where(s => s.ConstellationId == selectedFilterConstellation.Id).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, виберіть сузір’я для фільтрації.", "Помилка фільтрації", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                starBindingSource1.DataSource = null;
                starBindingSource1.DataSource = firstFiltration;
                if (firstFiltration.Count == 0)
                    MessageBox.Show("По вашому запиту нічого не знайдено");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.TextChanged -= richTextBox1_TextChanged;
            FilterSyntaxHighlighter.Highlight(richTextBox1);
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Ви дійсно бажаєте зкинути всі фільтри?",
                "зкинути фільтри?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );
            if (result != DialogResult.Yes)
                return;
            button8.Text = "Вибрати на карті";
            richTextBox1.Text = string.Empty;
            selectedLatitude = null;
            selectedLongitude = null;
            updateSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);
            if (list == null) return;
            List<Star> sorted = list.OrderByDescending(x => x.ApparentMagnitude).Reverse().ToList();
            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);
            if (list == null) return;
            List<Star> sorted = list.OrderByDescending(x => x.Name).Reverse().ToList();
            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);
            if (list == null) return;
            // Щоб сортувати за назвою сузір'я, потрібно об'єднати дані про сузір'я.
            List<Star> sorted = list
                                .Join(astronomy.Constellations,
                                      star => star.ConstellationId,
                                      constellation => constellation.Id,
                                      (star, constellation) => new { Star = star, ConstellationName = constellation.Name })
                                .OrderByDescending(x => x.ConstellationName)
                                .Select(x => x.Star)
                                .ToList();

            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Star> list = (starBindingSource1.DataSource as List<Star>);
            if (list == null) return;
            List<Star> sorted = list.OrderByDescending(x => x.Distance).Reverse().ToList();
            starBindingSource1.DataSource = null;
            starBindingSource1.DataSource = sorted;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double lat = 0, lon = 0;
            bool coordsParsed = false;

            if (selectedLatitude.HasValue && selectedLongitude.HasValue)
            {
                lat = selectedLatitude.Value;
                lon = selectedLongitude.Value;
                coordsParsed = true;
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
            List<Constellation> visibleConstellations = new List<Constellation>();

            foreach (var constellation in astronomy.Constellations)
            {
                List<Star> starsInConstellation = astronomy.Stars
                    .Where(s => s.ConstellationId == constellation.Id)
                    .ToList();

                if (starsInConstellation.Count == 0)
                    continue;

                List<Star> visibleStars = Filters.FindVisibleStars(starsInConstellation, lat, lon, time);

                // Якщо всі зірки сузір'я видимі — додаємо сузір’я до видимих
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
            starBindingSource2.DataSource = astronomy.Constellations;
        }

        private void tabMain_Click(object sender, EventArgs e)
        {
            this.AcceptButton = ApplyAdvancedFilterButton;
        }

        private void tabSearchByStar_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button6;
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
                    astronomy.Stars.Remove(selectedStar);
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
                astronomy.Stars.Add(newStar);
                updateSearch();
                isModified = true;
            }
        }

        private void buttonPickLocation_Click(object sender, EventArgs e)
        {
            LocationPickerForm form = new LocationPickerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedLatitude = form.latitude;
                selectedLongitude = form.longitude;

                MessageBox.Show($"Ви вибрали: {form.latitude}, {form.longitude}");
                button8.Text = $"{form.latitude:F2}, {form.longitude:F2}";
            }
        }
    }
}