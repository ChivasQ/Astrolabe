using Astrolabe.Models;
using System.Data;

namespace Astrolabe.Forms
{
    public partial class DeleteConstellationForm : Form
    {
        private Constellation constellation;
        public Astronomy astronomy { get; set; }
        public DeleteConstellationForm(Constellation constellation, Astronomy astronomy)
        {
            InitializeComponent();
            this.constellation = constellation;
            this.astronomy = astronomy;

            if (constellation != null)
            {
                label1.Text = $"Ви дійсно бажаєте видалити сузір'я '{constellation.Name}'?";
                label2.Text = $"({astronomy.Stars.Where(s => s.ConstellationId == constellation.Id).ToList().Count} зірок у сузір'ї)";
            }
            else
            {
                label1.Text = "Ви дійсно бажаєте видалити це сузір'я?";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Видалити сузір'я та всі зірки, що до нього належать
                astronomy.Constellations.Remove(constellation);
                astronomy.Stars.RemoveAll(s => s.ConstellationId == constellation.Id);
            }
            else if (radioButton2.Checked)
            {
                // Видалити лише сузір'я, зірки залишаються
                astronomy.Stars.Where(s => s.ConstellationId == constellation.Id)
                               .ToList()
                               .ForEach(s => { s.ConstellationId = -1; s.Constellation = "Без сузір'я"; });
                astronomy.Constellations.Remove(constellation);
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть один з варіантів видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
