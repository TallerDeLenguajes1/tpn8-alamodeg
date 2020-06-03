using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMejorada
{
    public partial class Form1 : Form
    {
        Calculadora NuevaCalculadora = new Calculadora();
        LinkedList<String> MiVisor = new LinkedList<string>();

        float num1;
        float num2;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "9";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + ","; //SE ROMPE SI INGRESA MAS DE 1 COMA
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            tbxPantalla.Clear();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+"; //Guardo el operador
            num1 = float.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }
        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = float.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = float.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = float.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(tbxPantalla.Text);

            
            switch (operador)
            {
                 case "+":
                    tbxPantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    tbxPantalla.Text = Convert.ToString(NuevaCalculadora.Sumar());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) +" ----> "+ num1 + " + " + num2 + " = " + (num1+num2));
                    break;
                 case "-":
                    tbxPantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    tbxPantalla.Text = Convert.ToString(NuevaCalculadora.Restar());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) + " ----> " + num1 + " + " + num2 + " = " + (num1 - num2));
                    break;
                 case "*":
                    tbxPantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    tbxPantalla.Text = Convert.ToString(NuevaCalculadora.Multiplicar());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) + " ----> " + num1 + " + " + num2 + " = " + (num1 * num2));
                    break;
                 case "/":
                    if (num2 == 0)
                    {
                        tbxPantalla.Text = "MATH ERROR!!"; break;
                    }
                    tbxPantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    tbxPantalla.Text = Convert.ToString(NuevaCalculadora.Dividir());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) + " ----> " + num1 + " + " + num2 + " = " + (num1 / num2));
                    break;
            }
        }

        private void lbxHistorial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Operacion eliminada!");
            lbxHistorial.Items.RemoveAt(lbxHistorial.SelectedIndex);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Historial vacio!");
            lbxHistorial.Items.Clear();
        }
    }
}
