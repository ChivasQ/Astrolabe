using Astrolabe.Models;

namespace Astrolabe.Forms
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

            comboBox1.DataSource = astronomy.Constellations;

            if (!isNew)
            {
                textBoxName.Text = star.Name;
                textBoxDescription.Text = star.Description;
                textBoxRA.Text = star.RightAscension.ToString();
                textBoxDec.Text = star.Declination.ToString();

                var selectedConstellation = astronomy.Constellations.FirstOrDefault(c => c.Id == star.ConstellationId);
                if (selectedConstellation != null)
                {
                    comboBox1.SelectedItem = selectedConstellation;
                }
                else
                {
                    //comboBox1.SelectedIndex = -1;
                }

                textBoxMagnitude.Text = star.ApparentMagnitude.ToString();
                textBoxDistance.Text = star.Distance.ToString();
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Назва зірки не може бути порожньою.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (
                !double.TryParse(textBoxRA.Text.Replace('.', ','), out double ra) ||
                !double.TryParse(textBoxDec.Text.Replace('.', ','), out double dec) ||
                !double.TryParse(textBoxMagnitude.Text.Replace('.', ','), out double mag) ||
                !double.TryParse(textBoxDistance.Text.Replace('.', ','), out double dist)
            )
            {
                MessageBox.Show("Некоректні числові значення. Будь ласка, перевірте введені дані.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ra < 0 || ra > 24)
            {
                MessageBox.Show("Пряме сходження (RA) повинно бути між 0 та 24 годинами.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dec < -90 || dec > 90)
            {
                MessageBox.Show("Схилення (DEC) повинно бути між -90 та 90 градусами.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dist <= 0)
            {
                MessageBox.Show("Відстань повинна бути додатним числом.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            star.Name = textBoxName.Text.Trim();
            star.Description = textBoxDescription.Text.Trim();
            star.RightAscension = ra;
            star.Declination = dec;
            star.ApparentMagnitude = mag;
            star.Distance = dist;

            if (comboBox1.SelectedItem is Constellation selectedConstellation)
            {
                star.ConstellationId = selectedConstellation.Id;
                star.Constellation = selectedConstellation.Name;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть сузір'я.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewStar = star;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}