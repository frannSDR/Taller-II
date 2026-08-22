using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico1;
using Practico2;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.Clear();
            }

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void BtnPractico1_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Formulario1());
        }

        private void BtnPractico2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new littleForm());
        }

        private void BtnPractico4_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
