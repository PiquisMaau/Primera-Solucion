using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaPresentacion
{
    public partial class Form_Ventas : Form
    {
        VentaCabecera venta = new VentaCabecera();

        public Form_Ventas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BuscarClintePorCedoORuc(textBox1.Text);
        }

        private void BuscarClintePorCedoORuc(string cedulaRuc)
        {
            bool resultado = false;
            foreach (var item in DevolverListadoClientes())
            {
               
                if (cedulaRuc == item.Cedula)
                {
                    //Asignar el cliente encontrado al Objeto venta.Cliente
                    venta.Cliente = item;

                    //Cargar los datos de venta.Cliente a los controles
                    CargarDatosEnPantalla(venta.Cliente);

                    //Cambiamos cuando existen resultados
                    resultado = true;

                    //Asociamos el cliente encontrado a los controles
                    
                }
            }
            if (!true)
            {
                MessageBox.Show("No se encontraron resultados", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void CargarDatosEnPantalla(Cliente cliente) {
            textBox1.Text = cliente.Nombre;
            textBox2.Text = cliente.Apellido;
            textBox3.Text = cliente.Cedula;
            textBox4.Text = cliente.Telefono;
            textBox5.Text = cliente.Direccion;
            textBox6.Text = cliente.Correo;
        }

        public List<Cliente> DevolverListadoClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(new Cliente(1, "Sebas", "Pico", "1804764551", "0961390722", "Totoras", "mpico4551@uta.edu.ec"));
            listaClientes.Add(new Cliente(2, "María", "López", "1801234567", "0987654321", "Ambato", "mlopez123@uta.edu.ec"));
            listaClientes.Add(new Cliente(3, "Carlos", "Pérez", "1802345678", "0976543210", "Quisapincha", "cperez234@uta.edu.ec"));
            listaClientes.Add(new Cliente(4, "Ana", "Gómez", "1803456789", "0965432109", "Izamba", "agomez345@uta.edu.ec"));
            listaClientes.Add(new Cliente(5, "Luis", "Ramírez", "1804567890", "0954321098", "Ficoa", "lramirez456@uta.edu.ec"));
            listaClientes.Add(new Cliente(6, "Sofía", "Torres", "1805678901002", "0943210987", "Cevallos", "storres567@uta.edu.ec"));
            listaClientes.Add(new Cliente(7, "Diego", "Castro", "1806789012003", "0932109876", "Pelileo", "dcastro678@uta.edu.ec"));
            return listaClientes;
        }
    }
}
