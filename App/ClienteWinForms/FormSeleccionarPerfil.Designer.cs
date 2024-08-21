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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idPerfilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoPerfilDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            legajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEspecialidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            perfilBindingSource = new BindingSource(components);
            btnIngresar = new Button();
            btnCerrarSesion = new Button();
            lblWelcome = new Label();
            btnCrearPerfil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idPerfilDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, tipoPerfilDataGridViewTextBoxColumn, legajoDataGridViewTextBoxColumn, idEspecialidadDataGridViewTextBoxColumn, activadoDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = perfilBindingSource;
            dataGridView1.Location = new Point(0, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(800, 361);
            dataGridView1.TabIndex = 0;
            // 
            // idPerfilDataGridViewTextBoxColumn
            // 
            idPerfilDataGridViewTextBoxColumn.DataPropertyName = "IdPerfil";
            idPerfilDataGridViewTextBoxColumn.HeaderText = "IdPerfil";
            idPerfilDataGridViewTextBoxColumn.Name = "idPerfilDataGridViewTextBoxColumn";
            idPerfilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPerfilDataGridViewTextBoxColumn
            // 
            tipoPerfilDataGridViewTextBoxColumn.DataPropertyName = "TipoPerfil";
            tipoPerfilDataGridViewTextBoxColumn.HeaderText = "TipoPerfil";
            tipoPerfilDataGridViewTextBoxColumn.Name = "tipoPerfilDataGridViewTextBoxColumn";
            tipoPerfilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // legajoDataGridViewTextBoxColumn
            // 
            legajoDataGridViewTextBoxColumn.DataPropertyName = "Legajo";
            legajoDataGridViewTextBoxColumn.HeaderText = "Legajo";
            legajoDataGridViewTextBoxColumn.Name = "legajoDataGridViewTextBoxColumn";
            legajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEspecialidadDataGridViewTextBoxColumn
            // 
            idEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "IdEspecialidad";
            idEspecialidadDataGridViewTextBoxColumn.HeaderText = "IdEspecialidad";
            idEspecialidadDataGridViewTextBoxColumn.Name = "idEspecialidadDataGridViewTextBoxColumn";
            idEspecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activadoDataGridViewCheckBoxColumn
            // 
            activadoDataGridViewCheckBoxColumn.DataPropertyName = "Activado";
            activadoDataGridViewCheckBoxColumn.HeaderText = "Activado";
            activadoDataGridViewCheckBoxColumn.Name = "activadoDataGridViewCheckBoxColumn";
            activadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // perfilBindingSource
            // 
            perfilBindingSource.DataSource = typeof(Servicios.Modelo.Perfil);
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
            // FormSeleccionarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearPerfil);
            Controls.Add(lblWelcome);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnIngresar);
            Controls.Add(dataGridView1);
            Name = "FormSeleccionarPerfil";
            Text = "FormSeleccionarPerfil";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)perfilBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idPerfilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoPerfilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn legajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEspecialidadDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activadoDataGridViewCheckBoxColumn;
        private BindingSource perfilBindingSource;
        private Button btnIngresar;
        private Button btnCerrarSesion;
        private Label lblWelcome;
        private Button btnCrearPerfil;
    }
}