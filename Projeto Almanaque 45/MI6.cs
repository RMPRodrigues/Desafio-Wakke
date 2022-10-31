using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Projeto_Almanaque_45
{
    public partial class MI6 : Form
    {
        public MI6()
        {
            InitializeComponent();
        }
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_acionar_Click(object sender, EventArgs e)
        {
            Membros membros = new Membros();

            membros.nome = tb_nome.Text;
            membros.sobrenome = tb_sobre.Text;
            membros.usuario = tb_usuario.Text;
            membros.altura = tb_altura.Text;
            membros.peso = tb_peso.Text;
            membros.genero = tb_genero.Text;
            membros.senha = tb_senha.Text;
            membros.nascimento = tb_nascimento.Text;
            membros.situação = tb_situacao.Text;
            BD_DADOS.cadastro(membros);

        }
        private void MI6_Load(object sender, EventArgs e)
        {

        }
        private void bt_limpar_Click(object sender, EventArgs e)
        { 
            tb_nome.Clear();
            tb_sobre.Clear();
            tb_altura.Clear();
            tb_genero.Clear();
            tb_nascimento.Clear();
            tb_usuario.Clear();
            tb_senha.Clear();
            tb_usuario.Focus();
        }

    }
}

