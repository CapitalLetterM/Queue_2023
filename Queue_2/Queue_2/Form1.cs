using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_2
{
    public partial class Form1 : Form
    {
        public class MyStack
        {
            Queue<int> q;

            public MyStack()
            {
                q = new Queue<int>();
            }

            public void push(int value)
            {
                q.Enqueue(value);
            }

            public int pop()
            {
                for(int i = 0; i < q.Count - 1; i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                return q.Dequeue();
            }

            public int top()
            {
                return q.Last();
            }

            public bool empty()
            {
                if(q.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        MyStack stack;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateStack_Click(object sender, EventArgs e)
        {
            stack = new MyStack();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            if(stack != null)
            {
                stack.push(Convert.ToInt32(textBoxPush.Text));
                textBoxOut.Text = "";
            }
            else
            {
                textBoxOut.Text = "No Stack!";
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            if (stack != null)
            {
                if (stack.empty() != true)
                {
                    textBoxOut.Text = stack.pop().ToString();
                }
                else
                {
                    textBoxOut.Text = "Empty!";
                }
            }
            else
            {
                textBoxOut.Text = "No Stack!";
            }
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            if (stack != null)
            {
                if (stack.empty() != true)
                {
                    textBoxOut.Text = stack.top().ToString();
                }
                else
                {
                    textBoxOut.Text = "Empty!";
                }
            }
            else
            {
                textBoxOut.Text = "No Stack!";
            }
        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            if (stack != null)
            {
                if (stack.empty() == true)
                {
                    textBoxOut.Text = "Empty";
                }
                else
                {
                    textBoxOut.Text = "Not empty";
                }
            }
            else
            {
                textBoxOut.Text = "No Stack!";
            }
        }
    }
}
