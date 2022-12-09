using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOD;

namespace RPN
{
    public partial class Form1 : Form
    {
        SAOD.RPN Rpn;
        public Form1()
        {
            InitializeComponent();
            Rpn = new SAOD.RPN("2+(2*2)");
            textBox1.Text = Rpn.InfixNotation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateOutput()
        {
            textBox2.Text = Rpn.PostfixNotation;
            textBox3.Text = Rpn.Result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            try
            {
                SAOD.RPN nrpn = new SAOD.RPN(textBox1.Text);
                Rpn = nrpn;
                UpdateOutput();
            }
            catch (Exception exc)
            {
                textBox1.BackColor = Color.Crimson;
            }
        }
    }
}
