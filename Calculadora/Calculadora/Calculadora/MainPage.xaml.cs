
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {


        String operador;
        int numero1;
        int numero2;
        int posicionSigno;
        int resultado;
        bool error;
        public MainPage()
        {
            InitializeComponent();
        }

        private void clickedNumeros(object sender, EventArgs e)
        {

            string valor;
            valor = ((Button)sender).Text;

            if (textoResultado.Text == "0")
            {
                textoResultado.Text = valor;
            }
            else
            {
                textoResultado.Text += valor;
                
            }

        }

        private void botonSumar_Clicked(object sender, EventArgs e)
        {
            
            if (textoResultado.Text != "")
            {
                String ultimaPosicion = textoResultado.Text.Substring(textoResultado.Text.Length - 1);
                if (ultimaPosicion != "+" && ultimaPosicion != "-" && ultimaPosicion != "x" && ultimaPosicion != "÷")
                {
                    numero1 = Convert.ToInt32(textoResultado.Text);
                    if (textoResultado.Text.Substring(0, 0) == "-")
                    {
                        numero1 *= -1;
                    }

                    operador = "+";
                    textoResultado.Text += "+";
                    posicionSigno = textoResultado.Text.Length - 1;
                }
            }

        }

        private void botonRestar_Clicked(object sender, EventArgs e)
        {

            if (textoResultado.Text == "")
            {
                textoResultado.Text = "-";
            }

            String ultimaPosicion = textoResultado.Text.Substring(textoResultado.Text.Length - 1);
            if (ultimaPosicion != "+" && ultimaPosicion != "-" && ultimaPosicion != "x" && ultimaPosicion != "÷")
            {

                numero1 = Convert.ToInt32(textoResultado.Text);
                if (textoResultado.Text.Substring(0,0) == "-")
                {
                    numero1 *= -1;
                }

                textoResultado.Text += "-";
                operador = "-";
                posicionSigno = textoResultado.Text.Length - 1;
            }



        }

        private void botonMultiplicar_Clicked(object sender, EventArgs e)
        {


            if (textoResultado.Text != "")
            {
                String ultimaPosicion = textoResultado.Text.Substring(textoResultado.Text.Length - 1);
                if (ultimaPosicion != "+" && ultimaPosicion != "-" && ultimaPosicion != "x" && ultimaPosicion != "÷" && textoResultado.Text != "")
                {
                    numero1 = Convert.ToInt32(textoResultado.Text);
                    if (textoResultado.Text.Substring(0, 0) == "-")
                    {
                        numero1 *= -1;
                    }

                    operador = "x";
                    textoResultado.Text += "x";
                    posicionSigno = textoResultado.Text.Length - 1;
                }
            }


        }

        private void botonDividir_Clicked(object sender, EventArgs e)
        {

            if (textoResultado.Text != "")
            {
                String ultimaPosicion = textoResultado.Text.Substring(textoResultado.Text.Length - 1);
                if (ultimaPosicion != "+" && ultimaPosicion != "-" && ultimaPosicion != "x" && ultimaPosicion != "÷" && textoResultado.Text != "")
                {
                    numero1 = Convert.ToInt32(textoResultado.Text);
                    if (textoResultado.Text.Substring(0, 0) == "-")
                    {
                        numero1 *= -1;
                    }

                    operador = "÷";
                    textoResultado.Text += "÷";
                    posicionSigno = textoResultado.Text.Length - 1;
                }
            }


        }

        private void botonResultado_Clicked(object sender, EventArgs e)
        {
            error = false;
            if (posicionSigno != textoResultado.Text.Length-1 && operador != "vacio")
            {
                numero2 = Convert.ToInt32(textoResultado.Text.Substring(posicionSigno + 1));

                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        textoResultado.Text = Convert.ToString(resultado);
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        textoResultado.Text = Convert.ToString(resultado);
                        break;
                    case "x":
                        resultado = numero1 * numero2;
                        textoResultado.Text = Convert.ToString(resultado);
                        break;
                    case "÷":

                        if (numero2 == 0)
                        {
                            error = true;
                            DisplayAlert("Error", "No se puede dividir entre 0", "Cerrar");
                            textoResultado.Text = "";
                        }
                        else
                        {
                            resultado = numero1 / numero2;
                            textoResultado.Text = Convert.ToString(resultado);
                        }

                        break;
                }

                if (error != true)
                {
                    Label lblResultados = new Label();
                    lblResultados.FontSize = 20;
                    lblResultados.HorizontalTextAlignment = (TextAlignment)1;
                    lblResultados.Text = textoResultado.Text;
                    resultados.Children.Add(lblResultados);
                }

                operador = "vacio";
                textoResultado.Text = "";
            } 
            
        }

        private void botonLimpiar_Clicked(object sender, EventArgs e)
        {
            textoResultado.Text = "";
        }

        private void botonTemaClaro_Clicked(object sender, EventArgs e)
        {
            Resources["estiloBotonesNumeros"] = Resources["estiloBotonesNumerosClaro"];
            Resources["estiloBotonesOperadores"] = Resources["estiloBotonesNumerosClaro"];
            Resources["estiloGrid"] = Resources["estiloGridClaro"];
        }

        private void botonTemaOscuro_Clicked(object sender, EventArgs e)
        {
            Resources["estiloBotonesNumeros"] = Resources["estiloBotonesNumerosOscuro"];
            Resources["estiloBotonesOperadores"] = Resources["estiloBotonesNumerosOscuro"];
            Resources["estiloGrid"] = Resources["estiloGridOscuro"];
        }
    }
}