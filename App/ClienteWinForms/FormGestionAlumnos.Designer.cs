namespace ClienteWinForms
{
    partial class FormGestionAlumnos
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
            tabControl = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            button1 = new Button();
            btnIngresar = new Button();
            label2 = new Label();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 393);
            tabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 365);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estado Académico";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 365);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Materias";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(584, 365);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Correlatividades";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(584, 365);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Inscripción a Cursado";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 406);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 3;
            button1.Text = "Cerrar Sesión";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIngresar.Location = new Point(118, 406);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 32);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Cambiar Perfil";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(224, 415);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 6;
            label2.Text = "{Nombre}, {Apellido}! - {Especialidad}";
            // 
            // FormGestionAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(button1);
            Controls.Add(tabControl);
            Name = "FormGestionAlumnos";
            Text = "Gestión de Alumnos";
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private Button btnIngresar;
        private Label label2;
    }
}