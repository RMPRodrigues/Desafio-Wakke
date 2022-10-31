namespace Projeto_Almanaque_45
{
    partial class Cia
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
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.dgv_exibição = new System.Windows.Forms.DataGridView();
            this.tb_atualizar = new System.Windows.Forms.Button();
            this.tb_editar = new System.Windows.Forms.Button();
            this.tb_situação = new System.Windows.Forms.TextBox();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.tb_altura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nascimento = new System.Windows.Forms.TextBox();
            this.tb_sobre = new System.Windows.Forms.TextBox();
            this.lb_sobrenome = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_genero = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.lb_nascimento = new System.Windows.Forms.Label();
            this.lb_altura = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_genero = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exibição)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(465, 220);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(109, 23);
            this.bt_excluir.TabIndex = 0;
            this.bt_excluir.Text = "Excluir Selecionado";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(465, 376);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(109, 23);
            this.bt_cadastrar.TabIndex = 2;
            this.bt_cadastrar.Text = "Cadastra ";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_exibição
            // 
            this.dgv_exibição.AllowUserToAddRows = false;
            this.dgv_exibição.AllowUserToDeleteRows = false;
            this.dgv_exibição.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_exibição.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exibição.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_exibição.Location = new System.Drawing.Point(0, 0);
            this.dgv_exibição.Name = "dgv_exibição";
            this.dgv_exibição.ReadOnly = true;
            this.dgv_exibição.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_exibição.Size = new System.Drawing.Size(701, 214);
            this.dgv_exibição.TabIndex = 3;
            this.dgv_exibição.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_exibição_CellContentClick);
            this.dgv_exibição.SelectionChanged += new System.EventHandler(this.dgv_exibição_SelectionChanged);
            // 
            // tb_atualizar
            // 
            this.tb_atualizar.Location = new System.Drawing.Point(580, 376);
            this.tb_atualizar.Name = "tb_atualizar";
            this.tb_atualizar.Size = new System.Drawing.Size(109, 23);
            this.tb_atualizar.TabIndex = 4;
            this.tb_atualizar.Text = "Atualizar";
            this.tb_atualizar.UseVisualStyleBackColor = true;
            this.tb_atualizar.Click += new System.EventHandler(this.tb_atualizar_Click);
            // 
            // tb_editar
            // 
            this.tb_editar.Location = new System.Drawing.Point(580, 220);
            this.tb_editar.Name = "tb_editar";
            this.tb_editar.Size = new System.Drawing.Size(109, 23);
            this.tb_editar.TabIndex = 5;
            this.tb_editar.Text = "Editar selecionado";
            this.tb_editar.UseVisualStyleBackColor = true;
            this.tb_editar.Click += new System.EventHandler(this.tb_editar_Click);
            // 
            // tb_situação
            // 
            this.tb_situação.Location = new System.Drawing.Point(121, 371);
            this.tb_situação.Name = "tb_situação";
            this.tb_situação.Size = new System.Drawing.Size(100, 20);
            this.tb_situação.TabIndex = 120;
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(330, 329);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(100, 20);
            this.tb_peso.TabIndex = 119;
            // 
            // tb_altura
            // 
            this.tb_altura.Location = new System.Drawing.Point(226, 329);
            this.tb_altura.Name = "tb_altura";
            this.tb_altura.Size = new System.Drawing.Size(100, 20);
            this.tb_altura.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Usuario";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(227, 251);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(100, 20);
            this.tb_senha.TabIndex = 114;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(121, 251);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_usuario.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Situação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 110;
            // 
            // tb_nascimento
            // 
            this.tb_nascimento.Location = new System.Drawing.Point(15, 329);
            this.tb_nascimento.Name = "tb_nascimento";
            this.tb_nascimento.Size = new System.Drawing.Size(203, 20);
            this.tb_nascimento.TabIndex = 109;
            // 
            // tb_sobre
            // 
            this.tb_sobre.Location = new System.Drawing.Point(224, 290);
            this.tb_sobre.Name = "tb_sobre";
            this.tb_sobre.Size = new System.Drawing.Size(301, 20);
            this.tb_sobre.TabIndex = 108;
            // 
            // lb_sobrenome
            // 
            this.lb_sobrenome.AutoSize = true;
            this.lb_sobrenome.Location = new System.Drawing.Point(221, 274);
            this.lb_sobrenome.Name = "lb_sobrenome";
            this.lb_sobrenome.Size = new System.Drawing.Size(61, 13);
            this.lb_sobrenome.TabIndex = 107;
            this.lb_sobrenome.Text = "Sobrenome";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(9, 235);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 106;
            this.lb_id.Text = "ID";
            // 
            // lb_genero
            // 
            this.lb_genero.AutoSize = true;
            this.lb_genero.Location = new System.Drawing.Point(12, 355);
            this.lb_genero.Name = "lb_genero";
            this.lb_genero.Size = new System.Drawing.Size(42, 13);
            this.lb_genero.TabIndex = 105;
            this.lb_genero.Text = "Genero";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.Location = new System.Drawing.Point(327, 313);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(31, 13);
            this.lb_peso.TabIndex = 104;
            this.lb_peso.Text = "Peso";
            // 
            // lb_nascimento
            // 
            this.lb_nascimento.AutoSize = true;
            this.lb_nascimento.Location = new System.Drawing.Point(9, 313);
            this.lb_nascimento.Name = "lb_nascimento";
            this.lb_nascimento.Size = new System.Drawing.Size(104, 13);
            this.lb_nascimento.TabIndex = 103;
            this.lb_nascimento.Text = "Data de Nascimento";
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.Location = new System.Drawing.Point(221, 313);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(34, 13);
            this.lb_altura.TabIndex = 102;
            this.lb_altura.Text = "Altura";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(9, 274);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 101;
            this.lb_nome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Infomações";
            // 
            // tb_genero
            // 
            this.tb_genero.Location = new System.Drawing.Point(15, 371);
            this.tb_genero.Name = "tb_genero";
            this.tb_genero.Size = new System.Drawing.Size(100, 20);
            this.tb_genero.TabIndex = 99;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 290);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(206, 20);
            this.tb_nome.TabIndex = 98;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 251);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 97;
            this.tb_id.TabStop = false;
            // 
            // Cia
            // 
            this.ClientSize = new System.Drawing.Size(701, 411);
            this.Controls.Add(this.tb_situação);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.tb_altura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_nascimento);
            this.Controls.Add(this.tb_sobre);
            this.Controls.Add(this.lb_sobrenome);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_genero);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.lb_nascimento);
            this.Controls.Add(this.lb_altura);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_genero);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_editar);
            this.Controls.Add(this.tb_atualizar);
            this.Controls.Add(this.dgv_exibição);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_excluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cia";
            this.Text = "CIA";
            this.Load += new System.EventHandler(this.Cia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exibição)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.DataGridView dgv_exibição;
        private System.Windows.Forms.Button tb_atualizar;
        private System.Windows.Forms.Button tb_editar;
        private System.Windows.Forms.TextBox tb_situação;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.TextBox tb_altura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nascimento;
        private System.Windows.Forms.TextBox tb_sobre;
        private System.Windows.Forms.Label lb_sobrenome;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_genero;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label lb_nascimento;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_genero;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_id;
    }
}