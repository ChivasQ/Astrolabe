using Astrolabe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrolabe.Forms
{
    public partial class EditConstellationForm : Form
    {
        private Constellation constellation;
        private bool isNew;
        private Astronomy astronomy;

        public Constellation NewConstellation { get; private set; }

        public EditConstellationForm(Astronomy astronomy, Constellation? constellation = null)
        {
            InitializeComponent();

            this.astronomy = astronomy;
            this.isNew = constellation == null;
            this.constellation = constellation ?? new Constellation();

            if (!isNew)
            {
                textBoxName.Text = constellation.Name;
                textBoxDescription.Text = constellation.Description;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Назва сузір'я не може бути порожньою.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = 0;
            if (isNew)
            {
                foreach (var existingConstellation in astronomy.Constellations)
                {
                    if (existingConstellation.Id >= id)
                    {
                        id = existingConstellation.Id + 1;
                    }
                }
            }

            foreach (var existingConstellation in astronomy.Constellations)
            {
                if (existingConstellation.Name.Equals(textBoxName.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    (isNew || existingConstellation.Id != constellation.Id))
                {
                    MessageBox.Show("Сузір'я з такою назвою вже існує.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            constellation.Name = textBoxName.Text.Trim();
            constellation.Description = textBoxDescription.Text.Trim();

            NewConstellation = constellation;
            DialogResult = DialogResult.OK;

            this.astronomy.UpdateStarsConstellationNames();

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
