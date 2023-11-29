using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyCircularDeque
        {
            Queue<int> q;
            int sizeCap;

            public MyCircularDeque(int size)
            {
                q = new Queue<int>();
                sizeCap = size;
            }

            public bool insertFront(int value)
            {
                if(q.Count != sizeCap)
                {
                    Queue<int> tempQ = new Queue<int>();
                    tempQ.Enqueue(value);
                    while(q.Count != 0)
                    {
                        tempQ.Enqueue(q.Dequeue());
                    }
                    q = tempQ;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool insertLast(int value)
            {
                if(q.Count != sizeCap)
                {
                    q.Enqueue(value);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool deleteFront()
            {
                if(q.Count != 0)
                {
                    q.Dequeue();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool deleteLast()
            {
                if(q.Count != 0)
                {
                    for (int i = 0; i < q.Count - 1; i++)
                    {
                        q.Enqueue(q.Dequeue());
                    }
                    q.Dequeue();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int getFront()
            {
                if(q.Count != 0)
                {
                    return q.Peek();
                }
                else
                {
                    return -1;
                }
            }

            public int getRear()
            {
                if (q.Count != 0)
                {
                    return q.Last();
                }
                else
                {
                    return -1;
                }
            }

            public bool isEmpty()
            {
                if (q.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool isFull()
            {
                if(q.Count == sizeCap)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private MyCircularDeque q;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            q = new MyCircularDeque(Convert.ToInt32(numericUpDownSize.Value));
        }

        private void buttonInFront_Click(object sender, EventArgs e)
        {
            if(q != null)
            {
                if(q.insertFront(Convert.ToInt32(numericUpDownIn.Value)) == true)
                {
                    textBoxOut.Text = "True";
                }
                else
                {
                    textBoxOut.Text = "False";
                }
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonInRear_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                if (q.insertLast(Convert.ToInt32(numericUpDownIn.Value)) == true)
                {
                    textBoxOut.Text = "True";
                }
                else
                {
                    textBoxOut.Text = "False";
                }
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonDelFront_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                if (q.deleteFront() == true)
                {
                    textBoxOut.Text = "True";
                }
                else
                {
                    textBoxOut.Text = "False";
                }
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonDelRear_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                if (q.deleteLast() == true)
                {
                    textBoxOut.Text = "True";
                }
                else
                {
                    textBoxOut.Text = "False";
                }
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonGetFront_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                textBoxOut.Text = q.getFront().ToString();
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonGetRear_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                textBoxOut.Text = q.getRear().ToString();
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                if(q.isEmpty() == true)
                {
                    textBoxOut.Text = "True";
                }
                else
                {
                    textBoxOut.Text = "False";
                }
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonFull_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                if (q.isFull() == true)
                {
                    textBoxOut.Text = "True";
                }
                else
                {
                    textBoxOut.Text = "False";
                }
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }
    }
}
