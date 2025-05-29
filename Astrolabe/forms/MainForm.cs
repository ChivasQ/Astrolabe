using Astrolabe.models;
using System.Drawing.Drawing2D;
using System.Text.Json;

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
            //this.FormBorderStyle = FormBorderStyle.None;
            //int radius = 10;
            //Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            //GraphicsPath path = GetRoundedRectPath(bounds, radius);
            //this.Region = new Region(path);
            astronomy.Fill(100);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateSearch();
        }

        private void updateSearch()
        {
            string search_target = textBox10.Text;
            List<Star> result = astronomy.FindAll(search_target);
            Console.WriteLine("ЄУЄУЄ");
            starBindingSource1.DataSource = result;
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
                updateSearch();
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
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
