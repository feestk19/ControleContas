using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ControleDeContas.Telas
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Carregar(Object o, EventArgs e)
        {
            this.Refresh();

            for (int i = 1; i < 101; i++)
            {
                prgCarregamento.Value = i;
                Thread.Sleep(40);
            }

            prgCarregamento.Value = 99;
            Thread.Sleep(500);
            this.Close();
        }
    }
}
