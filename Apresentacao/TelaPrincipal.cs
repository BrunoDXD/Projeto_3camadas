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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela;

        private void btnfornecedor_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaFornecedor { 
                TopLevel=false,
                Dock=DockStyle.Fill,
                FormBorderStyle=FormBorderStyle.None,
            };
            pnltela.Controls.Add(tela);
            tela.Show();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaCliente
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            pnltela.Controls.Add(tela);
            tela.Show();
        }
    }
}
