using Astrolabe.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrolabe.forms
{
    public partial class AddStarForm : Form
    {
        public Star NewStar { get; private set; }

        public AddStarForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            double mag = double.Parse(textBoxMagnitude.Text);

            NewStar = new Star(name, mag);
            NewStar.Description = description;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
