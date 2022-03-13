using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.DAO
{
    internal class PedidoItemDAO
    {
        public static string sqlInsert()
        {
            string locSQL = "INSERT INTO PEDIDOITEM (NRPEDIDO, CDPRODUTO, QTPRODUTO, VLUNITARIO) VALUES " +
                "(@NRPEDIDO, @CDPRODUTO, @QTPRODUTO, @VLUNITARIO)";

            return locSQL;
        }

        public static string sqlSelect()
        {
            string locSQL = "SELECT NRPEDIDO, CDPRODUTO, QTPRODUTO, VLUNITARIO " +
                " FROM PEDIDOITEM WHERE NRPEDIDO = @NRPEDIDO ORDER BY CDPRODUTO";

            return locSQL;
        }

        public static string sqlUpdate()
        {
            string locSQL = "UPDATE PEDIDOITEM SET NRPEDIDO = @NRPEDIDO, " +
                "CDPRODUTO = @CDPRODUTO, QTPRODUTO = @QTPRODUTO, VLUNITARIO = @VLUNITARIO " +
                "WHERE NRPEDIDO = @NRPEDIDO AND CDPRODUTO = @CDPRODUTO";

            return locSQL;
        }

        public static string sqlDelete(Boolean Item)
        {
            string locSQL = "DELETE FROM PEDIDOITEM WHERE NRPEDIDO = @NRPEDIDO";
            if (Item)
            {
                locSQL += " AND CDPRODUTO = @CDPRODUTO";
            }
            return locSQL;
        }

        public static Boolean Adicionar(int NRPEDIDO,
                                        int CDPRODUTO,
                                        int QTPRODUTO,
                                        String VLUNITARIO)
        {
            try
            {
                SqlCommand c;
                SqlConnection conn = Conexao.ConexaoBD();
                c = new SqlCommand(sqlDelete(true), conn);
                c.Parameters.Add(new SqlParameter("@CDPRODUTO", CDPRODUTO));
                c.Parameters.Add(new SqlParameter("@NRPEDIDO", NRPEDIDO));
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();

                c = new SqlCommand(sqlInsert(), conn);
                c.Parameters.Add(new SqlParameter("@CDPRODUTO", CDPRODUTO));
                c.Parameters.Add(new SqlParameter("@NRPEDIDO", NRPEDIDO));
                c.Parameters.Add(new SqlParameter("@QTPRODUTO", QTPRODUTO));
                c.Parameters.Add(new SqlParameter("@VLUNITARIO", VLUNITARIO.Replace(",", ".")));
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {
                return false;

            }
            return true;
        }

        public static Boolean Excluir(int NrPedido)
        {
            try
            {
                SqlConnection conn = Conexao.ConexaoBD();
                SqlCommand c = new SqlCommand(sqlDelete(false), conn);
                c.Parameters.Add(new SqlParameter("@NRPEDIDO", NrPedido));
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;

            }
            return true;

        }

        public static Boolean ExcluirItem(int CdProduto, int NrPedido)
        {
            try
            {
                SqlConnection conn = Conexao.ConexaoBD();
                SqlCommand c = new SqlCommand(sqlDelete(true), conn);
                c.Parameters.Add(new SqlParameter("@CDPRODUTO", CdProduto));
                c.Parameters.Add(new SqlParameter("@NRPEDIDO", NrPedido));
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                return false;

            }
            return true;

        }

    }
}
