using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class littleForm : Form
    {
        public littleForm()
        {
            InitializeComponent();
            TDni.KeyPress += new KeyPressEventHandler(TDni_KeyPress);
            TApellido.KeyPress += new KeyPressEventHandler(TApellido_KeyPress);
            TNombre.KeyPress += new KeyPressEventHandler(TNombre_KeyPress);
            TTelefono.KeyPress += new KeyPressEventHandler(TTelefono_KeyPress);
        }
        
        // Logica de Boton Guardar
        private void BGuardar_Click(object sender, EventArgs e)
        {         
            if (!Verificar_Espacios()) return;

            DialogResult ask = MessageBox.Show(
                    "Seguro que desea insertar un nuevo Cliente?",
                    "Confirmar Insercion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1 // ponemos el foco en el primer boton (Si)
            );

            if (ask == DialogResult.Yes)
            {
                LModificar.Text = $"{TApellido.Text} {TNombre.Text}";

                MessageBox.Show(
                    $"El Cliente: {TNombre.Text} {TApellido.Text} se inserto correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // Logica del Boton Eliminar
        private void BEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
                $"Esta a punto de eliminar el Cliente: {TNombre.Text} {TApellido.Text}",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2 // hacemos foco en (NO)
            );

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"El cliente: {TNombre.Text} {TApellido.Text} ha sido eliminado correctamente.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // limpiamos los campos
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                LModificar.Text = "Modificar";
            }
        }

        // Validacion de Campos Vacios
        private bool Verificar_Espacios() 
        {
            if  (string.IsNullOrWhiteSpace(TDni.Text) || 
                (string.IsNullOrWhiteSpace(TNombre.Text)) || 
                (string.IsNullOrWhiteSpace(TApellido.Text))) 
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Validacion de entrada de datos (numeros y teclas de control) para el campo DNI.
        private void TDni_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // cancelamos la pulsacion de la tecla.

                // bordes rojos 
                TDni.BackColor = Color.LightPink;
                LDniError.Visible = true;
            }
            else 
            {
                // reset
                TDni.BackColor = SystemColors.Window;
                LDniError.Visible = false;
            }
        }

        // Validacion keypress para el telefono, solo numeros
        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // cancelamos la pulsacion de la tecla.

                // bordes rojos 
                TTelefono.BackColor = Color.LightPink;
                LTelefonoError.Visible = true;
            }
            else
            {
                // reset del campo
                TTelefono.BackColor = SystemColors.Window;
                LTelefonoError.Visible = false;
            }
        }

        // Validacion de entrada de datos (letras y teclas de control) para el campo Nombre.
        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // cancelamos la pulsacion de tecla.

                // bordes rojos
                TNombre.BackColor = Color.LightPink;
                LNombreError.Visible = true;
            }
            else 
            {
                // reset
                TNombre.BackColor = SystemColors.Window;
                LNombreError.Visible = false;
            }
        }

        // Validacion de entrada de datos (letras y teclas de control) para el campo Apellido.
        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // cancelamos la pulsacion de tecla.

                // bordes rojos
                TApellido.BackColor = Color.LightPink;
                LApellidoError.Visible = true;
            }
            else
            {
                // reset
                TApellido.BackColor = SystemColors.Window;
                LApellidoError.Visible = false;
            }
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                PBUsuario.Image = Properties.Resources.hombre;
            }
            else 
            {
                PBUsuario.Image = Properties.Resources.mujer;
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void TDni_TextChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void PBUsuario_Click(object sender, EventArgs e) { }
    }
}
