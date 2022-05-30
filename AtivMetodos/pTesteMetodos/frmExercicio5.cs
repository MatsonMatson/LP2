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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {
            Random sorteio = new Random();
            int num1, num2;

            if (int.Parse(txtNum1.Text) <= int.Parse(txtNum2.Text))
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
            }
            else
            {
                num1 = int.Parse(txtNum2.Text);
                num2 = int.Parse(txtNum1.Text);
            }

            string ss = sorteio.Next(num1, num2).ToString();
            MessageBox.Show(ss);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }
    }
}
