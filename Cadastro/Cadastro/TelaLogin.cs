using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class TelaLogin : Form
    {
        lb_nomeUsuário form1;
        DataTable dt = new DataTable();
        public TelaLogin(lb_nomeUsuário f)
        {

            InitializeComponent();
            form1 =  f;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_senha_Click(object sender, EventArgs e)
        {

        }

        private void btn_criarUser_Click(object sender, EventArgs e)
        {
            TelaCadastro TelaCadastro = new TelaCadastro();


            // Exibe a janela
            TelaCadastro.ShowDialog();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = this.login.Text;
            string senha = this.senha.Text;

                if( username =="" || senha == "") 
            {
                MessageBox.Show("Usuario e senha invalidos");
                login.Focus();
                return;
            }
        
            string sql = " SELECT * FROM login  WHERE T_USERNAME ='" +username+"' AND T_SENHAUSUARIO='"+senha+"'";

            dt = Banco.consulta(sql);
            if (dt.Rows.Count==1) 
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.lb_led_Logado.Image = Properties.Resources.verde;
                Globaiscs.nivel = int.Parse( dt.Rows[0].Field<int>("T_NOMEUSUARIO").ToString());
                Globaiscs.logado = true;
                this.Close();

            }
            else 
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
