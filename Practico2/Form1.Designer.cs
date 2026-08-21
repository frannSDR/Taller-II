namespace Practico2
{
    partial class littleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LNyA = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LModificar = new System.Windows.Forms.Label();
            this.LDniError = new System.Windows.Forms.Label();
            this.LNombreError = new System.Windows.Forms.Label();
            this.LApellidoError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckNaranja = new System.Windows.Forms.CheckBox();
            this.CheckVisa = new System.Windows.Forms.CheckBox();
            this.CheckMastercard = new System.Windows.Forms.CheckBox();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.BSalir = new System.Windows.Forms.Button();
            this.PBUsuario = new System.Windows.Forms.PictureBox();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefonoError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LNyA
            // 
            this.LNyA.AutoSize = true;
            this.LNyA.Location = new System.Drawing.Point(63, 58);
            this.LNyA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(122, 16);
            this.LNyA.TabIndex = 0;
            this.LNyA.Text = "Nombre y Apellido:";
            this.LNyA.Click += new System.EventHandler(this.label1_Click);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(4, 126);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(35, 16);
            this.LDni.TabIndex = 1;
            this.LDni.Text = "*DNI";
            this.LDni.Click += new System.EventHandler(this.label2_Click);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(4, 187);
            this.LApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(62, 16);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "*Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(4, 257);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(61, 16);
            this.LNombre.TabIndex = 3;
            this.LNombre.Text = "*Nombre";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(80, 122);
            this.TDni.Margin = new System.Windows.Forms.Padding(4);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(157, 22);
            this.TDni.TabIndex = 6;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(80, 183);
            this.TApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(157, 22);
            this.TApellido.TabIndex = 7;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(80, 254);
            this.TNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(157, 22);
            this.TNombre.TabIndex = 8;
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(221, 58);
            this.LModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(62, 16);
            this.LModificar.TabIndex = 9;
            this.LModificar.Text = "Modificar";
            // 
            // LDniError
            // 
            this.LDniError.AutoSize = true;
            this.LDniError.Location = new System.Drawing.Point(259, 126);
            this.LDniError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDniError.Name = "LDniError";
            this.LDniError.Size = new System.Drawing.Size(93, 16);
            this.LDniError.TabIndex = 10;
            this.LDniError.Text = "Solo numeros!";
            this.LDniError.Visible = false;
            this.LDniError.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LNombreError
            // 
            this.LNombreError.AutoSize = true;
            this.LNombreError.Location = new System.Drawing.Point(259, 257);
            this.LNombreError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreError.Name = "LNombreError";
            this.LNombreError.Size = new System.Drawing.Size(74, 16);
            this.LNombreError.TabIndex = 11;
            this.LNombreError.Text = "Solo letras!";
            this.LNombreError.Visible = false;
            // 
            // LApellidoError
            // 
            this.LApellidoError.AutoSize = true;
            this.LApellidoError.Location = new System.Drawing.Point(259, 187);
            this.LApellidoError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellidoError.Name = "LApellidoError";
            this.LApellidoError.Size = new System.Drawing.Size(74, 16);
            this.LApellidoError.TabIndex = 12;
            this.LApellidoError.Text = "Solo letras!";
            this.LApellidoError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tarjeta de Credito:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // CheckNaranja
            // 
            this.CheckNaranja.AutoSize = true;
            this.CheckNaranja.Location = new System.Drawing.Point(160, 369);
            this.CheckNaranja.Margin = new System.Windows.Forms.Padding(4);
            this.CheckNaranja.Name = "CheckNaranja";
            this.CheckNaranja.Size = new System.Drawing.Size(77, 20);
            this.CheckNaranja.TabIndex = 15;
            this.CheckNaranja.Text = "Naranja";
            this.CheckNaranja.UseVisualStyleBackColor = true;
            // 
            // CheckVisa
            // 
            this.CheckVisa.AutoSize = true;
            this.CheckVisa.Location = new System.Drawing.Point(160, 398);
            this.CheckVisa.Margin = new System.Windows.Forms.Padding(4);
            this.CheckVisa.Name = "CheckVisa";
            this.CheckVisa.Size = new System.Drawing.Size(56, 20);
            this.CheckVisa.TabIndex = 16;
            this.CheckVisa.Text = "Visa";
            this.CheckVisa.UseVisualStyleBackColor = true;
            // 
            // CheckMastercard
            // 
            this.CheckMastercard.AutoSize = true;
            this.CheckMastercard.Location = new System.Drawing.Point(160, 426);
            this.CheckMastercard.Margin = new System.Windows.Forms.Padding(4);
            this.CheckMastercard.Name = "CheckMastercard";
            this.CheckMastercard.Size = new System.Drawing.Size(97, 20);
            this.CheckMastercard.TabIndex = 17;
            this.CheckMastercard.Text = "Mastercard";
            this.CheckMastercard.UseVisualStyleBackColor = true;
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(488, 309);
            this.RBVaron.Margin = new System.Windows.Forms.Padding(4);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(64, 20);
            this.RBVaron.TabIndex = 18;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varon";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(595, 309);
            this.RBMujer.Margin = new System.Windows.Forms.Padding(4);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(61, 20);
            this.RBMujer.TabIndex = 19;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // BSalir
            // 
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BSalir.Image = global::Practico2.Properties.Resources.salir_rs;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.Location = new System.Drawing.Point(539, 587);
            this.BSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(124, 69);
            this.BSalir.TabIndex = 21;
            this.BSalir.Text = "Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // PBUsuario
            // 
            this.PBUsuario.Image = global::Practico2.Properties.Resources.hombre;
            this.PBUsuario.Location = new System.Drawing.Point(488, 108);
            this.PBUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.PBUsuario.Name = "PBUsuario";
            this.PBUsuario.Size = new System.Drawing.Size(175, 154);
            this.PBUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBUsuario.TabIndex = 20;
            this.PBUsuario.TabStop = false;
            this.PBUsuario.Click += new System.EventHandler(this.PBUsuario_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BEliminar.Image = global::Practico2.Properties.Resources.deleteuser_rs;
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.Location = new System.Drawing.Point(297, 587);
            this.BEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(135, 69);
            this.BEliminar.TabIndex = 5;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click_1);
            // 
            // BGuardar
            // 
            this.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BGuardar.Image = global::Practico2.Properties.Resources.guardar_rs;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.Location = new System.Drawing.Point(45, 587);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(136, 69);
            this.BGuardar.TabIndex = 4;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LTelefonoError);
            this.panel1.Controls.Add(this.LNyA);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.CheckMastercard);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.CheckVisa);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.CheckNaranja);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LDniError);
            this.panel1.Controls.Add(this.LApellidoError);
            this.panel1.Controls.Add(this.LNombreError);
            this.panel1.Location = new System.Drawing.Point(16, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 464);
            this.panel1.TabIndex = 22;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(4, 316);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(66, 16);
            this.LTelefono.TabIndex = 18;
            this.LTelefono.Text = "*Telefono";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(80, 313);
            this.TTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(157, 22);
            this.TTelefono.TabIndex = 19;
            // 
            // LTelefonoError
            // 
            this.LTelefonoError.AutoSize = true;
            this.LTelefonoError.Location = new System.Drawing.Point(259, 316);
            this.LTelefonoError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTelefonoError.Name = "LTelefonoError";
            this.LTelefonoError.Size = new System.Drawing.Size(93, 16);
            this.LTelefonoError.TabIndex = 20;
            this.LTelefonoError.Text = "Solo numeros!";
            this.LTelefonoError.Visible = false;
            // 
            // littleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.PBUsuario);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "littleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeno Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.PBUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNyA;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LDniError;
        private System.Windows.Forms.Label LNombreError;
        private System.Windows.Forms.Label LApellidoError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckNaranja;
        private System.Windows.Forms.CheckBox CheckVisa;
        private System.Windows.Forms.CheckBox CheckMastercard;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.PictureBox PBUsuario;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefonoError;
    }
}

