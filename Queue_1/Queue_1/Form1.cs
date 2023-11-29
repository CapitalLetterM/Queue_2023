using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = findUnique(textBoxIn.Text).ToString();
        }

        private int findUnique(string line)
        {
            Queue <int> q = new Queue<int>();
            int[] arr = new int[26];
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                q.Enqueue(i);
                arr[ch - 'a']++;
                while (q.Count != 0)
                {
                    if (arr[line[q.Peek()] - 'a'] > 1)
                    {
                        q.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (q.Count == 0)
            {
                return -1;
            }
            else
            {
                return q.Dequeue();
            }
        }
    }
}
