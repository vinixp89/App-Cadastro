using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;

namespace Cadastro
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\User\\Desktop\\projeto2\\teste2.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();


            try

            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM login";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                };
            }
            catch (Exception ex)

            {
                ConexaoBanco().Close();
                throw ex;
            }

        }
        public static DataTable consulta(string sql) 
        
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try

            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                };
            }
            catch (Exception ex)

            {
                ConexaoBanco().Close();
                throw ex;
            }

        }
    }

}

