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
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }

        Fornecedor forn;

        private void cv(object sender, EventArgs e)
        {

        }

        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            dgvdados.DataSource = forn.PesquisarTodos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Razao = txtnome.Text;
            forn.Telefone = txttelefone.Text;
            forn.Cnpj = txtcnpj.Text;
            forn.Email = txtemail.Text;
            if (txtid.Text.Equals(""))
            {                
                if (forn.Salvar()) MessageBox.Show("Cadastrado com sucesso!");
                else MessageBox.Show("Não foi possível cadastrar!");
            } else
            {
                forn.Id = Convert.ToInt32(txtid.Text); 
                if (forn.Atualizar()) MessageBox.Show("Atualizado com sucesso!");
                else MessageBox.Show("Não foi possível atualizar!");
            }
            TelaFornecedor_Load(sender,  e);
            limpar();
        }
        private void limpar()
        {
            txtid.Text = null;
            txttelefone.Text = null;
            txtnome.Text = null;
            txtemail.Text = null;   
            txtcnpj.Text = null;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id=Convert.ToInt32(txtid.Text);
            if (forn.Excluir()) MessageBox.Show("Excluído com sucesso!");
            else MessageBox.Show("Não foi possível excluir!");
            TelaFornecedor_Load(sender, e);
            limpar();
        }

        private void txtcnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            forn = new Fornecedor();
            if (e.KeyChar == (char) Keys.Enter)
            {
                DataTable dt = new DataTable();
                forn.Cnpj = txtcnpj.Text;  
                dt = forn.Pesquisar();
                txtid.Text = dt.Rows[0]["tb03_id"].ToString();
                txtnome.Text = dt.Rows[0]["tb03_razao"].ToString();
                txttelefone.Text = dt.Rows[0]["tb03_telefone"].ToString();
                txtemail.Text = dt.Rows[0]["tb03_email"].ToString();
            }
        }

        private void dgvdados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            forn = new Fornecedor();
            forn.Cnpj = (string)dgvdados["tb03_cnpj", e.RowIndex].Value;
            DataTable dt = new DataTable();
            dt = forn.Pesquisar();
            txtid.Text = dt.Rows[0]["tb03_id"].ToString();
            txtnome.Text = dt.Rows[0]["tb03_razao"].ToString();
            txttelefone.Text = dt.Rows[0]["tb03_telefone"].ToString();
            txtemail.Text = dt.Rows[0]["tb03_email"].ToString();
            txtcnpj.Text = dt.Rows[0]["tb03_cnpj"].ToString();
        }
    }
}
