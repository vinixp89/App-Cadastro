namespace Cadastro
{
    partial class lb_nomeUsuário
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_led_Logado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_acesso = new System.Windows.Forms.Label();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_led_Logado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_nomeUsuario);
            this.panel1.Controls.Add(this.lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_led_Logado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_led_Logado
            // 
            this.lb_led_Logado.Image = global::Cadastro.Properties.Resources.Vermelho;
            this.lb_led_Logado.Location = new System.Drawing.Point(3, 2);
            this.lb_led_Logado.Name = "lb_led_Logado";
            this.lb_led_Logado.Size = new System.Drawing.Size(30, 27);
            this.lb_led_Logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lb_led_Logado.TabIndex = 0;
            this.lb_led_Logado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_acesso
            // 
            this.lb_acesso.AutoSize = true;
            this.lb_acesso.Location = new System.Drawing.Point(96, 10);
            this.lb_acesso.Name = "lb_acesso";
            this.lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.lb_acesso.TabIndex = 2;
            this.lb_acesso.Text = "0";
            this.lb_acesso.Click += new System.EventHandler(this.lb_acesso_Click);
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Location = new System.Drawing.Point(115, 10);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(43, 13);
            this.lb_nomeUsuario.TabIndex = 3;
            this.lb_nomeUsuario.Text = "Usuário";
            this.lb_nomeUsuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "---";
            // 
            // lb_nomeUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "lb_nomeUsuário";
            this.Text = "Sistema Teste -  v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lb_led_Logado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox lb_led_Logado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lb_acesso;
        public System.Windows.Forms.Label lb_nomeUsuario;
    }
}