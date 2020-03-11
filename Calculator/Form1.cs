using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double result = 0;
        char op = ' ';


        public Form1()
        {
            InitializeComponent();
        }

        private void check()
        {
            if (txtanswer.Text == "0")
                txtanswer.Clear();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "1";
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "2";
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "3";
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "4";
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "5";
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "6";
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "7";
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "8";
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "9";

        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            check();
            txtanswer.Text = txtanswer.Text + "0";
        }

        private void cmdpoint_Click(object sender, EventArgs e)
        {
            string displaydot = txtanswer.Text;
            if (displaydot.IndexOf('.') == -1)
            {
                txtanswer.Text = txtanswer.Text + ".";

            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            txtanswer.Text = "0";
            result = 0;
            lblshow.Text = "";
        }

        private void cmdequel_Click(object sender, EventArgs e)
        {

            if (op != ' ')
            {
                switch (op)
                {
                    case '+':
                        result = result + double.Parse(txtanswer.Text);
                        txtanswer.Text = result.ToString();
                        break;

                    case '-':
                        result = result - double.Parse(txtanswer.Text);
                        txtanswer.Text = result.ToString();
                        break;
                    case '*':
                        result = result * double.Parse(txtanswer.Text);
                        txtanswer.Text = result.ToString();
                        break;
                    case '/':
                        result = result / double.Parse(txtanswer.Text);
                        txtanswer.Text = result.ToString();
                        break;

                }
            }

            

        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtanswer.Text);
            txtanswer.Clear();
            lblshow.Text = result.ToString() + " +";
            op = '+';
        }

        private void cmdsubtract_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtanswer.Text);
            txtanswer.Clear();
            lblshow.Text = result.ToString() + " -";
            op = '-';


        }

        private void cmdmultiply_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtanswer.Text);
            txtanswer.Clear();
            lblshow.Text = result.ToString() + " *";
            op = '*';

        }

        private void cmdivide_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtanswer.Text);
            txtanswer.Clear();
            lblshow.Text = result.ToString() + " /";
            op = '/';

        }

        private void cmderace_Click(object sender, EventArgs e)
        {
            txtanswer.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtanswer.Text);
            result = System.Math.Sqrt(result);
            txtanswer.Text = result.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtanswer.Text);
            result = System.Math.Pow(result, 2);
            txtanswer.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double displayValue = double.Parse(txtanswer.Text);
            if (displayValue != 0)
            {
                txtanswer.Text = (displayValue * -1).ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            result = double.Parse(txtanswer.Text);

        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            string delete = txtanswer.Text.ToString();
            if (delete.Length > 1)
            {
                delete = delete.Substring(0, delete.Length - 1);
            }

            txtanswer.Text = delete;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
