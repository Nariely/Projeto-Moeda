using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Moedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
          
                double real = double.Parse(txb1.Text);
                double resultado = 0;
               
                {
                    resultado = (0.1824 * real);
                lblResposta.Text = resultado.ToString();
            }
        }

        private void lblResposta_Click(object sender, EventArgs e)
        {
           
        }
    }
}

