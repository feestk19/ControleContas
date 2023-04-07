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

namespace ControleDeContas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome fw = new frmWelcome();
            fw.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controleContasBD.CONTAS' table. You can move, or remove it, as needed.
            //this.cONTASTableAdapter.Fill(this.controleContasBD.CONTAS);
            // TODO: This line of code loads data into the 'bancoDeDadosDataSet.CONTAS' table. You can move, or remove it, as needed.
           // this.cONTASTableAdapter.Fill(this.controleContasBD.CONTAS);

        }

        //private void CarregarDadosBanco(Object o, EventArgs e)
        //{
        //    try
        //    {
        //        using (SqlConnection cn = new SqlConnection())
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StringConexao))
                {
                    cn.Open();
                    MessageBox.Show("Conectado ao Banco de Dados com sucesso!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
        }
    }
}
