namespace ClienteWinForms
{
    partial class FormSeleccionarPerfil
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
            dataGridViewPerfiles = new DataGridView();
            btnIngresar = new Button();
            btnCerrarSesion = new Button();
            lblWelcome = new Label();
            btnCrearPerfil = new Button();
            btnRecargarPerfiles = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerfiles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPerfiles
            // 
            dataGridViewPerfiles.AllowUserToAddRows = false;
            dataGridViewPerfiles.AllowUserToDeleteRows = false;
            dataGridViewPerfiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPerfiles.Location = new Point(0, 32);
            dataGridViewPerfiles.Name = "dataGridViewPerfiles";
            dataGridViewPerfiles.ReadOnly = true;
            dataGridViewPerfiles.Size = new Size(800, 361);
            dataGridViewPerfiles.TabIndex = 0;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIngresar.Location = new Point(123, 406);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 32);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.Location = new Point(12, 406);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(100, 32);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(349, 15);
            lblWelcome.TabIndex = 3;
            lblWelcome.Text = "Hola {Nombre}, {Apellido}! Selecciona un perfil o crea uno nuevo";
            // 
            // btnCrearPerfil
            // 
            btnCrearPerfil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCrearPerfil.Location = new Point(209, 406);
            btnCrearPerfil.Name = "btnCrearPerfil";
            btnCrearPerfil.Size = new Size(75, 32);
            btnCrearPerfil.TabIndex = 4;
            btnCrearPerfil.Text = "Crear Perfil";
            btnCrearPerfil.UseVisualStyleBackColor = true;
            btnCrearPerfil.Click += btnCrearPerfil_Click;
            // 
            // btnRecargarPerfiles
            // 
            btnRecargarPerfiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRecargarPerfiles.Location = new Point(295, 406);
            btnRecargarPerfiles.Name = "btnRecargarPerfiles";
            btnRecargarPerfiles.Size = new Size(116, 32);
            btnRecargarPerfiles.TabIndex = 5;
            btnRecargarPerfiles.Text = "Recargar Perfiles";
            btnRecargarPerfiles.UseVisualStyleBackColor = true;
            btnRecargarPerfiles.Click += btnRecargarPerfiles_Click;
            // 
            // FormSeleccionarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecargarPerfiles);
            Controls.Add(btnCrearPerfil);
            Controls.Add(lblWelcome);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnIngresar);
            Controls.Add(dataGridViewPerfiles);
            Name = "FormSeleccionarPerfil";
            Text = "FormSeleccionarPerfil";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerfiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPerfiles;
        private Button btnIngresar;
        private Button btnCerrarSesion;
        private Label lblWelcome;
        private Button btnCrearPerfil;
        private Button btnRecargarPerfiles;
    }
}