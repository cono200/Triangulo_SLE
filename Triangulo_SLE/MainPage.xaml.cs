using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo_SLE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //DECLARANDO VARIABLES
            var altura = float.Parse(Altura.Text); //ACUERDATE WEI, EL ALTURA.TEXT TIENE QUE SER EL MISMO NOMBRE QUE PUSISTES EN LA INTERFAZ (EL X:NAME)
            var basee = float.Parse(Base.Text);
            //PONIENDO LA FORMULA DEL TRIANGULO
            var resultado= (altura*basee/2);

            //DECLARANDO LAS VARIABLES QUE ME SERVIRAN PARA IDENTIFICAR EL TIPO DE TRIANGULO
            var primerLado = float.Parse(PrimerLado.Text);
            var segundoLado= float.Parse(SegundoLado.Text);

            //REGRESAR EL RESULTADO(O ENVIARLO EN OTRAS PALABRAS)

            Resultado.Text= resultado.ToString();
            //CHECANDO QUE TIPO DE TRIANGULO ES 

            string tipoTriangulo = "";
            /*
            if (basee == primerLado && basee == segundoLado)

            {
                tipoTriangulo = "El triangulo esEquilatero";
            }
            else if (basee != primerLado && primerLado != segundoLado)

            {
                tipoTriangulo = "El triangulo  es Escaleno";
            }
            else

            {
                tipoTriangulo = "El triangulo  es Isoceles";
            }
            */
            /*
            //CHENCANDO SI EL USUARIO REALMENTE PUSO VALORES DE UN TRIANGULO
            */
            
            string dudandoTriangulo=""; //VARIABLE PARA CHECAR EL TIPO DE TRIANGULO
            /*
            if ((primerLado + segundoLado)< basee)
            {
                dudandoTriangulo = "Los valores demuestra que no es un triangulo";
            }
            else if ((basee + primerLado) < segundoLado)
            {
                dudandoTriangulo = "Los valores demuestran que no es un triangulo";
            }
            else
            {
                dudandoTriangulo = "Efectivamente si es un triangulo";
            }
            */
           
            


            if (((primerLado + segundoLado) < basee || (basee + primerLado) < segundoLado || (basee + segundoLado) < primerLado))
            {
                dudandoTriangulo = "No es un triangulo karnal";
                DisplayAlert("Su respuesta es", dudandoTriangulo, "Cerrar");
            }
            else
            {
                if (basee == primerLado && basee == segundoLado)

                {
                    tipoTriangulo = "El triangulo esEquilatero";
                }
                else if (basee != primerLado && primerLado != segundoLado)

                {
                    tipoTriangulo = "El triangulo  es Escaleno";
                }
                else

                {
                    tipoTriangulo = "El triangulo  es Isoceles";
                }
            }
            DisplayAlert("Su resultaod es", tipoTriangulo, "Quitar");


        }
    }
}
