using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.DAO
{
    internal class Conexao
    {
        public static SqlConnection ConexaoBD()
        {
            SqlConnection conn = new SqlConnection(Global.ConexaoBD);
            return conn;
        }

         public static string LerArquivoConfiguracao()
        {
            string strCon = "";
            string[] lines = System.IO.File.ReadAllLines(@"C:\DADOS\ConexaoBD.ini");
            foreach (string line in lines)
            {
                strCon = lines[0];
            }
            return strCon;
        }



    }
}
