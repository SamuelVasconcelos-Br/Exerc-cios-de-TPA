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
    public partial class frmconversor : Form
    {
        public frmconversor()
        {
            InitializeComponent();
        }
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmhome home = new frmhome();
            home.Show();
        }

        private void btncomandor_Click(object sender, EventArgs e)
        {
            btncalculare.Visible = false;
            btncalcularp.Visible = false;
            btncalcularr.Visible = true;
        }

        private void btncomandoe_Click(object sender, EventArgs e)
        {
            btncalcularp.Visible = false;
            btncalcularr.Visible = false;
            btncalculare.Visible = true;
        }

        private void btncomandop_Click(object sender, EventArgs e)
        {
            btncalculare.Visible = false;
            btncalcularr.Visible = false;
            btncalcularp.Visible = true;
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttemp1.Clear();
            txtresult.Clear();
            txttemp1.Focus();
        }

        private void btncalculare_Click(object sender, EventArgs e)
        {
            double I = 0, C, F, result;

            C = Convert.ToDouble(txttemp1.Text);

            while(I<=100)
            {
                F = C * 1.8 + 32;
                result = I + F;
                txtresult.AppendText($"{result}° Farenheit\r\n");
                I=  I + 10;
            }
        }

        private void frmconversor_Load(object sender, EventArgs e)
        {

        }

        private void btncalcularp_Click(object sender, EventArgs e)
        {
            double J = 0, C, F, result;
            int I = 1;

            C = Convert.ToDouble(txttemp1.Text);

            for (I = 1; I <= 1; I++)
            {
                while(J<=100)
                {
                    F = C * 1.8 + 32;
                    result = J + F;
                    txtresult.AppendText($"{result}° Farenheit\r\n");
                    J= J + 10;
                }
            }
        }

        private void btncalcularr_Click(object sender, EventArgs e)
        {
            double I = 1, J = 0, C, F, result;

            C = Convert.ToDouble(txttemp1.Text);

            do
            {
                while (J <= 100)
                {
                    F = C * 1.8 + 32;
                    result = J + F;
                    txtresult.AppendText($"{result}° Farenheit\r\n");
                    J= J + 10;
                }
                I++;
            } while(I<=1);

        }
    }
}
