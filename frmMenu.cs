using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.DAO;

namespace Teste
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm;
            frm = new frmCliente();
            frm.Show();
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            frmProduto frm;
            frm = new frmProduto();
            frm.Show();
        }

        private void mnuPedidos_Click(object sender, EventArgs e)
        {
            frmPedido frm;
            frm = new frmPedido();
            frm.Show();
        }

         private void frmMenu_Load(object sender, EventArgs e)
        {
            Global.ConexaoBD = Conexao.LerArquivoConfiguracao();
        }
    }
}
