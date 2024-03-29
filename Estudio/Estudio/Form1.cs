﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201278", "cl201278", "cl*03082005"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPsw_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtUser.Text, txtPsw.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM") ;
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                teToolStripMenuItem.Text = "Bem-vindo, administrador " + char.ToUpper(txtUser.Text[0]) + txtUser.Text.Substring(1) + "!";
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
                teToolStripMenuItem.Text = "Bem-vindo, usuário " + char.ToUpper(txtUser.Text[0]) + txtUser.Text.Substring(1) + "!";
            }
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cadLogin>().Count() == 0)
            {
                cadLogin cad_login = new cadLogin();
                cad_login.MdiParent = this;
                cad_login.Show();
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cadAluno>().Count() == 0)
            {
                cadAluno cad_aluno = new cadAluno();
                cad_aluno.MdiParent = this;
                cad_aluno.Show();
            }

        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<excAluno>().Count() == 0)
            {
                excAluno exc_aluno = new excAluno();
                exc_aluno.MdiParent = this;
                exc_aluno.Show();
            }
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cadModalidade>().Count() == 0)
            {
                cadModalidade cad_mod = new cadModalidade();
                cad_mod.MdiParent = this;
                cad_mod.Show();
            }
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<excModalidade>().Count() == 0)
            {
                excModalidade exc_mod = new excModalidade();
                exc_mod.MdiParent = this;
                exc_mod.Show();
            }
        }

        private void atualizarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<consModalidade>().Count() == 0)
            {
                consModalidade cons_mod = new consModalidade();
                cons_mod.MdiParent = this;
                cons_mod.Show();
            }
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<consModalidade>().Count() == 0)
            {
                int a = 0; // Variável genérica, tem o intuito apenas de chamar um construtor diferente na classe do formulário e abrir de maneira diferente.
                consModalidade cons_mod = new consModalidade(a);
                cons_mod.MdiParent = this;
                cons_mod.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cadAluno>().Count() == 0)
            {
                Cad_Turma cad_Turma = new Cad_Turma();
                cad_Turma.MdiParent = this;
                cad_Turma.Show();
            }
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirTurma ex_Turma = new ExcluirTurma();
            ex_Turma.MdiParent = this;
            ex_Turma.Show();
        }
    }
}
