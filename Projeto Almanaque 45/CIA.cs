using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Almanaque_45
{
    public partial class Cia : Form
    {
        public Cia()
        {
            InitializeComponent();
            Pequim pequim = new Pequim(this);
            pequim.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           MI6 mI6 = new MI6();
           mI6.ShowDialog();
            tb_usuario.Focus();
        }
        private void Cia_Load(object sender, EventArgs e)
        {
            dgv_exibição.DataSource = BD_DADOS.exibição();
        }
        private void tb_atualizar_Click(object sender, EventArgs e)
        {
            Membros membros = new Membros();
            dgv_exibição.DataSource = BD_DADOS.exibição();
        }
        private void tb_editar_Click(object sender, EventArgs e)
        {
            Membros m = new Membros();
            m.id = Convert.ToInt32(tb_id.Text);
            m.nome = tb_nome.Text;
            m.sobrenome = tb_sobre.Text;
            m.nascimento = tb_nascimento.Text;
            m.altura = tb_altura.Text;
            m.peso = tb_peso.Text;
            m.genero = tb_genero.Text;
            m.situação = tb_situação.Text;
            dgv_exibição.DataSource = BD_DADOS.exibição();
            BD_DADOS.edição(m); 
        }
        private void dgv_exibição_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = BD_DADOS.tabela(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_ID").ToString();
                tb_usuario.Text = dt.Rows[0].Field<string>("T_USUARIO").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("N_SENHA").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOME").ToString();
                tb_sobre.Text = dt.Rows[0].Field<string>("T_SOBRENOME").ToString();
                tb_nascimento.Text = dt.Rows[0].Field<string>("DT_NASCIMENTO").ToString();
                tb_altura.Text = dt.Rows[0].Field<string>("N_ALTURA").ToString();
                tb_peso.Text = dt.Rows[0].Field<string>("N_PESO").ToString();
                tb_genero.Text = dt.Rows[0].Field<string>("T_GENERO").ToString();
                tb_situação.Text = dt.Rows[0].Field<string>("T_SITUAÇÃO").ToString();
            }
        
        }
        public void dgv_exibição_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão ?","EXcluir ?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                BD_DADOS.exclusão(tb_id.Text);
                dgv_exibição.Rows.Remove(dgv_exibição.CurrentRow);
            }
        }
    }
}