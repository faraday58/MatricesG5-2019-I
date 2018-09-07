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

        Multidimensional mu1;
        Multidimensional mu2;
        Multidimensional mu3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtbEntrada.Text.Contains(";"))
                {
                    mu1 = Multidimensional.Leer(txtbEntrada.Text);
                    lbMatriz1.Text = mu1.ToString();

                }
                else
                {
                    m1 = Unidimensional.Leer(txtbEntrada.Text);
                    lbMatriz1.Text = m1.ToString(); ;
                }
                txtbEntrada.Clear();
                errorproEntrada.Clear();


            }
            catch (FormatException error)
            {
                errorproEntrada.SetError(txtbEntrada, error.Message);
            }
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
               {
                if( txtbEntrada.Text.Contains(";") &&   lbMatriz1.Text.Contains("\n")  )
                {
                    mu2 = Multidimensional.Leer(txtbEntrada.Text);
                    mu3 = mu1 + mu2;
                    lbMatriz2.Text = mu3.ToString();

                }
                else
                {
                    m2 = Unidimensional.Leer(txtbEntrada.Text);
                    if (m1.N != m2.N)
                    {
                        string error = "Las matrices deben ser conformables";
                        throw new ApplicationException(error);
                    }
                    m3 = m1 + m2;
                    lbMatriz2.Text = m3.ToString();
                    
                }
                errorproEntrada.Clear();
                txtbEntrada.Clear();
            }
                
            catch(ApplicationException error)
            {
                errorproEntrada.SetError(txtbEntrada, error.Message);

            }
            catch(FormatException error)
            {
                errorproEntrada.SetError(txtbEntrada, error.Message);
            }
            
        }
    }
}
