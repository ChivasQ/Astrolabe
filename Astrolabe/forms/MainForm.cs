using Astrolabe.Models;

namespace Astrolabe
{
    public partial class MainForm : Form
    {
        Astronomy astronomy;
        public MainForm()
        {
            InitializeComponent();
            astronomy = new Astronomy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            astronomy.Fill(100);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void updateSearch()
        {
            string search_target = textBox1.Text;
            List<Star> result = astronomy.FindAll(search_target);
            Console.WriteLine(result.Count);
            starBindingSource1.DataSource = result;
        }
    }
}
