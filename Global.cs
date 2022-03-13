using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public static class Global
    {

        private static int varCodigo = 0;
        private static string varConexaoBD = "";
        public static int Codigo
        {
            get { return varCodigo; }
            set { varCodigo = value; }
        }

        public static string ConexaoBD
        {
            get { return varConexaoBD; }
            set { varConexaoBD = value; }
        }

    }

}
