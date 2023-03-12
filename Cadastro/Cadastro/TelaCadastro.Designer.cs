namespace Cadastro
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ConfirCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(49, 90);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(45, 149);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 1;
            this.CPF.Text = "CPF";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(48, 204);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(29, 13);
            this.login.TabIndex = 2;
            this.login.Text = "login";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Location = new System.Drawing.Point(48, 253);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(36, 13);
            this.senha.TabIndex = 3;
            this.senha.Text = "senha";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(136, 141);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(352, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(136, 204);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(352, 20);
            this.maskedTextBox2.TabIndex = 6;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(107, 355);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(131, 40);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ConfirCadastro
            // 
            this.btn_ConfirCadastro.Location = new System.Drawing.Point(352, 355);
            this.btn_ConfirCadastro.Name = "btn_ConfirCadastro";
            this.btn_ConfirCadastro.Size = new System.Drawing.Size(136, 39);
            this.btn_ConfirCadastro.TabIndex = 9;
            this.btn_ConfirCadastro.Text = "Confirmar";
            this.btn_ConfirCadastro.UseVisualStyleBackColor = true;
            this.btn_ConfirCadastro.Click += new System.EventHandler(this.btn_ConfirCadastro_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 463);
            this.Controls.Add(this.btn_ConfirCadastro);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Name = "TelaCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ConfirCadastro;
    }
}

