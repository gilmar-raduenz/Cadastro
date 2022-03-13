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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            int NrPedido = PedidoDAO.Adicionar(txtNrPedido.Text,
                                    txtDtPedido.Text,
                                    txtCDCliente.Text,
                                    txtVlTotal.Text,
                                    txtPesoTotal.Text);


            if (NrPedido > 0)
            {
                GravarItens(NrPedido);
                MessageBox.Show("Pedido salvo com sucesso!");
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o Pedido!");
            }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (PedidoDAO.Excluir(int.Parse(txtNrPedido.Text)))
            {
                if (PedidoItemDAO.Excluir(int.Parse(txtNrPedido.Text)))
                {

                    MessageBox.Show("Pedido excluído com sucesso!");
                    limpaCampos();
                }
            }
            else
            {
                MessageBox.Show("Erro na exclusão do Pedido!");
            };
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmPesquisa frm;
            frm = new frmPesquisa(3);
            frm.ShowDialog();
            if (Global.Codigo > 0)
            {
                CarregarDados(Global.Codigo);
                CarregarDadosItens(Global.Codigo);
            }
            Global.Codigo = 0;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void CarregarDados(int Codigo)
        {
            SqlCommand c;
            SqlDataReader dr;
            SqlConnection conn = Conexao.ConexaoBD();
            c = new SqlCommand(PedidoDAO.sqlSelect(), conn);
            c.Parameters.Add(new SqlParameter("@NRPEDIDO", Codigo));
            conn.Open();
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                txtNrPedido.Text = dr["NRPEDIDO"].ToString();
                txtNmCliente.Text = dr["NMCLIENTE"].ToString();
                txtDtPedido.Text = dr["DTEMISSAO"].ToString();
                txtCDCliente.Text = dr["CDCLIENTE"].ToString();
                txtVlTotal.Text = dr["VLPRECOTOTAL"].ToString();
                txtPesoTotal.Text = dr["VLPESOTOTAL"].ToString();
            }
            dr.Close();
            conn.Close();
        }

        private void CarregarDadosItens(int Codigo)
        {
            int i = 0;
            SqlCommand c;
            SqlDataReader dr;
            SqlConnection conn = Conexao.ConexaoBD();
            c = new SqlCommand(PedidoItemDAO.sqlSelect(), conn);
            c.Parameters.Add(new SqlParameter("@NRPEDIDO", Codigo));
            conn.Open();
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                object[] Prod = new object[4];
                Prod = ProdutoDAO.Produto(int.Parse(dr["CDPRODUTO"].ToString()));
                dtgvItem.Rows.Add();
                dtgvItem.Refresh();
                dtgvItem.Rows[i].Cells[0].Value = dr["CDPRODUTO"].ToString();
                dtgvItem.Rows[i].Cells[1].Value = Prod[0];
                dtgvItem.Rows[i].Cells[2].Value = dr["QTPRODUTO"].ToString();
                dtgvItem.Rows[i].Cells[3].Value = dr["VLUNITARIO"].ToString();
                dtgvItem.Rows[i].Cells[4].Value = Prod[1];
                dtgvItem.Rows[i].Cells[5].Value = Convert.ToDecimal(dr["VLUNITARIO"].ToString()) * Convert.ToDecimal(dr["QTPRODUTO"].ToString());
                dtgvItem.Rows[i].Cells[6].Value = Convert.ToDecimal(Prod[1].ToString()) * Convert.ToDecimal(dr["QTPRODUTO"].ToString());
                i++;
            }
            dtgvItem.Refresh();
            dr.Close();
            conn.Close();
            CalcularTotais();
        }



            private void limpaCampos()
        {
            txtDtPedido.Text = DateTime.Now.ToString("d");
            txtNrPedido.Text = "";
            txtCDCliente.Text = "";
            txtNmCliente.Text = "";
            dtgvItem.Rows.Clear();
            txtCDCliente.Focus();
        }

         private void txtCDCliente_Leave(object sender, EventArgs e)
        {
            if(txtCDCliente.Text != "")
            {
                txtNmCliente.Text = ClientesDAO.Cliente(int.Parse(txtCDCliente.Text));
                if (txtNmCliente.Text == string.Empty)
                {
                    MessageBox.Show("Cliente não foi localizado!");
                }
            }
         }


        private void GravarItens(int NrPedido)
        {
            for (int i = 0; i < dtgvItem.Rows.Count - 1; i++)
            {
                if (dtgvItem.Rows[i].Cells[5].Value.ToString() != "") 
                 {
                    PedidoItemDAO.Adicionar(NrPedido,
                        int.Parse(dtgvItem.Rows[i].Cells[0].Value.ToString()),
                        int.Parse(dtgvItem.Rows[i].Cells[2].Value.ToString()),
                        dtgvItem.Rows[i].Cells[3].Value.ToString());
                 }
            }
        }

        private void dtgvItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object[] Prod = new object[4];
            Prod = ProdutoDAO.Produto(int.Parse(dtgvItem.Rows[e.RowIndex].Cells[0].Value.ToString()));
            if (e.ColumnIndex == 0)
            {
                if (dtgvItem.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    dtgvItem.Rows[e.RowIndex].Cells[1].Value = Prod[0];
                    dtgvItem.Rows[e.RowIndex].Cells[3].Value = Prod[1];
                    dtgvItem.Rows[e.RowIndex].Cells[4].Value = Prod[2];
                }
            }
            if (e.ColumnIndex == 2)
            {
                if((dtgvItem.Rows[e.RowIndex].Cells[0].Value.ToString() != "") && (dtgvItem.Rows[e.RowIndex].Cells[2].Value.ToString() != ""))
                {
                    dtgvItem.Rows[e.RowIndex].Cells[5].Value = Convert.ToDecimal(dtgvItem.Rows[e.RowIndex].Cells[2].Value.ToString()) * Convert.ToDecimal(Prod[1].ToString());
                    dtgvItem.Rows[e.RowIndex].Cells[6].Value = Convert.ToDecimal(dtgvItem.Rows[e.RowIndex].Cells[2].Value.ToString()) * Convert.ToDecimal(Prod[2].ToString());
                    CalcularTotais();
                }
            }
            
        }

        private void CalcularTotais()
        {
            decimal VlTotal = 0;
            decimal vlPesoTotal = 0;
            
            for (int i = 0; i < dtgvItem.Rows.Count - 1; i++)
            {
                if (dtgvItem.Rows[i].Cells[5].Value.ToString() != "")
                {
                    VlTotal += Convert.ToDecimal(dtgvItem.Rows[i].Cells[5].Value.ToString());
                    vlPesoTotal += Convert.ToDecimal(dtgvItem.Rows[i].Cells[6].Value.ToString());  
                }
            }

            txtPesoTotal.Text = vlPesoTotal.ToString();
            txtVlTotal.Text = VlTotal.ToString();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            txtDtPedido.Text = DateTime.Now.ToString("d");
         }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisa frm;
            frm = new frmPesquisa(1);
            frm.ShowDialog();
            if (Global.Codigo > 0)
            {
                txtCDCliente.Text = Global.Codigo.ToString();
                txtNmCliente.Text = ClientesDAO.Cliente(Global.Codigo);
            }
            Global.Codigo = 0;
        }
    }
}
