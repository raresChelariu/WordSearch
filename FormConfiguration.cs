using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearch
{
    public partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void buttonApplyConfiguration_Click(object sender, EventArgs e)
        {

            if (radioButtonIncepator.Checked)
                App.Difficulty = GameDifficulty.Incepator;
            else if (radioButtonMediu.Checked)
                App.Difficulty = GameDifficulty.Mediu;
            else if (radioButtonAvansat.Checked)
                App.Difficulty = GameDifficulty.Avansat;
            else
            {
                MessageBox.Show("Selecteaza o dificultate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show($"Configurarile sunt aplicate pentru urmatoarele jocuri.{App.Difficulty}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
