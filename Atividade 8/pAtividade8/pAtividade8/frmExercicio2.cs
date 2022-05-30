using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAtividade8
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerarH_Click(object sender, EventArgs e)
        {
            int num;
            int i;
            double h = 1;

            if (int.TryParse(txtNum.Text, out num))
            {
                if (num <= 0)
                {
                    MessageBox.Show("Valor inválido. Digite um número maior que zero");
                }
                else
                {
                    for (i = 2; i <= num; i++)
                    {
                        h += (1.0 / i);
                    }
                    MessageBox.Show(h.ToString(), "Número H");
                }
            }

            else
            {
                MessageBox.Show("Por favor, coloque um número inteiro!");
            }
        }
    }
}
