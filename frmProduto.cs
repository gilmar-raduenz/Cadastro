using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.DAO;

namespace Teste
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            if (ProdutoDAO.Adicionar(txtCdProduto.Text, 
                                    txtDsProduto.Text,
                                    txtVlPesoLiq.Text,
                                    txtVlUnitario.Text))
            {
                MessageBox.Show("Produto salvo com sucesso!");
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o Produto!");
            }

        }

         private void btExcluir_Click(object sender, EventArgs e)
        {
            if (ClientesDAO.Excluir(int.Parse(txtCdProduto.Text)))
            {
                MessageBox.Show("Produto excluído com sucesso!");
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Erro na exclusão do Produto!");
            };
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmPesquisa frm;
            frm = new frmPesquisa(2);
            frm.ShowDialog();
            if (Global.Codigo > 0)
            {
                CarregarDados(Global.Codigo);
            }
            Global.Codigo = 0;
        }

        private void CarregarDados(int Codigo)
        {
            SqlDataReader dr;
            SqlConnection conn = Conexao.ConexaoBD();
            SqlCommand c = new SqlCommand(ProdutoDAO.sqlSelect(), conn);
            c.Parameters.Add(new SqlParameter("@CDPRODUTO", Codigo));
            conn.Open();
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                txtCdProduto.Text = dr["CDPRODUTO"].ToString();
                txtDsProduto.Text = dr["DSPRODUTO"].ToString();
                txtVlPesoLiq.Text = dr["VLPESOLIQ"].ToString();
                txtVlUnitario.Text = dr["VLUNITARIO"].ToString();
            }
            dr.Close();
            conn.Close();

        }

        private void limpaCampos()
        {
            txtCdProduto.Text = "";
            txtDsProduto.Text = "";
            txtVlPesoLiq.Text = "";
            txtVlUnitario.Text = "";
            txtDsProduto.Focus();  
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void txtVlPesoLiq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != 8) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }

        private void txtVlUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != 8) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
    }
}
