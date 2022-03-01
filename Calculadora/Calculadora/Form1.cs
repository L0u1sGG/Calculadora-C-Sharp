using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        double res = 0;
        string valAnt = "";
        double calculo = 0;
        string oper = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtValAnt.Text += "1";
            valAnt += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtValAnt.Text += "2";
            valAnt += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtValAnt.Text += "3";
            valAnt += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtValAnt.Text += "4";
            valAnt += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtValAnt.Text += "5";
            valAnt += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtValAnt.Text += "6";
            valAnt += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtValAnt.Text += "7";
            valAnt += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtValAnt.Text += "8";
            valAnt += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtValAnt.Text += "9";
            valAnt += "9";
        }

        private void btnDel_Click(object sender, EventArgs e) 
        {
            txtResultado.Text = null;
            txtValAnt.Text = null;
            calculo = 0;
            res = 0;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = " ";
            txtValAnt.Text += " / ";
            oper = "div";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = " ";
            txtValAnt.Text += " * ";
            oper = "multi";
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = " ";
            txtValAnt.Text += " - ";
            oper = "sub";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = " ";
            txtValAnt.Text += " + ";
            oper = "soma";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(oper == "soma")
            {
                res = calculo + Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = Convert.ToString(res);
            }
            else if(oper == "sub")
            {
                res = calculo - Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = Convert.ToString(res);
            }
            else if(oper == "multi")
            {
                res = calculo * Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = Convert.ToString(res);
            }
            else
            {
                res = calculo / Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = Convert.ToString(res);
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
            txtValAnt.Text += ",";
            valAnt += ",";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtValAnt.Text += "0";
            valAnt += "0";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
