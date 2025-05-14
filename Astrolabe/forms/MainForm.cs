using Astrolabe.models;
using System.Drawing.Drawing2D;

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
            string search_target = null;//textBox1.Text;
            List<Star> result = astronomy.FindAll(search_target);
            Console.WriteLine(result.Count);
            starBindingSource1.DataSource = result;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
