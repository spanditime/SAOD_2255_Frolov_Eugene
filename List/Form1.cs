using System;
using SAOD;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        private List<string> List;
        public Form1()
        {
            List = new List<string>();
            InitializeComponent();
        }

        private bool validateIdx()
        {
            try
            {
                uint idx = Convert.ToUInt32(IdxTB.Text);
            }catch(Exception e)
            {
                IdxTB.BackColor = Color.Crimson;
                return false;
            }
            return true;
        }
        private void UpdateOutput()
        {
            var a = List.ToArray();
            string output = "";
            for(int i = 0; i < a.Length; i++)
            {
                output += "\"" + a[i].ToString() + "\"" +( (i == a.Length - 1) ? ("") : (","));
            }
            OutputTB.Text = output;
        }

        private void OnAdd()
        {
            ValueTB.Text = "";
        }

        private void AppendBTN_Click(object sender, EventArgs e)
        {
            List.Append(ValueTB.Text);
            UpdateOutput();
            OnAdd();
        }

        private void IdxTB_TextChanged(object sender, EventArgs e)
        {
            IdxTB.BackColor = Color.White;
        }

        private void PrependBTN_Click(object sender, EventArgs e)
        {
            List.Prepend(ValueTB.Text);
            UpdateOutput();
            OnAdd();
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            List.Remove(ValueTB.Text);
            UpdateOutput();
        }

        private void RemoveAtBTN_Click(object sender, EventArgs e)
        {
            if (validateIdx())
            {
                List.RemoveAt(Convert.ToUInt32(IdxTB.Text));
            }
            UpdateOutput();
        }

        private void FindBTN_Click(object sender, EventArgs e)
        {
            try
            {
                uint idx = List.Find(ValueTB.Text);
                IdxTB.Text = idx.ToString();
                IdxTB.BackColor = Color.LightGreen;
            } catch(Exception exc)
            {
                IdxTB.Text = "Not found";
                IdxTB.BackColor = Color.Crimson;
            }
            UpdateOutput();
        }

        private void AtBTN_Click(object sender, EventArgs e)
        {
            if (validateIdx())
            {
                try
                {
                    ValueTB.Text = List.At(Convert.ToUInt32(IdxTB.Text));
                }catch(Exception exc)
                {
                    IdxTB.BackColor = Color.Crimson;
                    ValueTB.Text = "";
                }
            }
        }

        private void ValueTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (e.Shift)
                {
                    PrependBTN_Click(sender, e);
                }
                else
                {
                    AppendBTN_Click(sender, e);
                }
            }
        }
    }
}
