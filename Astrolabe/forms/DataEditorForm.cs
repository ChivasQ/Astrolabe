using Astrolabe.models;
using System.Text.RegularExpressions;

namespace Astrolabe.forms
{
    public partial class DataEditorForm : Form
    {
        private Astronomy _originalAstronomy;
        public List<Star> EditedStars { get; private set; }
        public bool isDataChanged { get; set; }

        public DataEditorForm(Astronomy astronomy)
        {
            InitializeComponent();
            _originalAstronomy = astronomy;
            EditedStars = new List<Star>(astronomy.stars);

            starBindingSource.DataSource = EditedStars;
            isDataChanged = false;

            this.dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            this.dataGridView1.DataError += dataGridView1_DataError;
            this.dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            this.AcceptButton = button1; // Apply search filter
        }

        private void updateSearch()
        {
            string search_target = richTextBox1.Text ?? string.Empty;

            List<Star> result = Filters.ApplyAdvancedFilter(search_target,
                new Astronomy
                {
                    stars = EditedStars,
                    constellations = _originalAstronomy.constellations
                });
            starBindingSource.DataSource = result;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            isDataChanged = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isDataChanged = true;
        }

        private void DataEditorForm_Load(object sender, EventArgs e)
        {
            starBindingSource.DataSource = EditedStars;
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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Помилка при редагуванні данних: " + e.Exception.Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            updateSearch();
        }
    }
}
