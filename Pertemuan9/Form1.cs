using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double temp;
        char oper;
        bool oper1;

        private void Form1_Load(object sender, EventArgs e)
        {
            bersih();
            focus();
        }

        private void bersih()
        {
            txthasil.Text = "0";
            txtinput.Text = "";
            temp = 0;
            oper = ' ';
            oper1 = false;
        }

        private void focus()
        {
            txthasil.Focus();
            txthasil.Select(txthasil.Text.Length, 0);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            bersih();
            focus();
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnAng = (Button)sender;
            if (txthasil.Text == "0" || oper1)
            {
                txthasil.Text = btnAng.Text;
                oper1 = false;
            }
            else
            {
                txthasil.Text += btnAng.Text;
            }
            focus();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succes");
            Button op = (Button)sender;
            if (oper1)
            {
                oper1 = false;
            }
            else
            {
                if (txtinput.Text == "")
                {
                    temp = Convert.ToDouble(txthasil.Text);
                }
                else
                {
                    if (oper == '+')
                    {
                        temp = temp + Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == '-')
                    {
                        temp = temp - Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == '/')
                    {
                        temp = temp / Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == 'X')
                    {
                        temp = temp * Convert.ToDouble(txthasil.Text);
                    }
                }
            }

            txtinput.Text = temp.ToString() + op.Text;
            txthasil.Text = "0";
            oper = Convert.ToChar(op.Text);
            focus();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txthasil.Text.Length > 0)
            {
                txthasil.Text = txthasil.Text.Remove(txthasil.Text.Length - 1);
            }

            if (oper == '=')
            {
                temp = 0;
                oper1 = false;
                oper = ' ';
            }

            focus();
        }
    }
}

