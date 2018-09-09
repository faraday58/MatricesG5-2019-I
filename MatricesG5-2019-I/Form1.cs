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
                if( txtbEntrada.Text.Contains(";")  )
                {
                    mu1 = Multidimensional.Leer(txtbEntrada.Text);
                    lbMatriz1.Text = mu1.ToString();
                }
                else
                {
                    m1 = Unidimensional.Leer(txtbEntrada.Text);
                    lbMatriz1.Text = m1.ToString();
                }                
                errorProv.Clear();
            }
            catch(FormatException error)
            {
                errorProv.SetError(txtbEntrada, error.Message);
            }
            catch (IndexOutOfRangeException)
            {
                errorProv.SetError(txtbEntrada, "Error al introducir la matriz");
            }

            txtbEntrada.Clear();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {

                if(mu1 == null)
                {
                    throw new ApplicationException("Ingrese una matriz de inicio");
                }

                if (txtbEntrada.Text.Contains(";"))
                {
                    mu2 = Multidimensional.Leer(txtbEntrada.Text);

                    if((mu1.N != mu2.N) && (mu1.M != mu2.M))
                    {

                        throw new ApplicationException("Error de dimensión");
                    }
                    mu3 = mu1 + mu2;
                    lbMatriz2.Text = mu3.ToString();
                    
                }
                else {
                    m2 = Unidimensional.Leer(txtbEntrada.Text);
                    if( m1 == null )
                    {
                        throw new ApplicationException("Error de dimensión");
                    }

                    if (m1.N != m2.N)
                    {
                        throw new ApplicationException("Error de dimesión!!!");

                    }
                    m3 = m1 + m2;
                    lbMatriz2.Text = m3.ToString();
                }
                errorProv.Clear();
                
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(txtbEntrada, error.Message);
            }
            catch (FormatException error)
            {

                errorProv.SetError(txtbEntrada, error.Message);
            }
            catch(IndexOutOfRangeException )
            {
                errorProv.SetError(txtbEntrada, "Error al introducir la matriz");
            }
            
            txtbEntrada.Clear();
        }
    }
}
