using Astrolabe.models;

namespace Astrolabe.forms
{
    public partial class EditStarForm : Form
    {
        private Star star;
        private bool isNew;
        private Astronomy astronomy;

        public Star NewStar { get; private set; }

        public EditStarForm(Astronomy astronomy, Star? star = null)
        {
            InitializeComponent();
            this.astronomy = astronomy;
            this.star = star ?? new Star();
            this.isNew = star == null;

            comboBox1.DataSource = astronomy.constellations;

            if (!isNew)
            {
                textBoxName.Text = star.Name;
                textBoxDescription.Text = star.Description;
                textBoxRA.Text = star.RightAscension.ToString();
                textBoxDec.Text = star.Declination.ToString();
                comboBox1.Text = star.Constellation;
                textBoxMagnitude.Text = star.ApparentMagnitude.ToString();
                textBoxDistance.Text = star.Distance.ToString();
            }
            else 
            {
                comboBox1.Text = "";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Назва зірки не може бути порожньою.");
                return;
            }

            if (
                !double.TryParse(textBoxRA.Text, out double ra) ||
                !double.TryParse(textBoxDec.Text, out double dec) ||
                !double.TryParse(textBoxMagnitude.Text, out double mag) ||
                !double.TryParse(textBoxDistance.Text, out double dist)
            )
            {
                MessageBox.Show("Некоректні числові значення.");
                return;
            }

            star.Name = textBoxName.Text.Trim();
            star.Description = textBoxDescription.Text.Trim();
            star.RightAscension = ra;
            star.Declination = dec;
            star.ApparentMagnitude = mag;
            star.Distance = dist;
            star.Constellation = comboBox1.SelectedItem?.ToString() ?? string.Empty;

            NewStar = star;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
