using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_Almanaque_45
{
    public partial class Pequim : Form
    {
        Cia cia;
        DataTable dt = new DataTable();

        public Pequim(Cia f)
        {
            InitializeComponent();
            cia = f;
        }
        private void bt_entrar_Click(object sender, EventArgs e)
        {            
            string username = tb_user.Text;
            string senha = tb_senha.Text;
            if(username == ""|| senha =="")
            {
                MessageBox.Show("Usuario e ou Senha Incorreto");
                tb_user.Focus();
                return;
            }
            string sql = "SELECT * FROM BD_Membros WHERE T_USUARIO='" + username + "' AND N_SENHA='" + senha + "'";
            dt = BD_DADOS.Consulta(sql);
            if (dt.Rows.Count == 1)
            {
 
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Não Encontrado");
                tb_user.Focus();
                return;
            }
        }
    }
}