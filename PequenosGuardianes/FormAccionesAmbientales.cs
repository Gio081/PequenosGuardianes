using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PequenosGuardianes
{
    public partial class FormAccionesAmbientales : Form
    {
        public FormAccionesAmbientales()
        {
            InitializeComponent();
        }

        // --- Botones de las Tarjetas (Guarda de Seguridad para el MVP) ---

        private void btnOpcionesBasura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El módulo 'Opciones de Basura' (Ventana 6) está en construcción.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpcionesReciclar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El módulo 'Opciones de Reciclaje' (Ventana 7) está en construcción.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpcionesAgua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El módulo 'Opciones de Agua' (Ventana 8) está en construcción.", "Próximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Navegación de Regreso ---

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            // Cierra la Ventana 5 de forma limpia. 
            // Esto detonará el evento FormClosed que programamos en la Ventana 4, haciéndola reaparecer.
            this.Close();
        }
    }
}
