using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliciariaDoChupeto
{
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabuada tabuada = new frmtabuada();
            tabuada.Show();
        }

        private void conversorDeTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmconversor conversor = new frmconversor();
            conversor.Show();
        }

        private void áreaDoÍmovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmimovel imovel = new frmimovel();
            imovel.Show();
        }

        private void frmhome_Load(object sender, EventArgs e)
        {

        }
    }
}
