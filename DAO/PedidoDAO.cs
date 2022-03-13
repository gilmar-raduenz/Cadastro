using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.DAO
{
    internal class PedidoDAO
    {
        public static string sqlInsert()
        {
            string locSQL = "INSERT INTO PEDIDO (NRPEDIDO, CDCLIENTE, DTEMISSAO, VLPRECOTOTAL, VLPESOTOTAL) VALUES " +
                "(@NRPEDIDO, @CDCLIENTE, @DTEMISSAO, @VLPRECOTOTAL, @VLPESOTOTAL)";

            return locSQL;
        }

        public static string sqlSelect()
        {
            string locSQL = "SELECT P.NRPEDIDO, P.CDCLIENTE, P.DTEMISSAO, P.VLPRECOTOTAL, P.VLPESOTOTAL, " +
                " C.NMCLIENTE FROM PEDIDO P INNER JOIN CLIENTE C ON P.CDCLIENTE = C.CDCLIENTE " +
                "WHERE NRPEDIDO = @NRPEDIDO";

            return locSQL;
        }

        public static string sqlUpdate()
        {
            string locSQL = "UPDATE PEDIDO SET CDLCLIENTE = @CDCLIENTE, " +
                "DTEMISSAO = @DTEMISSAO, VLPRECOTOTAL = @VLPRECOTOTAL, VLPESOTOTAL = @VLPESOTOTAL " +
                "WHERE NRPEDIDO = @NRPEDIDO";

            return locSQL;
        }

        public static string sqlDelete()
        {
            string locSQL = "DELETE FROM PEDIDO WHERE  NRPEDIDO = @NRPEDIDO";

            return locSQL;
        }

        public static string sqlNumeroPedido()
        {
            string locSQL = "SELECT MAX(NRPEDIDO) AS NUM FROM PEDIDO";
            return locSQL;
        }


        public static int Adicionar(string NRPEDIDO,
                                        string DTEMISSAO,
                                        string CDCLIENTE,
                                        string VLPRECOTOTAL,
                                        string VLPESOTOTAL)
        {
            int NrPedido = 0;
            try
            {
                SqlCommand c;
                SqlConnection conn = Conexao.ConexaoBD();
                if (NRPEDIDO.ToString() == "")
                {
                    c = new SqlCommand(sqlInsert(), conn);
                    NrPedido = NumeroPedido();
                    c.Parameters.Add(new SqlParameter("@NRPEDIDO", NrPedido)); 
                }
                else
                {
                    c = new SqlCommand(sqlUpdate(), conn);
                    NrPedido = Convert.ToInt32(NRPEDIDO);
                    c.Parameters.Add(new SqlParameter("@NRPEDIDO", NRPEDIDO));
                }
                c.Parameters.Add(new SqlParameter("@CDCLIENTE", CDCLIENTE));
                c.Parameters.Add(new SqlParameter("@DTEMISSAO", DTEMISSAO));
                c.Parameters.Add(new SqlParameter("@VLPRECOTOTAL", VLPRECOTOTAL.Replace(",",".")));
                c.Parameters.Add(new SqlParameter("@VLPESOTOTAL", VLPESOTOTAL.Replace(",", ".")));

                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                return NrPedido;

            }
            catch
            {
                return NrPedido;

            }
        }

        public static Boolean Excluir(int Nrpedido)
        {
            try
            {
                SqlConnection conn = Conexao.ConexaoBD();
                SqlCommand c = new SqlCommand(sqlDelete(), conn);
                c.Parameters.Add(new SqlParameter("@NRPEDIDO", Nrpedido));
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

        public static int NumeroPedido()
        {
            int NrPed = 1;
            SqlDataReader dr;
            SqlConnection conn = Conexao.ConexaoBD();
            SqlCommand c = new SqlCommand(sqlNumeroPedido(), conn);
            conn.Open();
            dr = c.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["NUM"].ToString() != "")
                {
                    NrPed += Convert.ToInt32(dr["NUM"].ToString());
                }
            }
            return NrPed;
        }
    }
}
