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
            try
            {
                m1 = Unidimensional.Leer(txtbEntrada.Text);
                lbMatriz1.Text = m1.ToString(); ;
                txtbEntrada.Clear();
                errorproEntrada.Clear();
            }
            catch(FormatException error)
            {
                errorproEntrada.SetError(txtbEntrada, error.Message);
            }
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
               {
                m2 = Unidimensional.Leer(txtbEntrada.Text);
                if( m1.N != m2.N)
                 {
                    string error = "Las matrices deben ser conformables";
                    throw new ApplicationException(error);
                 }
                    m3 = m1 + m2;
                    lbMatriz2.Text = m3.ToString();
                errorproEntrada.Clear();
                    txtbEntrada.Clear();
                }
            catch(ApplicationException error)
            {
                errorproEntrada.SetError(txtbEntrada, error.Message);

            }
            
        }
    }
}
