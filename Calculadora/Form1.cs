using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public enum Operacion
    {
        NoDefinida=0,
        Suma =1,
        Resta =2,
        Division =3,
        Multiplicacion =4,
        Modulo =5,
    }

    public partial class Calculadora : Form
    {
        double num1 = 0;
        double num2 = 0;
        Operacion operador = Operacion.NoDefinida;
        bool numleido = false;


        public Calculadora()
        {
            InitializeComponent();
        }

        private void LeerNumero(String numero)
        {
            numleido = true;
            if (tresult.Text == "0" && tresult.Text != null)
            {
                tresult.Text = numero;

            }
            tresult.Text += numero;
        }

        private double RealizarOperacion()
        { double resultado = 0;
            switch (operador)
            {
                                   
               case Operacion.Suma:
                    resultado = num1 + num2;
                    break;
               case Operacion.Resta:
                    resultado = num1 - num2;
                    break;
               case Operacion.Division:
                    if (num2 == 0)
                    {
                        MessageBox.Show("La division entre cero no está permitida");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }                   
                    break;
                case Operacion.Multiplicacion:
                    resultado = num1 * num2;
                    break;
               case Operacion.Modulo:
                    resultado = num1 % num2;
                    break;


            }

            return resultado;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tresultado_Load(object sender, EventArgs e)
        {

        }

        private void btncero_Click(object sender, EventArgs e)
        {
            numleido = true;
            if (tresult.Text== "0")
            {
                return;
            }

            else
            {
                tresult.Text += "0";
            }                      

        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");

        }

        private void btndos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void ObtenerResultado(string operador )
        {
            num1 = Convert.ToDouble(tresult.Text);
            lhistorial.Text = tresult.Text + operador;
            tresult.Text = "0";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerResultado("+");

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            if (num2 == 0 && numleido)
            {
                num2 = Convert.ToDouble(tresult.Text);
                lhistorial.Text += num2 + "=";
                double resultado = RealizarOperacion();
                num1 = 0;
                num2 = 0;
                numleido = false;
                tresult.Text = Convert.ToString(resultado);

            }

        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerResultado("-");
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerResultado("*");
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerResultado("/");
        }

        private void btnmodulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerResultado("%");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            tresult.Text = "0";
            lhistorial.Text = "";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            if (tresult.Text.Length > 1)
            {
                string txtres = tresult.Text;
                txtres = txtres.Substring(0, txtres.Length - 1);
                
                if (txtres.Length == 1 && txtres.Contains("-"))
                    {
                    tresult.Text = "0";
                }
                else
                {
                    tresult.Text = txtres;
                }
            }
            else
            {
                tresult.Text = "0";
            }
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            if (tresult.Text.Contains("."))
                {
                return;
            }
            tresult.Text += ".";
        }
    }
}
