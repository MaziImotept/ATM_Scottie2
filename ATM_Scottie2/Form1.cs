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
        Account first = new Account("scottie", 100.00, "1");
        int I = 0;
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

            public void WithdrawalAmount(double amount)
            {
                accountBalance = accountBalance - amount;
            }
            public void DepositAmount(double amount)
            {
                accountBalance = accountBalance + amount;
            }
            Account[] accounts = { };
          



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
           
           
                I++;
                string number = I.ToString();
            first.setAccountname(name);
            first.setAccountnumber(number);
            first.setAccountbalance(100.0);
                
               

            MessageBox.Show(first.getAccountname());
           

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

        private void button3_Click(object sender, EventArgs e)
        {

           
            string s = first.getAccountbalance().ToString();
            textBox1.Text = s;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int amount = Convert.ToInt16(textBox1.Text);
            first.WithdrawalAmount(amount);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt16(textBox1.Text);
            first.DepositAmount(amount);
        }
    }
}
