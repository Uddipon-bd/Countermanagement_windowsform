using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countermanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<int>token=new Queue<int>();
        int counter = 0;

        private void Token_Click(object sender, EventArgs e)
        {
            token.Enqueue(++counter);
            if (token.Count > 0)
            {
                listBox1.DataSource = token.ToList();
                this.btncounter1.Enabled = true;
                this.btncounter2.Enabled = true;
                this.btncounter3.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.token.Count == 0)
            {
                this.btncounter1.Enabled = false;
                this.btncounter2.Enabled = false;
                this.btncounter3.Enabled = false;
            }
        }

        private void ManageToken(TextBox t, string n)
        {
            if (token.Count > 0)
            {

                string fitem = token.Peek().ToString();
                t.Text = fitem;
                this.lblmsg.Text = $" No   {fitem} please come at Counter {n}";
                token.Dequeue();
                this.listBox1.DataSource = token.ToList();
            }
            else
            {
                MessageBox.Show("Token list empty");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncounter1_Click(object sender, EventArgs e)
        {
            this.ManageToken(textBox1, "1");
        }

        private void btncounter2_Click(object sender, EventArgs e)
        {
            this.ManageToken(textBox2, "2");
        }

        private void btncounter3_Click(object sender, EventArgs e)
        {
            this.ManageToken(textBox3, "3");
        }

        
    }
}
