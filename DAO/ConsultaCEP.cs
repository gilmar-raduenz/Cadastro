using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Teste.DAO
{
    internal class ConsultaCEP
    {
        public static List<DadosCEP> Consultar(string valorcep)
        {
            string response = "";
            var dsEnde = new List<DadosCEP>();
            string strURL = "https://viacep.com.br/ws/" + valorcep + "/xml";
            var httpClient = new WebClient();
            try
            {
                response = httpClient.DownloadString(strURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar os dados do CEP! " + ex.Message);
            }
            dsEnde = LerXML(response);
            return dsEnde;
        }

        public static List<DadosCEP> LerXML(string ArquivoXML)
        {
            var ListaDados = new List<DadosCEP>();
            DadosCEP reg = new DadosCEP(); 
            XmlDocument xmlDoc;
            xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(ArquivoXML);
            XmlNodeList XmlNodeL;
            XmlNodeL = xmlDoc.GetElementsByTagName("xmlcep");
            foreach (XmlNode varNode in XmlNodeL)
            {
                reg.cep = varNode["cep"].InnerText;
                reg.logradouro  = varNode["logradouro"].InnerText;
                reg.complemento  = varNode["complemento"].InnerText;
                reg.bairro = varNode["bairro"].InnerText;
                reg.localidade = varNode["localidade"].InnerText;
                reg.uf = varNode["uf"].InnerText;
                reg.ibge = varNode["ibge"].InnerText;
                reg.gia = varNode["gia"].InnerText;
                reg.ddd = varNode["ddd"].InnerText;
                reg.siafi = varNode["siafi"].InnerText;
                ListaDados.Add(reg);
            }
            return ListaDados;
        }
    }
}
