using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        Cliente cli;

        private void TelaCliente_Load(object sender, EventArgs e)
        {
            cli = new Cliente();
            dgvdados.DataSource = cli.PesquisarTodos();
        }

        private void limpar()
        {
            txtcpf.Text = null;
            txtendereco.Text = null;
            txtnome.Text = null;
            txttelefone.Text = null;
            txtemail.Text = null;
            
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            cli = new Cliente();
            cli.cpf = txtcpf.Text;
            cli.endereco = txtendereco.Text;
            cli.telefone = txttelefone.Text;
            cli.email = txtemail.Text;
            
                if (cli.Salvar()) MessageBox.Show("Cadastrado com sucesso!");
                else MessageBox.Show("Não foi possível cadastrar!");
            
            TelaCliente_Load(sender, e);
            limpar();
        }
    }
}
