using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
        }

        ////////////METODOS

        //FACTORIAL DE N
        public int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        //SUMA DE NUMEROS
        public int Suma(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + Suma(n - 1);
        }
        //SERIE FIBONACCI
        public int Fibbo(int n)
        {
            if (n == 0 || n == 1 || n == 2)
                return 1;
            else
                return Fibbo(n - 1) + Fibbo(n - 2);
        }
        //SUMA DE DOS NUMEROS
        public int Suma2(int a, int b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            else
                return 1 + Suma2(a, b - 1);
        }
        //TABLA DE MULTIPLICAR
        public void TablaDeMultiplicar(int a, int n)
        {
            if (n == 0)
                listBox5.Items.Add(a + " x " + n + " = " + (a * n));
            else
            {
                listBox5.Items.Add(a + " x " + n + " = " + (a * n));
                TablaDeMultiplicar(a, n - 1);
            }
        }
        //INVERTIR UN NUMERO
        public string InvertirNumero(int num)
        {
            if (num < 10)
                return Convert.ToString(num);
            else
                return Convert.ToString(num % 10) + InvertirNumero(num / 10);                   
        }
        //SUMAR LOS DIGITOS DE UN NUMERO
        public int SumaDeDigitos(int num)
        {
            if (num < 10)
                return num;
            else
                return (num % 10) + SumaDeDigitos(num / 10);
        }
        //CALCULAR EL MAXIMO COMUN DIVISOR DE DOS NUMEROS
        public int MaximoComunDivisor(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return MaximoComunDivisor(b, a % b);
        }
        //DETERMINAR SI UN NUMERO ES POSITIVO
        int b;
        public bool EsPositivo(int n)
        {
            if (n == 0)
            {
                b = 1;
                return false;
            }
            else if (n < 0)
                return false;
            else
                return EsNegativo(n);
        }
        public bool EsNegativo(int n)
        {
            if (n > 0)
                return true;
            else
                return EsPositivo(n);
        }

        ////////////INTERFAZ

        //PANEL 1
        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public int Factorial(int n)\n" +
                "{\n" +
                "     if (n == 0)\n" +
                "          return 1;\n" +
                "     else\n" +
                "          return n * Factorial(n - 1);\n" +
                "}";          
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("El factorial de " + textBox1.Text + " es: " + Factorial(Convert.ToInt32(textBox1.Text)));
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS","ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //PANEL 2
        private void Button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public int Suma(int n)\n" +
                "{\n" +
                "     if (n == 0)\n" +
                "          return 0;\n" +
                "     else\n" +
                "          return n + Suma(n - 1);\n" +
                "}";
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add("La suma secuencial de: " + textBox2.Text + " es: " + Suma(Convert.ToInt32(textBox2.Text)));
                textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
        //PANEL 3
        private void Button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public int Fibbo(int n))\n" +
                "{\n" +
                "     if (n == 0 || n == 1 || n == 2)\n" +
                "          return 1;\n" +
                "     else\n" +
                "          return Fibbo(n - 1) + Fibbo(n - 2);\n" +
                "}";
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Add("La serie Fibonacci para: " + textBox3.Text + " es: " + Fibbo(Convert.ToInt32(textBox3.Text)));
                textBox3.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }
        //PANEL 4
        private void Button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public int Suma2(int a, int b)\n" +
                "{\n" +
                "     if (a == 0)\n" +
                "          return b;\n" +
                "     else if (b == 0)\n" +
                "          return a;\n" +
                "     else\n" +
                "          return 1 + Suma2(a, b - 1);\n" +
                "}";
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            try
            {
                listBox4.Items.Add("La suma: " + textBox4.Text + " + " + textBox4_1.Text + " es: " + Suma2(Convert.ToInt32(textBox4.Text),Convert.ToInt32(textBox4_1.Text)));
                textBox4.Text = "";
                textBox4_1.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }
        //PANEL 5
        private void Button5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Show();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public void TablaDeMultiplicar(int a, int n)\n" +
                "{\n" +
                "     if (n == 0)\n" +
                "          listBox.Items.Add(a + \" x \" + n + \" = \" + (a * n));\n" +
                "     else\n" +
                "     {\n" +
                "          listBox.Items.Add(a + \" x \" + n + \" = \" + (a * n));\n" +
                "          TablaDeMultiplicar(a, n - 1);\n" +
                "     }\n" +
                "}";
        }
        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                listBox5.Items.Add("TABLA DE MULTIPLICAR DEL " + textBox5.Text);
                TablaDeMultiplicar(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox5_1.Text));
                textBox5.Text = "";
                textBox5_1.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
        }
        //PANEL 6
        private void Button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Show();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public string InvertirNumero(int num)\n" +
                "{\n" +
                "     if (num < 10)\n" +
                "          return Convert.ToString(num);\n" +
                "     else\n" +
                "          return Convert.ToString(num % 10) + InvertirNumero(num / 10);\n" +
                "}";
        }
        private void Button22_Click(object sender, EventArgs e)
        {
            try
            {
                listBox6.Items.Add("El número " + textBox6.Text + " ha sido invertido a: " + InvertirNumero(Convert.ToInt32(textBox6.Text)));
                textBox6.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear();
        }
        //PANEL 7
        private void Button7_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Show();
            panel8.Hide();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public int SumaDeDigitos(int num)\n" +
                "{\n" +
                "     if (num < 10)\n" +
                "          return num;\n" +
                "     else\n" +
                "          return (num % 10) + SumaDeDigitos(num / 10);\n" +
                "}";
        }
        private void Button24_Click(object sender, EventArgs e)
        {
            try
            {
                listBox7.Items.Add("La suma de los digitos de " + textBox7.Text + " es: " + SumaDeDigitos(Convert.ToInt32(textBox7.Text)));
                textBox7.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            listBox7.Items.Clear();
        }
        //PANEL 8
        private void Button8_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Show();
            panel9.Hide();
            richTextBox1.Text = "";
            richTextBox1.Text = "public int MaximoComunDivisor(int a, int b)\n" +
                "{\n" +
                "     if (b == 0)\n" +
                "          return a;\n" +
                "     else\n" +
                "          return MaximoComunDivisor(b, a % b);\n" +
                "}";
        }
        private void Button26_Click(object sender, EventArgs e)
        {
            try
            {
                listBox8.Items.Add("El MCD de " + textBox8.Text + " y " + textBox8_1.Text + " es: " + MaximoComunDivisor(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox8_1.Text)));
                textBox8.Text = "";
                textBox8_1.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button25_Click(object sender, EventArgs e)
        {
            listBox8.Items.Clear();
        }
        //PANEL 9
        private void Button9_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Show();
            richTextBox1.Text = "";
            richTextBox1.Text = "public bool EsPositivo(int n)\n" +
                "{\n" +
                "     if (n == 0)\n" +
                "          return false;\n" +
                "     else if (n < 0)\n" +
                "          return false;\n" +
                "     else\n" +
                "          return EsNegativo(n);\n" +
                "}\n" +
                "\n" +
                "\n" +
                "public bool EsNegativo(int n)\n" +
                "{\n" +
                "     if (n > 0)\n" +
                "          return true;\n" +
                "     else\n" +
                "          return EsPositivo(n);\n" +
                "}";
        }
        private void Button28_Click(object sender, EventArgs e)
        {
            try
            {
                EsPositivo(Convert.ToInt32(textBox9.Text));
                if (b == 1)
                {
                    listBox9.Items.Add("El 0 se considera como número neutro");
                    b = 0;
                }
                else
                {
                    listBox9.Items.Add("Es " + textBox9.Text + " un número positivo? " + EsPositivo(Convert.ToInt32(textBox9.Text)));
                    b = 0;
                }
                    textBox9.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR DE SINTAXIS", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Button27_Click(object sender, EventArgs e)
        {
            listBox9.Items.Clear();
        }
        //BOTON SALIR
        private void Button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
