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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); txtCpf.Clear(); txtEmail.Clear(); txtRegistroGeral.Clear();
            txtNome.Select();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.Cpf = txtCpf.Text;
            pessoa.RegistroGeral = txtRegistroGeral.Text;
            pessoa.Email = txtEmail.Text;
            //Chamar a classe contexto para inserir os dados no banco
            PessoaContext context = new PessoaContext();
            context.InserirPessoa(pessoa); 
            MessageBox.Show("SALVO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Clear(); txtCpf.Clear(); txtEmail.Clear(); txtRegistroGeral.Clear();
            txtNome.Select();
        }
    }

}