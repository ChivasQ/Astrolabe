using Astrolabe.models;
using System.Text.RegularExpressions;

namespace Astrolabe.forms
{
    public partial class DataEditorForm : Form
    {
        public Astronomy astronomy { get; set; }
        public bool isDataChanged { get; set; }
        public DataEditorForm(Astronomy astronomy)
        {
            InitializeComponent();
            this.astronomy = astronomy;
            starBindingSource.DataSource = astronomy.stars;
            isDataChanged = false;
            this.dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;

        }

        private void updateSearch()
        {
            string search_target = richTextBox1.Text;
            List<Star> result = ApplyAdvancedFilter(search_target);
            starBindingSource.DataSource = result;
        }

        private List<Star> ApplyAdvancedFilter(string input)
        {
            var result = astronomy.stars;

            var regex = new Regex(@"(?<field>\w+):(?<op>>=|<=|>|<|=)?(?<value>""[^""]+""|\S+)", RegexOptions.IgnoreCase);
            foreach (Match match in regex.Matches(input))
            {
                string field = match.Groups["field"].Value.ToLower();
                string op = match.Groups["op"].Value;
                string value = match.Groups["value"].Value.Trim('"');

                switch (field)
                {
                    case "distance":
                        if (double.TryParse(value, out double dist))
                        {
                            result = op switch
                            {
                                ">" => result.Where(s => s.DistanceLightYears > dist).ToList(),
                                "<" => result.Where(s => s.DistanceLightYears < dist).ToList(),
                                ">=" => result.Where(s => s.DistanceLightYears >= dist).ToList(),
                                "<=" => result.Where(s => s.DistanceLightYears <= dist).ToList(),
                                "=" or "" => result.Where(s => s.DistanceLightYears == dist).ToList(),
                                _ => result
                            };
                        }
                        break;

                    case "name":
                        result = result.Where(s => s.Name.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList();
                        break;

                    case "magnitude":
                        if (double.TryParse(value, out double mag))
                        {
                            result = op switch
                            {
                                ">" => result.Where(s => s.ApparentMagnitude > mag).ToList(),
                                "<" => result.Where(s => s.ApparentMagnitude < mag).ToList(),
                                ">=" => result.Where(s => s.ApparentMagnitude >= mag).ToList(),
                                "<=" => result.Where(s => s.ApparentMagnitude <= mag).ToList(),
                                "=" or "" => result.Where(s => s.ApparentMagnitude == mag).ToList(),
                                _ => result
                            };
                        }
                        break;

                    case "constellation":
                        result = result.Where(s => s.Constellation.Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
                        break;
                }
            }

            return result;
        }

        private void DataEditorForm_Load(object sender, EventArgs e)
        {
            starBindingSource.DataSource = astronomy.stars;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            isDataChanged = true;
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

            string[] keywords = { "distance:", "name:", "type:", "magnitude:", "constellation:" };
            foreach (string keyword in keywords)
            {
                int index = 0;
                while ((index = text.IndexOf(keyword, index, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    richTextBox1.Select(index, keyword.Length);
                    richTextBox1.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    richTextBox1.SelectionColor = Color.DarkBlue;
                    index += keyword.Length;
                }
            }

            // Відновлення курсору
            richTextBox1.Select(selectionStart, selectionLength);
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // TODO: FIX OUT OF BOUND ERROR
            Star? star = e.Row.DataBoundItem as Star;
            if (star == null)
            {
                e.Cancel = true;
                return;
            }

            var confirm = MessageBox.Show(
                $"Ви дійсно хочете видалити зірку '{star.Name}'?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            // Удаляем из главного списка
            astronomy.stars.Remove(star);
            
            // Обновляем источник данных
            starBindingSource.DataSource = null;
            starBindingSource.DataSource = astronomy.stars;

            isDataChanged = true;
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
