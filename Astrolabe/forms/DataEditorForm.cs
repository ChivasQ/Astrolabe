using Astrolabe.Models;

namespace Astrolabe.Forms
{
    public partial class DataEditorForm : Form
    {
        public Astronomy astronomy { get; set; }
        public bool isDataChanged { get; set; }

        public DataEditorForm(Astronomy astronomy)
        {
            InitializeComponent();
            this.astronomy = astronomy;
            starBindingSource.DataSource = astronomy.Stars;
            isDataChanged = false;

            this.dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            this.dataGridView1.DataError += dataGridView1_DataError;
            this.dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            this.dataGridView1.CellValidating += dataGridView1_CellValidating;

            constellationBindingSource.DataSource = astronomy.Constellations;

            this.AcceptButton = button1;
        }

        private void updateSearch()
        {
            string search_target = richTextBox1.Text ?? string.Empty;
            List<Star> result = Filters.ApplyAdvancedFilter(search_target, astronomy);
            starBindingSource.DataSource = result;
        }

        private void DataEditorForm_Load(object sender, EventArgs e)
        {
            starBindingSource.DataSource = astronomy.Stars;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.TextChanged -= richTextBox1_TextChanged;
            FilterSyntaxHighlighter.Highlight(richTextBox1);
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            isDataChanged = true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("Помилка при редагуванні данних: " + e.Exception.Message);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isDataChanged = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            if (headerText == "DistanceLightYears" ||
                headerText == "ApparentMagnitude" ||
                headerText == "RightAscension" ||
                headerText == "Declination") // або інші числові поля
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out _)) // чи можна розпарсити значення double
                {
                    MessageBox.Show("Введіть коректне число у поле \"" + headerText + "\".");
                    e.Cancel = true;
                }
            }
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
