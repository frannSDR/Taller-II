using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Formulario1_KeyDown;
            BtnExit.Visible = false; // Ocultamos el botón al inicio
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnExit.Visible = !BtnExit.Visible; // Mostramos/ocultamos el botón al presionar Ctrl + S
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string fullName = TextBoxName.Text + " " + TextBoxApe.Text;

            TextBoxView.Text = fullName;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            TextBoxName.Clear();
            TextBoxApe.Clear();
            TextBoxView.Clear();
        }

        private void LbName_Click(object sender, EventArgs e)
        {

        }

        private void LbLastName_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxApe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
