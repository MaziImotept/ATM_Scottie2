using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Scottie2
{
    public partial class Form1 : Form
    {
        private class Account
        {
            private string accountName;
            private double accountBalance;
            private string accountNumber;

            public Account(string N, double B, string num)
            {
                accountName = N;
                accountBalance = B;
                accountNumber = num;
            }

            public void setAccountname(string name)
            {
                accountName = name;
            }
            public void setAccountbalance(double balance)
            {
                accountBalance = balance;
            }
            public void setAccountnumber(string number)
            {
                accountNumber = number;
            }

            public string getAccountname()
            {
                return accountName;
            }
            public double getAccountbalance()
            {
                return accountBalance;
            }
            public string getAccountnumber()
            {
                return accountNumber;
            }



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = enterbox.Text;
            Account[] accounts = { };
            if (Array.IndexOf(accounts, enterbox.Text) != 0)
            {
                int I = 0;
                I++;
                string number = I.ToString();
                
                Account first = new Account(name, 100.00, number);
                MessageBox
            }

            mainmenu.Visible = false;
            secondarymenu.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainmenu.Visible = true;
            secondarymenu.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
