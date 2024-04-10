using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        private DatosTrabajador datosTrabajador;
        public Form1()
        {
            InitializeComponent();
            datosTrabajador = new DatosTrabajador();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            decimal sueldoBruto = Convert.ToDecimal(txtSueldoBruto.Text);
            string categoria = cmbCategoria.SelectedItem.ToString();

            datosTrabajador.InsertarTrabajador(nombre, apellidos, sueldoBruto, categoria);

            // Actualizar la lista de trabajadores en la interfaz
            ActualizarListaTrabajadores();
        }
        private void ActualizarListaTrabajadores()
        {
           
        }
    }
}
