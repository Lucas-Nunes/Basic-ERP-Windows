﻿namespace Config
{
    partial class uPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Usuario = new TextBox();
            instancia = new ComboBox();
            Senha = new TextBox();
            BancoDeDados = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BntSalvar = new Button();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.Location = new Point(20, 126);
            Usuario.Margin = new Padding(3, 2, 3, 2);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(212, 23);
            Usuario.TabIndex = 0;
            // 
            // instancia
            // 
            instancia.DropDownStyle = ComboBoxStyle.DropDownList;
            instancia.FormattingEnabled = true;
            instancia.Location = new Point(20, 28);
            instancia.Margin = new Padding(3, 2, 3, 2);
            instancia.Name = "instancia";
            instancia.Size = new Size(212, 23);
            instancia.TabIndex = 1;
            // 
            // Senha
            // 
            Senha.Location = new Point(20, 172);
            Senha.Margin = new Padding(3, 2, 3, 2);
            Senha.Name = "Senha";
            Senha.Size = new Size(212, 23);
            Senha.TabIndex = 2;
            // 
            // BancoDeDados
            // 
            BancoDeDados.Location = new Point(20, 78);
            BancoDeDados.Margin = new Padding(3, 2, 3, 2);
            BancoDeDados.Name = "BancoDeDados";
            BancoDeDados.Size = new Size(212, 23);
            BancoDeDados.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 10);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Instância";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 5;
            label2.Text = "Banco de Dados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 155);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // BntSalvar
            // 
            BntSalvar.Location = new Point(69, 218);
            BntSalvar.Margin = new Padding(3, 2, 3, 2);
            BntSalvar.Name = "BntSalvar";
            BntSalvar.Size = new Size(94, 38);
            BntSalvar.TabIndex = 8;
            BntSalvar.Text = "Salvar";
            BntSalvar.UseVisualStyleBackColor = true;
            BntSalvar.Click += BntSalvar_Click;
            // 
            // uPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 272);
            Controls.Add(BntSalvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BancoDeDados);
            Controls.Add(Senha);
            Controls.Add(instancia);
            Controls.Add(Usuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uPrincipal";
            Text = "Configurações";
            Load += uPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usuario;
        private ComboBox instancia;
        private TextBox Senha;
        private TextBox BancoDeDados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BntSalvar;
    }
}
