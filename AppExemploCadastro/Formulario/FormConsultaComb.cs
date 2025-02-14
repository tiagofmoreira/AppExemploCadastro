using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploCadastro.Contexto;
using AppExemploCadastro.Models;

namespace AppExemploCadastro.Formulario
{
    public partial class FormConsultaComb : Form
    {
        int contExc = 0;
        List<Pessoa> ListaPessoas = new List<Pessoa>();
        public FormConsultaComb()
        {
            InitializeComponent();
            PessoaContext context = new PessoaContext();//prepararou a conexão
            ListaPessoas = context.ListarPessoas(); //conectou e buscou no banco
            comboBox1.DataSource = ListaPessoas.ToList();
            comboBox1.DisplayMember = "Nome";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var pessoaSelec = ListaPessoas[linhaSelec];
                txtNome.Text = pessoaSelec.Nome;
                txtCpf.Text = pessoaSelec.Cpf;
                txtRegistroGeral.Text = pessoaSelec.RegistroGeral;
                txtEmail.Text = pessoaSelec.Email;
            }
            contExc++;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var pessoaSelec = ListaPessoas[linhaSelec];
                pessoaSelec.Nome = txtNome.Text;
                pessoaSelec.Cpf = txtCpf.Text;
                pessoaSelec.RegistroGeral = txtRegistroGeral.Text;
                pessoaSelec.Email = txtEmail.Text;

                PessoaContext context = new PessoaContext();
                context.AtualizarPessoa(pessoaSelec);
                MessageBox.Show("ID: "+pessoaSelec.Id+"ATUALIZADO COM SUCESSO!", "2° A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtCpf.Clear(); txtEmail.Clear(); txtRegistroGeral.Clear();  
                txtNome.Select();
                contExc = 0;
                ListaPessoas = context.ListarPessoas();
                comboBox1.DataSource = context.ListarPessoas();
                comboBox1.DataSource = ListaPessoas.ToList();
                comboBox1 .SelectedIndex = -1;

            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            var linhaSelec = comboBox1.SelectedIndex;
            if (linhaSelec > -1 && contExc > 0)
            {
                var pessoaSelec = ListaPessoas[linhaSelec];
                pessoaSelec.Nome = txtNome.Text;
                pessoaSelec.Cpf = txtCpf.Text;
                pessoaSelec.RegistroGeral = txtRegistroGeral.Text;
                pessoaSelec.Email = txtEmail.Text;

                PessoaContext context = new PessoaContext();
                context.DeletarPessoa(pessoaSelec);
                MessageBox.Show("ID: " + pessoaSelec.Id + "ATUALIZADO COM SUCESSO!", "2° A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtCpf.Clear(); txtEmail.Clear(); txtRegistroGeral.Clear();
                txtNome.Select();
                contExc = 0;
                ListaPessoas = context.ListarPessoas();
                comboBox1.DataSource = ListaPessoas.ToList();
                comboBox1.SelectedIndex = -1;

            }
        }
    }
}

