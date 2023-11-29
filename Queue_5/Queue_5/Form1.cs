using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class MyCircularQueue
        {

            int[] q;
            int front = 0;
            int rear = -1;
            int count = 0;
            int capacity = 0;

            public MyCircularQueue(int k)
            {
                capacity = k;
                q = new int[k];
            }

            public bool EnQueue(int value)
            {
                if (IsFull())
                {
                    return false;
                }
                else
                {
                    rear = (rear + 1) % capacity;
                    q[rear] = value;
                    count++;
                    return true;
                }
            }

            public bool DeQueue()
            {
                if (IsEmpty())
                {
                    return false;
                }
                else
                {
                    front = (front + 1) % capacity;
                    count--;
                    if(count < 0)
                    {
                        count = 0;
                    }
                    return true;
                }
            }

            public int Front()
            {
                if(count != 0)
                {
                    return q[front];
                }
                else
                {
                    return -1;
                }
            }

            public int Rear()
            {
                if(count != 0)
                {
                    return q[rear];
                }
                else
                {
                    return -1;
                }
            }

            public bool IsEmpty()
            {
                if(count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool IsFull()
            {
                if(count == capacity)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private MyCircularQueue q;

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            q = new MyCircularQueue(Convert.ToInt32(numericUpDownSize.Value));
        }

        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            if(q != null)
            {
                if (q.EnQueue(Convert.ToInt32(numericUpDownIn.Value)))
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

        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                if (q.DeQueue())
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
                textBoxOut.Text = "No Queue!";
            }
            else
            {
            }
            textBoxOut.Text = q.Front().ToString();
        }

        private void buttonFront_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                textBoxOut.Text = q.Front().ToString();
            }
            else
            {
                textBoxOut.Text = "No Queue!";
            }
        }

        private void buttonRear_Click(object sender, EventArgs e)
        {
            if (q != null)
            {
                textBoxOut.Text = q.Rear().ToString();
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
                if (q.IsEmpty() == true)
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
                if (q.IsFull() == true)
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
