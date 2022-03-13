using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.DAO
{
    internal class ProdutoDAO
    {
        public static string sqlInsert()
        {
            string locSQL = "INSERT INTO PRODUTO (DSPRODUTO, VLPESOLIQ, VLUNITARIO) VALUES " +
                "(@DSPRODUTO, @VLPESOLIQ, @VLUNITARIO)";

            return locSQL;
        }

        public static string sqlSelect()
        {
            string locSQL = "SELECT CDPRODUTO, DSPRODUTO, VLPESOLIQ, " +
                "VLUNITARIO FROM PRODUTO WHERE CDPRODUTO = @CDPRODUTO";

            return locSQL;
        }

        public static string sqlUpdate()
        {
            string locSQL = "UPDATE PRODUTO SET DSPRODUTO = @DSPRODUTO, " +
                "VLPESOLIQ = @VLPESOLIQ, VLUNITARIO = @VLUNITARIO " +
                "WHERE CDPRODUTO = @CDPRODUTO";

            return locSQL;
        }

        public static string sqlDelete()
        {
            string locSQL = "DELETE FROM PRODUTO WHERE  CDPRODUTO = @CDPRODUTO";

            return locSQL;
        }

        public static Boolean Adicionar(string CDPRODUTO, 
                                        string DSPRODUTO,
                                        string VLPESOLIQ,
                                        string VLUNITARIO)
        {
            try
            {
                SqlCommand c;
                SqlConnection conn = Conexao.ConexaoBD();
                if(CDPRODUTO.ToString() == "")
                {
                     c = new SqlCommand(sqlInsert(), conn);
                }
                else
                {
                    c = new SqlCommand(sqlUpdate(), conn);
                    c.Parameters.Add(new SqlParameter("@CDPRODUTO", CDPRODUTO));
                }
                c.Parameters.Add(new SqlParameter("@DSPRODUTO", DSPRODUTO));
                c.Parameters.Add(new SqlParameter("@VLPESOLIQ", VLPESOLIQ.Replace(",", ".")));
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

        public static Boolean Excluir(int CdProduto)
        {
            try
            {
                SqlConnection conn = Conexao.ConexaoBD();
                SqlCommand c = new SqlCommand(ClientesDAO.sqlDelete(), conn);
                c.Parameters.Add(new SqlParameter("@CDPRODUTO", CdProduto));
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

        public static object[] Produto(int CdProduto)
        {
            object[] Prod = new object[4];
            SqlDataReader dr;
            SqlConnection conn = Conexao.ConexaoBD();
            SqlCommand c = new SqlCommand(ProdutoDAO.sqlSelect(), conn);
            c.Parameters.Add(new SqlParameter("@CDPRODUTO", CdProduto));
            conn.Open();
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                Prod[0] = dr["DSPRODUTO"].ToString();
                Prod[1] = dr["VLPESOLIQ"].ToString();
                Prod[2] = dr["VLUNITARIO"].ToString();
            }
            return Prod;
        }

    }
}
