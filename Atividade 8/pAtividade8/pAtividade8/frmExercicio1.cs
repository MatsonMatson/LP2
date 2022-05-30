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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnEspacBranco_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            int Brancos = 0;
            int pos = texto.Length - 1;

            if (texto != string.Empty)
                while (pos >= 0)
                {
                    if (texto[pos] == ' ')
                        Brancos++;

                    pos--;
                }

            txtEspacBranco.Text = Brancos.ToString();
        }

        private void BtnLetraR_Click(object sender, EventArgs e)
        {
            int R = 0;

            foreach (char letra in txtTexto.Text)
            {
                if (char.ToUpper(letra) == 'R')
                {
                    R++;
                }
            }

            txtLetraR.Text = R.ToString();
        }

        private void BtnPares_Click(object sender, EventArgs e)
        {
            int Pares = 0;
            string texto = txtTexto.Text;

            for (int letra = 0; letra < texto.Length - 1; letra++)
            {
                if (texto[letra] == texto[letra + 1])
                    Pares++;
            }

            txtPares.Text = Pares.ToString();
        }


    }
}
