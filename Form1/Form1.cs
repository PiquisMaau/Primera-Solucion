using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_calcular_Click(object sender, EventArgs e)
        {
            EspecificarLongitudDeLabels(nombre1, textBox_Nombre1);
            EspecificarLongitudDeLabels(nombre2, textBox_Nombre2);
            EspecificarLongitudDeLabels(apellido1, textBox_Apellido1);
            EspecificarLongitudDeLabels(apellido2, textBox_Apellido2);
        }

        void EspecificarLongitudDeLabels(Label etiquet, TextBox resultado)
        {
            resultado.Text = etiquet.Text.Length.ToString();
        }
    }
}
