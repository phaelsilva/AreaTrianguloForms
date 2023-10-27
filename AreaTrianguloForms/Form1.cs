using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double nbase, naltura;
                nbase = double.Parse(txbBase.Text);
                naltura = double.Parse(txbAltura.Text);

                txbResultado.Text = ((nbase * naltura) / 2).ToString();
            }
            catch 
            {
                MessageBox.Show("Dados inválidos informados!");
                txbResultado.Clear();
                txbAltura.Clear();
                txbBase.Clear();
            }
          
        }
    }
}
