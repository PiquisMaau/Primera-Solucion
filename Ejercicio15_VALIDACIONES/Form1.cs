using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15_VALIDACIONES
{
    partial class Form1 : Form  //":" significa herencia
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void caldodepata(object sender, KeyPressEventArgs e) //este metodo es textBox_KeyPress1
        {
            if (!(char.IsLetter(e.KeyChar)){
                e.Handled = true;
                return
            }

        }
    }
}
