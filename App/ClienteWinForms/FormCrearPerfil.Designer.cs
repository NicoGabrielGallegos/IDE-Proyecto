namespace ClienteWinForms
{
    partial class FormCrearPerfil
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
            components = new System.ComponentModel.Container();
            lblTipoPerfil = new Label();
            radioBtnAlumno = new RadioButton();
            radioBtnDocente = new RadioButton();
            radioGroup = new Panel();
            comboBoxEspecialidad = new ComboBox();
            especialidadBindingSource = new BindingSource(components);
            lblEspecialidad = new Label();
            btnCrearPerfil = new Button();
            btnCancelar = new Button();
            lblDNI = new Label();
            txtDNI = new TextBox();
            radioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTipoPerfil
            // 
            lblTipoPerfil.Anchor = AnchorStyles.None;
            lblTipoPerfil.AutoSize = true;
            lblTipoPerfil.Location = new Point(13, 50);
            lblTipoPerfil.Name = "lblTipoPerfil";
            lblTipoPerfil.Size = new Size(79, 15);
            lblTipoPerfil.TabIndex = 4;
            lblTipoPerfil.Text = "Tipo de Perfil:";
            // 
            // radioBtnAlumno
            // 
            radioBtnAlumno.AutoSize = true;
            radioBtnAlumno.Checked = true;
            radioBtnAlumno.Location = new Point(3, 3);
            radioBtnAlumno.Name = "radioBtnAlumno";
            radioBtnAlumno.Size = new Size(68, 19);
            radioBtnAlumno.TabIndex = 5;
            radioBtnAlumno.TabStop = true;
            radioBtnAlumno.Text = "Alumno";
            radioBtnAlumno.UseVisualStyleBackColor = true;
            radioBtnAlumno.CheckedChanged += radioBtnAlumno_CheckedChanged;
            // 
            // radioBtnDocente
            // 
            radioBtnDocente.AutoSize = true;
            radioBtnDocente.Location = new Point(77, 3);
            radioBtnDocente.Name = "radioBtnDocente";
            radioBtnDocente.Size = new Size(69, 19);
            radioBtnDocente.TabIndex = 6;
            radioBtnDocente.Text = "Docente";
            radioBtnDocente.UseVisualStyleBackColor = true;
            radioBtnDocente.CheckedChanged += radioBtnDocente_CheckedChanged;
            // 
            // radioGroup
            // 
            radioGroup.Anchor = AnchorStyles.None;
            radioGroup.Controls.Add(radioBtnAlumno);
            radioGroup.Controls.Add(radioBtnDocente);
            radioGroup.Location = new Point(95, 45);
            radioGroup.Name = "radioGroup";
            radioGroup.Size = new Size(147, 25);
            radioGroup.TabIndex = 7;
            // 
            // comboBoxEspecialidad
            // 
            comboBoxEspecialidad.Anchor = AnchorStyles.None;
            comboBoxEspecialidad.DataSource = especialidadBindingSource;
            comboBoxEspecialidad.DisplayMember = "DescEspecialidad";
            comboBoxEspecialidad.FormattingEnabled = true;
            comboBoxEspecialidad.Location = new Point(95, 83);
            comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            comboBoxEspecialidad.Size = new Size(146, 23);
            comboBoxEspecialidad.TabIndex = 8;
            comboBoxEspecialidad.ValueMember = "IdEspecialidad";
            // 
            // especialidadBindingSource
            // 
            especialidadBindingSource.DataSource = typeof(Servicios.Modelo.Especialidad);
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.Anchor = AnchorStyles.None;
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(17, 86);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(75, 15);
            lblEspecialidad.TabIndex = 9;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // btnCrearPerfil
            // 
            btnCrearPerfil.Anchor = AnchorStyles.None;
            btnCrearPerfil.Location = new Point(95, 117);
            btnCrearPerfil.Name = "btnCrearPerfil";
            btnCrearPerfil.Size = new Size(75, 32);
            btnCrearPerfil.TabIndex = 10;
            btnCrearPerfil.Text = "Crear Perfil";
            btnCrearPerfil.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(176, 117);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(65, 32);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDNI
            // 
            lblDNI.Anchor = AnchorStyles.None;
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(59, 14);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 12;
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.None;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Location = new Point(95, 11);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new Size(146, 23);
            txtDNI.TabIndex = 13;
            // 
            // FormCrearPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 160);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrearPerfil);
            Controls.Add(lblEspecialidad);
            Controls.Add(comboBoxEspecialidad);
            Controls.Add(radioGroup);
            Controls.Add(lblTipoPerfil);
            Name = "FormCrearPerfil";
            Text = "FormCrearPerfil";
            radioGroup.ResumeLayout(false);
            radioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoPerfil;
        private RadioButton radioBtnAlumno;
        private RadioButton radioBtnDocente;
        private Panel radioGroup;
        private ComboBox comboBoxEspecialidad;
        private BindingSource especialidadBindingSource;
        private Label lblEspecialidad;
        private Button btnCrearPerfil;
        private Button btnCancelar;
        private Label lblDNI;
        private TextBox txtDNI;
    }
}