using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAOD;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Queue<string> queue;

        private void push_Click(object sender, EventArgs e)
        {

            try
            {
                queue.Push(input.Text);
                input.Text = "";
            }
            catch (Exception exc)
            {
                push.Enabled = false;
            }
            updateText();
        }

        private void pop_Click(object sender, EventArgs e)
        {
            push.Enabled = true;
            if (!queue.IsEmpty)
            {
                queue.Pop();
            }
            updateText();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Enabled = true;
            queue.Clear();
            updateText();
        }

        private void updateText()
        {
            string Text = "";
            string[] arr = queue.Values;
            for (int i = 0; i < queue.Size; i++)
            {
                Text += arr[i];
                if (i != queue.Size - 1)
                    Text += ",";
            }
            output.Text = Text;
        }
    }
}
