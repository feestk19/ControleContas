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
using ControleDeContas.Telas;
using ControleDeContas.Database;
using System.Globalization;

namespace ControleDeContas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Shown(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmWelcome fw = new frmWelcome();
        //    fw.ShowDialog();
        //    this.Show();
        //}

        Conexao con = new Conexao();

        // -- Configura DataGridView -- \\
        public void configuraDataGridView()
        {
            //Renomeia as colunas do DataGridView
            gridPrincipal.Columns[0].HeaderText = "Código";
            gridPrincipal.Columns[1].HeaderText = "Nome da Conta";
            gridPrincipal.Columns[2].HeaderText = "Descrição";
            gridPrincipal.Columns[3].HeaderText = "Valor";
            gridPrincipal.Columns[4].HeaderText = "Data de Vencimento";
            gridPrincipal.Columns[5].HeaderText = "Data de Pagamento";
            gridPrincipal.Columns[6].HeaderText = "Tipo da Conta";
            gridPrincipal.Columns[7].HeaderText = "Status";
        }

        // -- Atualiza DataGridView -- \\
        public void atualizaDataGridView(String instrucaoSQL)
        {
            SqlConnection conn = new SqlConnection(con.StringConexao());

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(instrucaoSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gridPrincipal.DataSource = ds;
                gridPrincipal.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os dados! \n\n" + ex + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(con.StringConexao());
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha de acesso ao banco de dados. \n\nDescrição do erro: \n\n " + ex + ". ");
                return;
                //throw;
            }

            //Define os comandos SQL
            SqlCommand cmd = new SqlCommand("SELECT * FROM CONTAS ORDER BY IDCONTA ASC", cn);

            //Faz a ponte entre o objeto DataSet e a fonte de dados - Cria um adapter para preencher um DataSet
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Define um objeto DataSet que guardará na memória os dados obtidos da fonte de dados
            DataSet ds = new DataSet();

            //Estrutura da tabela do BD ou de outra fonte de dados
            DataTable contas = new DataTable();

            //Método do DataAdapter que Recupera os dados do DataSource usando a instrução SQL
            da.Fill(contas);

            //Obtém ou define a fonte de dados que será exibida no DataGridView
            gridPrincipal.DataSource = contas;
            atualizaDataGridView("EXEC SELECIONA_CONTAS_ALL_V1");
            configuraDataGridView();
        }

        private void configuraTimer(Object o, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("F");
        }
    }
}
