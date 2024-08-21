namespace ClienteWinForms
{
    partial class FormSignIn
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
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnRegistrarse = new Button();
            txtPass1 = new TextBox();
            txtPass0 = new TextBox();
            label2 = new Label();
            label8 = new Label();
            dateFechaNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Location = new Point(12, 199);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(160, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(12, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(349, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Location = new Point(201, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 23);
            txtApellido.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(201, 181);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 9;
            label7.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(12, 127);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(201, 73);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Apellido";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 12;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(12, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.None;
            txtDNI.Location = new Point(12, 37);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(160, 23);
            txtDNI.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 24;
            label5.Text = "DNI";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(201, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.None;
            btnRegistrarse.Location = new Point(12, 299);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(160, 30);
            btnRegistrarse.TabIndex = 8;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // txtPass1
            // 
            txtPass1.Anchor = AnchorStyles.None;
            txtPass1.Location = new Point(201, 253);
            txtPass1.Name = "txtPass1";
            txtPass1.PasswordChar = '*';
            txtPass1.Size = new Size(160, 23);
            txtPass1.TabIndex = 7;
            // 
            // txtPass0
            // 
            txtPass0.Anchor = AnchorStyles.None;
            txtPass0.Location = new Point(12, 253);
            txtPass0.Name = "txtPass0";
            txtPass0.PasswordChar = '*';
            txtPass0.Size = new Size(160, 23);
            txtPass0.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(201, 235);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 27;
            label2.Text = "Repetir Contraseña";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(12, 235);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 28;
            label8.Text = "Contraseña";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Anchor = AnchorStyles.None;
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(201, 199);
            dateFechaNacimiento.MaxDate = new DateTime(2024, 8, 20, 0, 0, 0, 0);
            dateFechaNacimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(160, 23);
            dateFechaNacimiento.TabIndex = 5;
            dateFechaNacimiento.Value = new DateTime(2024, 8, 20, 0, 0, 0, 0);
            // 
            // FormSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 359);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtPass1);
            Controls.Add(txtPass0);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(txtDNI);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Name = "FormSignIn";
            Text = "Crear una Cuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDNI;
        private Label label5;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private Label label7;
        private Label label6;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnRegistrarse;
        private TextBox txtPass1;
        private TextBox txtPass0;
        private Label label2;
        private Label label8;
        private DateTimePicker dateFechaNacimiento;
    }
}