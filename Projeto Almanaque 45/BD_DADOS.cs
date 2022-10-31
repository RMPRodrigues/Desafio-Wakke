using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Projeto_Almanaque_45
{
    class BD_DADOS
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBD_DADOS()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\R2\\Desktop\\KGB\\SQlite\\BD_SQLite.db");

            conexao.Open();
            return conexao;
        }
        public static DataTable ObterTodosMembros()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBD_DADOS();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM BD_Membros";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBD_DADOS());
                da.Fill(dt);
                ConexaoBD_DADOS().Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public static DataTable Consulta(string sql)
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBD_DADOS().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBD_DADOS());
                    da.Fill(dt);
                    ConexaoBD_DADOS().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void cadastro(Membros m)
        {
            if (existeusuario(m))
            {
                MessageBox.Show("Usuario já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBD_DADOS().CreateCommand();
                cmd.CommandText = "INSERT INTO BD_Membros (T_NOME, T_SOBRENOME, DT_NASCIMENTO, N_ALTURA, N_PESO, T_GENERO, T_USUARIO, N_SENHA, T_SITUAÇÃO) VALUES (@nome, @sobrenome, @nascimento, @altura, @peso, @genero, @usuario, @senha, @situaçao)";
                cmd.Parameters.AddWithValue("@nome", m.nome);
                cmd.Parameters.AddWithValue("@sobrenome", m.sobrenome);
                cmd.Parameters.AddWithValue("@nascimento", m.nascimento);
                cmd.Parameters.AddWithValue("@altura", m.altura);
                cmd.Parameters.AddWithValue("@genero", m.genero);
                cmd.Parameters.AddWithValue("@peso", m.peso);
                cmd.Parameters.AddWithValue("@senha", m.senha);
                cmd.Parameters.AddWithValue("@usuario", m.usuario);
                cmd.Parameters.AddWithValue("@situaçao", m.situação);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado");
                ConexaoBD_DADOS().Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastra");
                ConexaoBD_DADOS().Close();
                throw ex;
            }


        }
        public static bool existeusuario(Membros m)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBD_DADOS().CreateCommand();
            cmd.CommandText = "SELECT T_USUARIO FROM BD_Membros WHERE T_USUARIO='" + m.usuario + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBD_DADOS());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        public static DataTable exibição()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBD_DADOS();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM BD_Membros";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBD_DADOS());
                da.Fill(dt);
                ConexaoBD_DADOS().Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public static DataTable tabela(string ID)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBD_DADOS();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM BD_Membros WHERE N_ID=" + ID;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBD_DADOS());
                da.Fill(dt);
                ConexaoBD_DADOS().Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void edição(Membros m)   
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBD_DADOS();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE BD_Membros SET T_NOME='"+m.nome+ "', T_SOBRENOME='"+m.sobrenome+ "',DT_NASCIMENTO='"+m.nascimento+ "', N_ALTURA='"+m.altura+ "', N_PESO='"+m.peso+ "',T_GENERO='"+m.genero+ "' ,T_USUARIO='"+m.usuario+ "', N_SENHA='"+m.senha+ "', T_SITUAÇÃO='"+m.situação+ "'WHERE N_ID='"+m.id+"'";         
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBD_DADOS());
                cmd.ExecuteNonQuery();
                ConexaoBD_DADOS().Close();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void exclusão(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBD_DADOS();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM BD_Membros WHERE N_ID=" + id ;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBD_DADOS());
                cmd.ExecuteNonQuery();
                ConexaoBD_DADOS().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
