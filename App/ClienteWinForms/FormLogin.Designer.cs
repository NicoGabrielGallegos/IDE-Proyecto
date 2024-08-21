namespace ClienteWinForms
{
    partial class FormLogin
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
            txtDNI = new TextBox();
            lblDni = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            lnkOlvidaContraseña = new LinkLabel();
            sep1 = new Label();
            lblSep = new Label();
            sep2 = new Label();
            btnCrearCuenta = new Button();
            SuspendLayout();
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.None;
            txtDNI.Location = new Point(12, 39);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(260, 23);
            txtDNI.TabIndex = 0;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 21);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(12, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(260, 23);
            txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(60, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 30);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkOlvidaContraseña
            // 
            lnkOlvidaContraseña.Anchor = AnchorStyles.None;
            lnkOlvidaContraseña.AutoSize = true;
            lnkOlvidaContraseña.Location = new Point(133, 126);
            lnkOlvidaContraseña.Name = "lnkOlvidaContraseña";
            lnkOlvidaContraseña.Size = new Size(141, 15);
            lnkOlvidaContraseña.TabIndex = 2;
            lnkOlvidaContraseña.TabStop = true;
            lnkOlvidaContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // sep1
            // 
            sep1.Anchor = AnchorStyles.None;
            sep1.BorderStyle = BorderStyle.Fixed3D;
            sep1.Location = new Point(12, 211);
            sep1.Name = "sep1";
            sep1.Size = new Size(110, 2);
            sep1.TabIndex = 9;
            // 
            // lblSep
            // 
            lblSep.Anchor = AnchorStyles.None;
            lblSep.AutoSize = true;
            lblSep.Location = new Point(133, 204);
            lblSep.Name = "lblSep";
            lblSep.Size = new Size(16, 15);
            lblSep.TabIndex = 10;
            lblSep.Text = "Ó";
            // 
            // sep2
            // 
            sep2.Anchor = AnchorStyles.None;
            sep2.BorderStyle = BorderStyle.Fixed3D;
            sep2.Location = new Point(162, 211);
            sep2.Name = "sep2";
            sep2.Size = new Size(110, 2);
            sep2.TabIndex = 11;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Anchor = AnchorStyles.None;
            btnCrearCuenta.Location = new Point(60, 233);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(160, 30);
            btnCrearCuenta.TabIndex = 4;
            btnCrearCuenta.Text = "Crear una Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 281);
            Controls.Add(btnCrearCuenta);
            Controls.Add(sep2);
            Controls.Add(lblSep);
            Controls.Add(sep1);
            Controls.Add(lnkOlvidaContraseña);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtDNI);
            Controls.Add(lblDni);
            Name = "FormLogin";
            Text = "Inicio de Sesión";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDNI;
        private Label lblDni;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private LinkLabel lnkOlvidaContraseña;
        private Label sep1;
        private Label lblSep;
        private Label sep2;
        private Button btnCrearCuenta;
    }
}