namespace Practico4
{
    partial class Formulario4
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
            this.DatosPanel = new System.Windows.Forms.Panel();
            this.TFoto = new System.Windows.Forms.TextBox();
            this.BFoto = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.DateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TSaldo = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.RMujer = new System.Windows.Forms.RadioButton();
            this.RHombre = new System.Windows.Forms.RadioButton();
            this.LSaldo = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.PAvatar = new System.Windows.Forms.PictureBox();
            this.DataClientes = new System.Windows.Forms.DataGridView();
            this.DatosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosPanel
            // 
            this.DatosPanel.BackColor = System.Drawing.Color.Transparent;
            this.DatosPanel.Controls.Add(this.TFoto);
            this.DatosPanel.Controls.Add(this.BFoto);
            this.DatosPanel.Controls.Add(this.BGuardar);
            this.DatosPanel.Controls.Add(this.DateFechaNac);
            this.DatosPanel.Controls.Add(this.TSaldo);
            this.DatosPanel.Controls.Add(this.TApellido);
            this.DatosPanel.Controls.Add(this.TNombre);
            this.DatosPanel.Controls.Add(this.RMujer);
            this.DatosPanel.Controls.Add(this.RHombre);
            this.DatosPanel.Controls.Add(this.LSaldo);
            this.DatosPanel.Controls.Add(this.LSexo);
            this.DatosPanel.Controls.Add(this.LFecha);
            this.DatosPanel.Controls.Add(this.LApellido);
            this.DatosPanel.Controls.Add(this.LNombre);
            this.DatosPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.DatosPanel.ForeColor = System.Drawing.Color.White;
            this.DatosPanel.Location = new System.Drawing.Point(43, 12);
            this.DatosPanel.Name = "DatosPanel";
            this.DatosPanel.Size = new System.Drawing.Size(520, 353);
            this.DatosPanel.TabIndex = 0;
            // 
            // TFoto
            // 
            this.TFoto.Location = new System.Drawing.Point(134, 262);
            this.TFoto.Name = "TFoto";
            this.TFoto.Size = new System.Drawing.Size(195, 32);
            this.TFoto.TabIndex = 13;
            // 
            // BFoto
            // 
            this.BFoto.ForeColor = System.Drawing.Color.Black;
            this.BFoto.Location = new System.Drawing.Point(21, 262);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(91, 30);
            this.BFoto.TabIndex = 12;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            this.BFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.ForeColor = System.Drawing.Color.Black;
            this.BGuardar.Location = new System.Drawing.Point(393, 306);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(102, 34);
            this.BGuardar.TabIndex = 11;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // DateFechaNac
            // 
            this.DateFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DateFechaNac.Location = new System.Drawing.Point(216, 133);
            this.DateFechaNac.Name = "DateFechaNac";
            this.DateFechaNac.Size = new System.Drawing.Size(279, 26);
            this.DateFechaNac.TabIndex = 10;
            // 
            // TSaldo
            // 
            this.TSaldo.Location = new System.Drawing.Point(134, 208);
            this.TSaldo.Name = "TSaldo";
            this.TSaldo.Size = new System.Drawing.Size(195, 32);
            this.TSaldo.TabIndex = 9;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(134, 90);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(195, 32);
            this.TApellido.TabIndex = 8;
            this.TApellido.Leave += new System.EventHandler(this.TApellido_Leave);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(134, 41);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(195, 32);
            this.TNombre.TabIndex = 7;
            this.TNombre.Leave += new System.EventHandler(this.TNombre_Leave);
            // 
            // RMujer
            // 
            this.RMujer.AutoSize = true;
            this.RMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RMujer.ForeColor = System.Drawing.Color.Black;
            this.RMujer.Location = new System.Drawing.Point(245, 172);
            this.RMujer.Name = "RMujer";
            this.RMujer.Size = new System.Drawing.Size(66, 24);
            this.RMujer.TabIndex = 6;
            this.RMujer.Text = "Mujer";
            this.RMujer.UseVisualStyleBackColor = true;
            // 
            // RHombre
            // 
            this.RHombre.AutoSize = true;
            this.RHombre.Checked = true;
            this.RHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RHombre.ForeColor = System.Drawing.Color.Black;
            this.RHombre.Location = new System.Drawing.Point(134, 172);
            this.RHombre.Name = "RHombre";
            this.RHombre.Size = new System.Drawing.Size(84, 24);
            this.RHombre.TabIndex = 5;
            this.RHombre.TabStop = true;
            this.RHombre.Text = "Hombre";
            this.RHombre.UseVisualStyleBackColor = true;
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.ForeColor = System.Drawing.Color.Black;
            this.LSaldo.Location = new System.Drawing.Point(16, 214);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(74, 26);
            this.LSaldo.TabIndex = 4;
            this.LSaldo.Text = "Saldo:";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.ForeColor = System.Drawing.Color.Black;
            this.LSexo.Location = new System.Drawing.Point(16, 174);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(68, 26);
            this.LSexo.TabIndex = 3;
            this.LSexo.Text = "Sexo:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.ForeColor = System.Drawing.Color.Black;
            this.LFecha.Location = new System.Drawing.Point(16, 133);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(194, 26);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha Nacimiento:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(16, 90);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(96, 26);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.ForeColor = System.Drawing.Color.Black;
            this.LNombre.Location = new System.Drawing.Point(16, 44);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(96, 26);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // PAvatar
            // 
            this.PAvatar.BackColor = System.Drawing.Color.Transparent;
            this.PAvatar.Image = global::Practico4.Properties.Resources.perfil_defecto;
            this.PAvatar.Location = new System.Drawing.Point(657, 12);
            this.PAvatar.Name = "PAvatar";
            this.PAvatar.Size = new System.Drawing.Size(355, 353);
            this.PAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PAvatar.TabIndex = 1;
            this.PAvatar.TabStop = false;
            // 
            // DataClientes
            // 
            this.DataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataClientes.Location = new System.Drawing.Point(97, 391);
            this.DataClientes.Name = "DataClientes";
            this.DataClientes.RowTemplate.Height = 60;
            this.DataClientes.Size = new System.Drawing.Size(874, 194);
            this.DataClientes.TabIndex = 2;
            this.DataClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClientes_CellClick);
            this.DataClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClientes_CellContentClick);
            // 
            // Formulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practico4.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1064, 597);
            this.Controls.Add(this.DataClientes);
            this.Controls.Add(this.PAvatar);
            this.Controls.Add(this.DatosPanel);
            this.DoubleBuffered = true;
            this.Name = "Formulario4";
            this.Text = "Formulario con Grid";
            this.Load += new System.EventHandler(this.Formulario4_Load);
            this.DatosPanel.ResumeLayout(false);
            this.DatosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DatosPanel;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.RadioButton RMujer;
        private System.Windows.Forms.RadioButton RHombre;
        private System.Windows.Forms.DateTimePicker DateFechaNac;
        private System.Windows.Forms.TextBox TSaldo;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BFoto;
        private System.Windows.Forms.TextBox TFoto;
        private System.Windows.Forms.PictureBox PAvatar;
        private System.Windows.Forms.DataGridView DataClientes;
    }
}

