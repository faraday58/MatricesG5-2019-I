using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatricesG5_2019_I
{
    public partial class Form1 : Form
    {
        Unidimensional m1;
        Unidimensional m2;
        Unidimensional m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            m1 = Unidimensional.Leer(txtbEntrada.Text);
            lbMatriz1.Text = m1.ToString(); ;
            txtbEntrada.Clear();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            m2 = Unidimensional.Leer(txtbEntrada.Text);
            m3 = m1 + m2;
            lbMatriz2.Text = m3.ToString();
            txtbEntrada.Clear();
        }
    }
}
