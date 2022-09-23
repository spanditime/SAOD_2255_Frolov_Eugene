using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOD;

namespace Stack
{
    public partial class Form1 : Form
    {
        private Stack<string> stack;
        public Form1()
        {
            InitializeComponent();
            stack = new Stack<string>(20);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void push_Click(object sender, EventArgs e)
        {

            try
            {
                stack.Push(input.Text);
                input.Text = "";
            } catch( Exception exc)
            {
                push.Enabled = false;
            }
            updateText();
        }

        private void pop_Click(object sender, EventArgs e)
        {
            push.Enabled = true;
            if (!stack.IsEmpty)
            {
                stack.Pop();
            }
            updateText();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Enabled = true;
            stack.Clear();
            updateText();
        }

        private void updateText()
        {
            string Text = "";
            string[] arr = stack.Values;
            for(int i =0; i < stack.Size; i++)
            {
                Text += arr[i];
                if (i != stack.Size - 1)
                    Text += ",";
            }
            output.Text = Text;
        }
    }
}
