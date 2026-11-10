using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PequenosGuardianes
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAccionesBasura_Click(object sender, EventArgs e)
        {
            // Abrimos la Ventana 5 (Acciones Ambientales)
            FormAccionesAmbientales ventanaAcciones = new FormAccionesAmbientales();
            ventanaAcciones.FormClosed += (s, args) => this.Show(); // Al cerrar la 5, volvemos a mostrar este menú
            ventanaAcciones.Show();
            this.Hide();
        }

        private void btnAccionesReciclaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Reciclaje en construcción.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAccionesAgua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Cuidado del Agua en construcción.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El reporte final estará disponible pronto.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Esto cierra el formulario actual, terminando la aplicación de forma limpia
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Regresamos a la ventana de Datos Personales
            FormDatosAlumno ventanaDatos = new FormDatosAlumno();
            ventanaDatos.FormClosed += (s, args) => this.Close();
            ventanaDatos.Show();
            this.Hide();
        }
    }
}
