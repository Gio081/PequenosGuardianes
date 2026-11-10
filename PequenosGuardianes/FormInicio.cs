using PequenosGuardianes;
using System;
using System.Windows.Forms;

namespace PequenosGuardianes
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Instanciamos la ventana 2
            FormDatosAlumno ventanaDatos = new FormDatosAlumno();

            // Si la ventana 2 se cierra por completo, cerramos la aplicación
            ventanaDatos.FormClosed += (s, args) => this.Close();

            // Mostramos la ventana 2 y ocultamos la 1
            ventanaDatos.Show();
            this.Hide();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}