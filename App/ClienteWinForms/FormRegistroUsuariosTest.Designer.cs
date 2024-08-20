namespace ClienteWinForms
{
    partial class FormRegistroUsuariosTest
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
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtEmail = new TextBox();
            txtPasswordR = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            btnRegistrarse = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 221);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 113);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 167);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 221);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 0;
            label7.Text = "Repetir Contraseña";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(201, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(12, 77);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(160, 23);
            txtNombreUsuario.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPasswordR
            // 
            txtPasswordR.Location = new Point(201, 239);
            txtPasswordR.Name = "txtPasswordR";
            txtPasswordR.Size = new Size(160, 23);
            txtPasswordR.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 239);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 24);
            label5.Name = "label5";
            label5.Size = new Size(251, 15);
            label5.TabIndex = 0;
            label5.Text = "Sistema de Academia - Formulario de Registro";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(12, 278);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(160, 45);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(201, 278);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 342);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarse);
            Controls.Add(label5);
            Controls.Add(txtPasswordR);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Name = "FormRegistroUsuarios";
            Text = "Registro de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label6;
        private Label label7;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtEmail;
        private TextBox txtPasswordR;
        private TextBox txtPassword;
        private Label label5;
        private Button btnRegistrarse;
        private Button btnCancelar;
    }
}