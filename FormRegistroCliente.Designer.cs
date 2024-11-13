namespace Clave1___Grupo1
{
    partial class FormRegistroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevoUsuario = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNuevoClienteContrasenia = new System.Windows.Forms.TextBox();
            this.TxtNuevoClienteUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtClienteDireccion = new System.Windows.Forms.TextBox();
            this.TxtClienteNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtClienteTelefono = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Registro nuevo cliente";
            // 
            // BtnNuevoUsuario
            // 
            this.BtnNuevoUsuario.Location = new System.Drawing.Point(510, 189);
            this.BtnNuevoUsuario.Name = "BtnNuevoUsuario";
            this.BtnNuevoUsuario.Size = new System.Drawing.Size(122, 23);
            this.BtnNuevoUsuario.TabIndex = 14;
            this.BtnNuevoUsuario.Text = "Crear nuevo usuario";
            this.BtnNuevoUsuario.UseVisualStyleBackColor = true;
            this.BtnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(47, 206);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(122, 23);
            this.BtnRegresar.TabIndex = 15;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNuevoClienteContrasenia);
            this.groupBox1.Controls.Add(this.TxtNuevoClienteUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(381, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cuenta";
            // 
            // TxtNuevoClienteContrasenia
            // 
            this.TxtNuevoClienteContrasenia.Location = new System.Drawing.Point(175, 66);
            this.TxtNuevoClienteContrasenia.Name = "TxtNuevoClienteContrasenia";
            this.TxtNuevoClienteContrasenia.Size = new System.Drawing.Size(187, 20);
            this.TxtNuevoClienteContrasenia.TabIndex = 17;
            // 
            // TxtNuevoClienteUsuario
            // 
            this.TxtNuevoClienteUsuario.Location = new System.Drawing.Point(175, 29);
            this.TxtNuevoClienteUsuario.Name = "TxtNuevoClienteUsuario";
            this.TxtNuevoClienteUsuario.Size = new System.Drawing.Size(187, 20);
            this.TxtNuevoClienteUsuario.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingrese una contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese un nombre de usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtClienteTelefono);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtClienteDireccion);
            this.groupBox2.Controls.Add(this.TxtClienteNombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(47, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 148);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Personales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Teléfono:";
            // 
            // TxtClienteDireccion
            // 
            this.TxtClienteDireccion.Location = new System.Drawing.Point(109, 66);
            this.TxtClienteDireccion.Name = "TxtClienteDireccion";
            this.TxtClienteDireccion.Size = new System.Drawing.Size(187, 20);
            this.TxtClienteDireccion.TabIndex = 17;
            // 
            // TxtClienteNombre
            // 
            this.TxtClienteNombre.Location = new System.Drawing.Point(109, 32);
            this.TxtClienteNombre.Name = "TxtClienteNombre";
            this.TxtClienteNombre.Size = new System.Drawing.Size(187, 20);
            this.TxtClienteNombre.TabIndex = 16;
            this.TxtClienteNombre.TextChanged += new System.EventHandler(this.TxtClienteNombre_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre:";
            // 
            // TxtClienteTelefono
            // 
            this.TxtClienteTelefono.Location = new System.Drawing.Point(109, 100);
            this.TxtClienteTelefono.Name = "TxtClienteTelefono";
            this.TxtClienteTelefono.Size = new System.Drawing.Size(187, 20);
            this.TxtClienteTelefono.TabIndex = 19;
            this.TxtClienteTelefono.TextChanged += new System.EventHandler(this.TxtClienteTelefono_TextChanged);
            // 
            // FormRegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnNuevoUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistroCliente";
            this.Text = "Registro Nuevo Cliente // Veterinaria Cat-Dog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNuevoUsuario;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNuevoClienteContrasenia;
        private System.Windows.Forms.TextBox TxtNuevoClienteUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtClienteTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtClienteDireccion;
        private System.Windows.Forms.TextBox TxtClienteNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}