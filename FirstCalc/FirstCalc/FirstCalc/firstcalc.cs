using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCalc
{
    public partial class Form1 : Form
    {
        int tmp; //this will store the number
        string op; //this will store the operation
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this will be the code of the eq
            switch (op)
            {
                case "+": myres.Text = (tmp + int.Parse(myres.Text))+"";
                    break;
                case "-": myres.Text = (tmp - int.Parse(myres.Text)).ToString();
                    break;
            }

        }

        void numclick(object x, EventArgs y)
        {
            myres.Text += (x as Button).Text;
        }

        void opclick(object x, EventArgs y)
        {
            try
            {
                tmp = int.Parse(myres.Text);
            }
            catch 
            {
                MessageBox.Show("You did not enter a number");
                myres.Text = "";
                return;
            }
            op = (x as Button).Text;
            myres.Text = "";
            //OR
            myres.Clear();
        }

    }
}
