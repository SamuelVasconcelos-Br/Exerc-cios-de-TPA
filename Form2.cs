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
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmhome home = new frmhome();
            home.Show();
        }

        private void btncalculare_Click(object sender, EventArgs e)
        {
            double num, result, I;

            I = 1;
   
            num = Convert.ToDouble(txtnum1.Text);

            while (I <= 10)
            {
                result = num * I;
                txtresult.AppendText($"{num} x {I} = {result}\r\n");
                I++;
            }
        }

        private void btncomandor_Click(object sender, EventArgs e)
        {
            btncalculare.Visible = false;
            btncalcularp.Visible = false;
            btncalcularr.Visible = true;
        }

        private void btncomandoe_Click(object sender, EventArgs e)
        {
            btncalcularr.Visible = false;
            btncalcularp.Visible = false;
            btncalculare.Visible = true;
        }

        private void btncomandop_Click(object sender, EventArgs e)
        {
            btncalcularr.Visible = false;
            btncalculare.Visible = false;
            btncalcularp.Visible = true;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtresult.Clear();
            txtnum1.Focus();

        }

        private void btncalcularp_Click(object sender, EventArgs e)
        {
            double num, result, I, J;

            I = 1;
            J = 1;

            num = Convert.ToDouble(txtnum1.Text);

            for (I = 1; I <= 1; I++)
            {
                while (J <= 10)
                {
                    result = num * J;
                    txtresult.AppendText($"{num} x {J} = {result}\r\n");
                    J++;
                }
            }
        }
        private void btncalcularr_Click(object sender, EventArgs e)
        {
            double num, result, I, J;

            I = 1;
            J = 1;

            num = Convert.ToDouble(txtnum1.Text);

            do
            {
                J = 1;
                while (J <= 10)
                {
                     result = num * J;
                    txtresult.AppendText($"{num} x {J} = {result}\r\n");
                    J++;
                }
                I++;
            } while (I <= 1);
        }
         
        private void frmtabuada_Load(object sender, EventArgs e)
        {

        }
    }
}
