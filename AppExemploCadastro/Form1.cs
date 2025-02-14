using AppExemploCadastro.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog(); 
        }

        private void btLista_Click(object sender, EventArgs e)
        {
            FormLista form = new FormLista();
            form.ShowDialog();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            FormConsulta form = new FormConsulta();
            form.ShowDialog();
        }

        private void btConsultaLista_Click(object sender, EventArgs e)
        {
            FormConsultaComb form = new FormConsultaComb();
            form.ShowDialog();
        }
    }
}
