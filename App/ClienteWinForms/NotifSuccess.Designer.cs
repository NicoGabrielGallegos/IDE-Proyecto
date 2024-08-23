namespace ClienteWinForms
{
    partial class NotifSuccess
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
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(203, 82);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(113, 30);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(136, 23);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 11;
            label1.Text = "El usuario se ha registrado con exito!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(148, 43);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 12;
            label2.Text = "Bienvenido {Nombre}, {Apellido}.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // NotifSuccess
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 134);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NotifSuccess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro Exitoso";
            TopMost = true;
            Load += NotifSuccess_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label label1;
        private Label label2;
    }
}