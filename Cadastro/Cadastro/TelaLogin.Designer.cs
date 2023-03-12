namespace Cadastro
{
    partial class TelaLogin
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
            this.btn_username = new System.Windows.Forms.Label();
            this.btn_senha = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_criarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_username
            // 
            this.btn_username.AutoSize = true;
            this.btn_username.Location = new System.Drawing.Point(12, 71);
            this.btn_username.Name = "btn_username";
            this.btn_username.Size = new System.Drawing.Size(55, 13);
            this.btn_username.TabIndex = 0;
            this.btn_username.Text = "Username";
            // 
            // btn_senha
            // 
            this.btn_senha.AutoSize = true;
            this.btn_senha.Location = new System.Drawing.Point(12, 123);
            this.btn_senha.Name = "btn_senha";
            this.btn_senha.Size = new System.Drawing.Size(38, 13);
            this.btn_senha.TabIndex = 1;
            this.btn_senha.Text = "Senha";
            this.btn_senha.Click += new System.EventHandler(this.btn_senha_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(86, 71);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(149, 20);
            this.login.TabIndex = 2;
            this.login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(86, 116);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(149, 20);
            this.senha.TabIndex = 3;
            this.senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(65, 216);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(121, 29);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(65, 181);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(121, 29);
            this.btn_logar.TabIndex = 5;
            this.btn_logar.Text = "Logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // btn_criarUser
            // 
            this.btn_criarUser.Location = new System.Drawing.Point(65, 251);
            this.btn_criarUser.Name = "btn_criarUser";
            this.btn_criarUser.Size = new System.Drawing.Size(121, 33);
            this.btn_criarUser.TabIndex = 6;
            this.btn_criarUser.Text = "Criar Usuário";
            this.btn_criarUser.UseVisualStyleBackColor = true;
            this.btn_criarUser.Click += new System.EventHandler(this.btn_criarUser_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 308);
            this.Controls.Add(this.btn_criarUser);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.btn_senha);
            this.Controls.Add(this.btn_username);
            this.Name = "TelaLogin";
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_username;
        private System.Windows.Forms.Label btn_senha;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_criarUser;
    }
}