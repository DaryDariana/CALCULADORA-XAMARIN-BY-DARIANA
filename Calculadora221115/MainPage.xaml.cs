using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculadora221115
{
    public partial class MainPage : ContentPage

    {
        /* variables*/
        private double numero1;
        private double numero2;
        private string operador;

      
        public MainPage()
        {
            InitializeComponent();
        }

        /*metodo y parametros*/
        private void clickNumero(object sender, EventArgs e)
        {
            /*conversion del sender a button*/
            Button tmp = (Button)sender;
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = tmp.Text;
            }
            else
            {
                txtResultado.Text += tmp.Text;
            }

        }

        /*metodo limpiar*/
        private void clickLimpiar(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = null;
            txtResultado.Text = "0";
        }

        /*metodo borrar*/
        private void clickBorrar(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text.Substring
                (0, txtResultado.Text.Count() - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        /*metodos operaciones matematicas */
        private void clickSuma(object sender, EventArgs e)
        {
            operador = "+";
            numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickResta(object sender, EventArgs e)
        {
            operador = "-";
            numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickMultiplicar(object sender, EventArgs e)
        {
            operador = "*";
            numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickDividir(object sender, EventArgs e)
        {
            operador = "/";
            numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void clickPorcentaje(object sender, EventArgs e)
        {
            operador = "%";
            numero1 = Double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        /*Metodo igual*/
        private void clickIgual(object sender, EventArgs e)

        {
            numero2 = Double.Parse(txtResultado.Text);
            double operacionFinal = 0;

            if (txtResultado.Text == "")
            {
                txtResultado.Text = "0";
            }

            else if (operador == "+")
            {
                operacionFinal = numero1 + numero2;
            }

            else if (operador == "-")
            {
                operacionFinal = numero1 - numero2;
            }
            else if (operador == "*")
            {
                operacionFinal = numero1 * numero2;
            }
            else if (operador == "/")
            {
                operacionFinal = numero1 / numero2;
            }
            else if (operador == "%")
                operacionFinal = (numero1) * numero2;               

        txtResultado.Text = operacionFinal.ToString();

        }
    }
}
