using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Teste.DAO
{
    internal class ClientesDAO
    {

         public static string sqlInsert()
        {
            string locSQL = "INSERT INTO CLIENTE (NMCLIENTE, NRCEP, DSLOGRADOURO, DSBAIRRO, DSCOMPLEMENTO, NMCIDADE, UF, CDIBGE) VALUES " +
                "(@NMCLIENTE, @NRCEP, @DSLOGRADOURO, @DSBAIRRO, @DSCOMPLEMENTO, @NMCIDADE, @UF, @CDIBGE)";

            return locSQL;
        }

        public static string sqlSelect()
        {
            string locSQL = "SELECT CDCLIENTE, NMCLIENTE, " +
                "NRCEP, DSLOGRADOURO, DSBAIRRO, DSCOMPLEMENTO, " +
                "NMCIDADE, UF, CDIBGE " +
                "FROM CLIENTE WHERE CDCLIENTE = @CDCLIENTE";

            return locSQL;
        }

        public static string sqlDelete()
        {
            string locSQL = "DELETE FROM CLIENTE WHERE CDCLIENTE = @CDCLIENTE";

            return locSQL;
        }

        public static string sqlUpdate()
        {
            string locSQL = "UPDATE CLIENTE SET NMCLIENTE = @NMCLIENTE, " +
                "NRCEP = @NRCEP, DSLOGRADOURO = @DSLOGRADOURO, " +
                "DSBAIRRO = @DSBAIRRO, DSCOMPLEMENTO = @DSCOMPLEMENTO, NMCIDADE = @NMCIDADE, " +
                "UF = @UF , CDIBGE = @CDIBGE " +
                "WHERE CDCLIENTE = @CDCLIENTE";

            return locSQL;
        }



        public static Boolean Adicionar(string CDCLIENTE,
                                        string NMCLIENTE, 
                                        string NRCEP, 
                                        string DSLOGRADOURO, 
                                        string DSBAIRRO, 
                                        string DSCOMPLEMENTO,
                                        string NMCIDADE, 
                                        string UF, 
                                        string CDIBGE)
        {
            try
            {
                SqlCommand c;
                SqlConnection conn = Conexao.ConexaoBD();
                if(CDCLIENTE.ToString() == "")
                {
                     c = new SqlCommand(sqlInsert(), conn);
                }
                else
                {
                     c = new SqlCommand(sqlUpdate(), conn);
                     c.Parameters.Add(new SqlParameter("@CDCLIENTE", CDCLIENTE));
                }
                c.Parameters.Add(new SqlParameter("@NMCLIENTE", NMCLIENTE));
                c.Parameters.Add(new SqlParameter("@NRCEP", NRCEP));
                c.Parameters.Add(new SqlParameter("@DSLOGRADOURO", DSLOGRADOURO));
                c.Parameters.Add(new SqlParameter("@DSBAIRRO", DSBAIRRO));
                c.Parameters.Add(new SqlParameter("@DSCOMPLEMENTO", DSCOMPLEMENTO));
                c.Parameters.Add(new SqlParameter("@NMCIDADE", NMCIDADE));
                c.Parameters.Add(new SqlParameter("@UF", UF));
                c.Parameters.Add(new SqlParameter("@CDIBGE", CDIBGE));

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

        public static Boolean Excluir(int CdCliente)
        {
         try
            {
                SqlConnection conn = Conexao.ConexaoBD();
                SqlCommand c = new SqlCommand(ClientesDAO.sqlDelete(), conn);
                c.Parameters.Add(new SqlParameter("@CDCLIENTE", CdCliente));
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

        public static string Cliente(int CdCliente)
        {
            string NmCliente = "";
            SqlDataReader dr;
            SqlConnection conn = Conexao.ConexaoBD();
            SqlCommand c = new SqlCommand(ClientesDAO.sqlSelect(), conn);
            c.Parameters.Add(new SqlParameter("@CDCLIENTE", CdCliente));
            conn.Open();
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                NmCliente = dr["NMCLIENTE"].ToString();
            }
            return NmCliente;
        }

    }
}
