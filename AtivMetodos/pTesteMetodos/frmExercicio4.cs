using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTesteMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            int quantidade = 0;

            for (int caracter = 0; caracter < rtxtbCaracter.Text.Length; caracter++)
            {
                if (char.IsDigit(rtxtbCaracter.Text[caracter]))
                    quantidade++;
            }

            txtNum.Text = quantidade.ToString();
        }

        private void BtnCaraBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            if (rtxtbCaracter.Text != "")
                while (rtxtbCaracter.Text[posicao] != ' ')
                {
                    if (posicao == rtxtbCaracter.Text.Length - 1)
                    {
                        posicao = 0;
                        break;
                    }

                    posicao++;
                }

            txtCaracBranco.Text = posicao.ToString();
        }

        private void BtnCaracAlfab_Click(object sender, EventArgs e)
        {
            int quantidade = 0;

            foreach (char caracter in rtxtbCaracter.Text)
            {
                if (char.IsLetter(caracter))
                    quantidade++;
            }

            txtAlfab.Text = quantidade.ToString();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtCaracBranco.Clear();
            txtAlfab.Clear();
        }
    }
}
