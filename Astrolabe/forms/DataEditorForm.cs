using Astrolabe.models;

namespace Astrolabe.forms
{
    public partial class DataEditorForm : Form
    {
        public Astronomy astronomy { get; set; }
        public DataEditorForm(Astronomy astronomy)
        {
            InitializeComponent();
            this.astronomy = astronomy;
            starBindingSource.DataSource = astronomy.stars;
        }


        private void updateSearch()
        {
            string search_target = textBox3.Text;
            List<Star> result = astronomy.FindAll(search_target);
            Console.WriteLine("ЄУЄУЄ");
            starBindingSource.DataSource = result;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void DataEditorForm_Load(object sender, EventArgs e)
        {
            starBindingSource.DataSource = astronomy.stars;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddStarForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                astronomy.stars.Add(addForm.NewStar);
                updateSearch();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedStar = starBindingSource.Current as Star;
            if (selectedStar == null)
            {
                MessageBox.Show("Будь ласка, виберіть зірку для видалення.");
                return;
            }

            var result = MessageBox.Show($"Ви дійсно хочете видалити зірку '{selectedStar.Name}'?",
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                astronomy.stars.Remove(selectedStar);
                starBindingSource.Remove(selectedStar);
                updateSearch();
            }
        }
    }
}
