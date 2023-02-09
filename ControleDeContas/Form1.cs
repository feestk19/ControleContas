using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeContas.Telas;

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
            this.cONTASTableAdapter.Fill(this.controleContasBD.CONTAS);
            // TODO: This line of code loads data into the 'bancoDeDadosDataSet.CONTAS' table. You can move, or remove it, as needed.
            this.cONTASTableAdapter.Fill(this.controleContasBD.CONTAS);

        }
    }
}
