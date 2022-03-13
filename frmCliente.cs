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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtNmCliente.Focus(); 
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
              
              if(ClientesDAO.Adicionar(txtCdCliente.Text,
                  txtNmCliente.Text,
                  txtNrCEP.Text, 
                  txtDsLogradouro.Text,
                  txtNmBairro.Text, 
                  txtDsComplemento.Text,
                  txtNmCidade.Text,
                  txtUF.Text,
                  txtCdIBGE.Text))
              {
                MessageBox.Show("Cliente salvo com sucesso!");
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o clente!");
            }
                   
        }

         private void btExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir o registro do cliente?","Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ClientesDAO.Excluir(int.Parse(txtCdCliente.Text)))
                {
                    MessageBox.Show("Cliente excluído com sucesso!");
                    limpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro na exclusão do cliente!");
                };
            }
 
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmPesquisa frm;
            frm = new frmPesquisa(1);
            frm.ShowDialog();
            if(Global.Codigo > 0)
            {
                CarregarDados(Global.Codigo);
            }
            Global.Codigo = 0;
        }

        private void CarregarDados(int Codigo)
        {
            SqlDataReader dr;
            SqlConnection conn = Conexao.ConexaoBD();
            SqlCommand c = new SqlCommand(ClientesDAO.sqlSelect(), conn);
            c.Parameters.Add(new SqlParameter("@CDCLIENTE", Codigo));
            conn.Open();
            dr = c.ExecuteReader();
            while (dr.Read())
            {
                txtCdCliente.Text = dr["CDCLIENTE"].ToString();
                txtNmCliente.Text = dr["NMCLIENTE"].ToString();
                txtNrCEP.Text = dr["NRCEP"].ToString();
                txtDsLogradouro.Text = dr["DSLOGRADOURO"].ToString();
                txtNmBairro.Text = dr["DSBAIRRO"].ToString();
                txtDsComplemento.Text = dr["DSCOMPLEMENTO"].ToString();
                txtNmCidade.Text = dr["NMCIDADE"].ToString();
                txtUF.Text = dr["UF"].ToString();
                txtCdIBGE.Text = dr["CDIBGE"].ToString();
            }

            dr.Close();
            conn.Close();
        }

        private void limpaCampos()
        {
            txtCdCliente.Text = "";
            txtNmCliente.Text = "";
            txtNrCEP.Text = "";
            txtDsLogradouro.Text = "";
            txtNmBairro.Text = "";
            txtDsComplemento.Text = "";
            txtNmCidade.Text = "";
            txtUF.Text = "";
            txtCdIBGE.Text = "";
            txtNmCliente.Focus();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void txtNrCEP_Leave(object sender, EventArgs e)
        {
            if(txtNrCEP.Text !="")
            {
                var cep = new List<DadosCEP>();
                cep = ConsultaCEP.Consultar(txtNrCEP.Text);
                if (cep.Count > 0)
                {
                    txtNmCidade.Text = cep[0].localidade;
                    txtUF.Text = cep[0].uf;
                    txtCdIBGE.Text = cep[0].ibge;
                }
            }


        }
    }
}
