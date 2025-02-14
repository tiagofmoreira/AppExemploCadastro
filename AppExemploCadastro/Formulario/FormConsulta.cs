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
    public partial class FormConsulta : Form
    {
        List<Pessoa> ListaPessoas = new List<Pessoa>();
        public FormConsulta()
        {
            InitializeComponent();
            PessoaContext context = new PessoaContext();//preparou a conexão
            ListaPessoas = context.ListarPessoas(); //conectou e buscou no banco
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            var selecao = ListaPessoas.Where(p => p.Nome.Contains(txtNome.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
