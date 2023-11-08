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
    public partial class frmimovel : Form
    {
        public frmimovel()
        {
            InitializeComponent();
        }
        double resultfinal;
        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmimovel_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcomprimento.Clear();
            txtcontinuar.Clear();
            txtlargura.Clear();
            txtnome.Clear();
            txtresultcomodo.Clear();
            txtresultfinal.Clear();
            txtresultfinal.Visible = false;
            txtcontinuar.Visible = false;
            lblcontinuar.Visible = false;
            lblresultfinal.Visible = false;
            lblresultcomodo.Visible = true;
            txtresultcomodo.Visible = true;
    
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmhome home = new frmhome();
            home.Show();
        }

        private void lblcontinuar_Click(object sender, EventArgs e)
        {

        }

        private void lblresultcomodo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblcomando_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double area, comp, larg;

            comp = Convert.ToDouble(txtcomprimento.Text);
            larg = Convert.ToDouble(txtlargura.Text);

            area = comp * larg;
            resultfinal += area;
            txtresultcomodo.Text = area.ToString() + "m²";

            var result = MessageBox.Show("Deseja continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtcomprimento.Clear();
                txtlargura.Clear();
                txtresultcomodo.Clear();
                txtnome.Clear();
            }
            else
            {
                lblresultfinal.Visible = true;
                txtresultfinal.Visible = true;
                txtresultcomodo.Visible = false;
                lblresultcomodo.Visible = false;

                txtresultfinal.Text = resultfinal.ToString() + "m²";
            }
        }
    }
}
