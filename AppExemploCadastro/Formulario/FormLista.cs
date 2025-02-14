using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploCadastro.Contexto;

namespace AppExemploCadastro.Formulario
{
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
            PessoaContext context = new PessoaContext();//prepara a conexão com o banco
            dtTabela.DataSource = context.ListarPessoas();//busca no banco e colocar os dados no grid
        }
    }
}
