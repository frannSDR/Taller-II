namespace FormPrincipal
{
    partial class FormPrincipal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnPractico4 = new System.Windows.Forms.Button();
            this.BtnPractico2 = new System.Windows.Forms.Button();
            this.BtnPractico1 = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.LbTitulo);
            this.panelMenu.Controls.Add(this.BtnSalir);
            this.panelMenu.Controls.Add(this.BtnPractico4);
            this.panelMenu.Controls.Add(this.BtnPractico2);
            this.panelMenu.Controls.Add(this.BtnPractico1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 631);
            this.panelMenu.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(12, 581);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(38, 38);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnPractico4
            // 
            this.BtnPractico4.Location = new System.Drawing.Point(12, 312);
            this.BtnPractico4.Name = "BtnPractico4";
            this.BtnPractico4.Size = new System.Drawing.Size(173, 42);
            this.BtnPractico4.TabIndex = 2;
            this.BtnPractico4.Text = "Practico 4";
            this.BtnPractico4.UseVisualStyleBackColor = true;
            this.BtnPractico4.Click += new System.EventHandler(this.BtnPractico4_Click);
            // 
            // BtnPractico2
            // 
            this.BtnPractico2.Location = new System.Drawing.Point(12, 235);
            this.BtnPractico2.Name = "BtnPractico2";
            this.BtnPractico2.Size = new System.Drawing.Size(173, 42);
            this.BtnPractico2.TabIndex = 1;
            this.BtnPractico2.Text = "Practico 2";
            this.BtnPractico2.UseVisualStyleBackColor = true;
            this.BtnPractico2.Click += new System.EventHandler(this.BtnPractico2_Click);
            // 
            // BtnPractico1
            // 
            this.BtnPractico1.Location = new System.Drawing.Point(12, 158);
            this.BtnPractico1.Name = "BtnPractico1";
            this.BtnPractico1.Size = new System.Drawing.Size(173, 42);
            this.BtnPractico1.TabIndex = 0;
            this.BtnPractico1.Text = "Practico 1";
            this.BtnPractico1.UseVisualStyleBackColor = true;
            this.BtnPractico1.Click += new System.EventHandler(this.BtnPractico1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(553, 631);
            this.panelContenedor.TabIndex = 1;
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.LbTitulo.Location = new System.Drawing.Point(12, 34);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(155, 25);
            this.LbTitulo.TabIndex = 4;
            this.LbTitulo.Text = "Menu Principal";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 631);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnPractico4;
        private System.Windows.Forms.Button BtnPractico2;
        private System.Windows.Forms.Button BtnPractico1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LbTitulo;
    }
}

