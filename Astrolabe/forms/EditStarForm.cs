using Astrolabe.models;

namespace Astrolabe.forms
{
    public partial class EditStarForm : Form
    {
        private Star star;

        public EditStarForm(Star star, Astronomy astronomy)
        {
            InitializeComponent();
            this.star = star;

            // Ініціалізуємо поля поточними даними
            textBoxName.Text = star.Name;
            textBoxDescription.Text = star.Description;
            textBoxRA.Text = star.RightAscension.ToString();
            textBoxDec.Text = star.RightAscension.ToString();
            comboBox1.Text = star.Constellation.ToString();
            textBoxMagnitude.Text = star.ApparentMagnitude.ToString();
            textBoxDistance.Text = star.Distance.ToString();

            comboBox1.DataSource = astronomy.constellations;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Перевірка й присвоєння нових значень
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Назва зірки не може бути порожньою.");
                return;
            }

            star.Name = textBoxName.Text;
            star.Description = textBoxDescription.Text;

            if  (
                !double.TryParse(textBoxRA.Text, out double ra) ||
                !double.TryParse(textBoxDec.Text, out double dec) ||
                !double.TryParse(textBoxMagnitude.Text, out double mag) ||
                !double.TryParse(textBoxDistance.Text, out double dist)
                )
            {
                MessageBox.Show("Некоректні числові значення.");
                return;
            }

            star.RightAscension = ra;
            star.Declination = dec;
            star.ApparentMagnitude = mag;
            star.Distance = dist;

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
