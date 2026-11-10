using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D; //Border radius
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PequenosGuardianes
{
    public partial class FormDatosAlumno : Form
    {
        public FormDatosAlumno()
        {
            InitializeComponent();

            // Aplicamos bordes redondos al iniciar la ventana
            RedondearBoton(btnSiguiente);
            RedondearBoton(btnCancelar);
        }

        // Método reutilizable para dar Border Radius a los botones
        private void RedondearBoton(Button btn)
        {
            GraphicsPath radio = new GraphicsPath();
            int curva = 15; // Ajusta este valor para más o menos redondez
            radio.AddArc(0, 0, curva, curva, 180, 90);
            radio.AddArc(btn.Width - curva, 0, curva, curva, 270, 90);
            radio.AddArc(btn.Width - curva, btn.Height - curva, curva, curva, 0, 90);
            radio.AddArc(0, btn.Height - curva, curva, curva, 90, 90);
            btn.Region = new System.Drawing.Region(radio);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // 1. Validar que no haya campos vacíos importantes
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor ingresa al menos tu nombre y edad.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Guardar los nuevos datos en la memoria global
            RegistroSesion.NombreCompleto = txtNombre.Text.Trim();
            RegistroSesion.Domicilio = txtDomicilio.Text.Trim();
            RegistroSesion.Edad = txtEdad.Text.Trim();
            RegistroSesion.FechaNacimiento = dtpFechaNacimiento.Value.ToShortDateString();
            RegistroSesion.Genero = rbFemenino.Checked ? "Femenino" : "Masculino";

            // 3. Saltar directamente al Menú Principal (Ventana 4)
            FormMenuPrincipal ventanaMenu = new FormMenuPrincipal();
            ventanaMenu.FormClosed += (s, args) => this.Close();
            ventanaMenu.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el programa
        }
    }
}