namespace Basic_ERP_Windows
{
    partial class uLogin
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
            BtnEntrar = new Button();
            usuario = new TextBox();
            senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnEntrar
            // 
            BtnEntrar.BackColor = SystemColors.ControlDark;
            BtnEntrar.Location = new Point(97, 191);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(102, 53);
            BtnEntrar.TabIndex = 0;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // usuario
            // 
            usuario.Location = new Point(38, 59);
            usuario.Name = "usuario";
            usuario.Size = new Size(235, 23);
            usuario.TabIndex = 1;
            // 
            // senha
            // 
            senha.Location = new Point(40, 130);
            senha.Name = "senha";
            senha.Size = new Size(235, 23);
            senha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(43, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(43, 112);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // uLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 272);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(senha);
            Controls.Add(usuario);
            Controls.Add(BtnEntrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uLogin";
            Text = "Entrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEntrar;
        private TextBox usuario;
        private TextBox senha;
        private Label label1;
        private Label label2;
    }
}