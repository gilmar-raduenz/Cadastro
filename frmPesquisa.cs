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
    public partial class frmPesquisa : Form
    {
        
        public frmPesquisa(int Tipo)
        {
            InitializeComponent();
            ExibirDados(Tipo);
            FormatarGrid();
        }

         private void ExibirDados(int Tipo)
        {
            try
            {
                string strSQL;
                strSQL = "";
                SqlDataAdapter adapt;
                SqlConnection conn = Conexao.ConexaoBD();
                DataTable dt = new DataTable();
                switch(Tipo)
                {
                    case 1: 
                        strSQL = "SELECT CDCLIENTE, NMCLIENTE FROM CLIENTE ORDER BY CDCLIENTE";
                        break;
                    case 2: 
                        strSQL = "SELECT CDPRODUTO, DSPRODUTO FROM PRODUTO ORDER BY CDPRODUTO";
                        break;
                    case 3: 
                        strSQL = "SELECT NRPEDIDO, NMCLIENTE FROM PEDIDO P INNER JOIN CLIENTE C ON C.CDCLIENTE = P.CDCLIENTE ORDER BY NMCLIENTE";
                        break;
                }

                adapt = new SqlDataAdapter(strSQL, conn);
                adapt.Fill(dt);
                dtgvPesquisa.DataSource = dt;
                dtgvPesquisa.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente não foi localizado!" + ex.Message);
                throw;
            }
 
        }

        private void FormatarGrid()
        {
            dtgvPesquisa.AllowUserToAddRows = false;
            dtgvPesquisa.AllowUserToDeleteRows = false;
            foreach (DataGridViewColumn col in dtgvPesquisa.Columns)
            {
               if(col.Index == 0)
                {
                    col.Width = 50;
                }
               else
                {
                    col.Width = 280;
                }

            }
        }

    
        private void dtgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Global.Codigo = Convert.ToInt32(dtgvPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString());
                Close();

            }
            catch
            {
            }
        }
    }
}
