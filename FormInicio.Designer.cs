namespace Clave1___Grupo1
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnAgregarAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clave1___Grupo1.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "¿Es nuevo cliente? Cree una cuenta aquí:";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(350, 61);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(187, 20);
            this.TxtNombreUsuario.TabIndex = 5;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(350, 118);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(187, 20);
            this.TxtContrasenia.TabIndex = 6;
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.Location = new System.Drawing.Point(440, 204);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrarse.TabIndex = 7;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.UseVisualStyleBackColor = true;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(399, 158);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 8;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnAgregarAdmin
            // 
            this.BtnAgregarAdmin.Location = new System.Drawing.Point(45, 228);
            this.BtnAgregarAdmin.Name = "BtnAgregarAdmin";
            this.BtnAgregarAdmin.Size = new System.Drawing.Size(131, 23);
            this.BtnAgregarAdmin.TabIndex = 9;
            this.BtnAgregarAdmin.Text = "Agregar Administrador";
            this.BtnAgregarAdmin.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 265);
            this.Controls.Add(this.BtnAgregarAdmin);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormInicio";
            this.Text = "Veterinaria Cat - Dog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnAgregarAdmin;
    }
}

