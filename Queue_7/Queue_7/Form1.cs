using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Queue<int> values = fill(textBoxLine.Text);
            textBoxResult.Text = output(maxWindow(values, Convert.ToInt32(textBoxWindow.Text)));
        }

        private Queue<int> fill(string line)
        {
            Queue<int> result = new Queue<int>();
            string temp = "";
            for(int i = 0; i < line.Length; i++)
            {
                if(Char.IsNumber(line[i]) || line[i] == '-')
                {
                    temp += line[i];
                }
                else if(temp != "")
                {
                    result.Enqueue(Convert.ToInt32(temp));
                    temp = "";
                }
            }
            return result;
        }

        private Queue<int> maxWindow(Queue<int> values, int size)
        {
            Queue<int> window = new Queue<int>();
            Queue<int> result = new Queue<int>();
            for(int i = 0; i < size; i++)
            {
                window.Enqueue(values.Dequeue());
            }
            result.Enqueue(window.Max());

            while (values.Count != 0)
            {
                window.Dequeue();
                window.Enqueue(values.Dequeue());
                result.Enqueue(window.Max());
            }
            return result;
        }

        private string output(Queue<int> values)
        {
            string result = "[";
            while (values.Count != 0)
            {
                result += values.Dequeue();
                if(values.Count > 0)
                {
                    result += ", ";
                }
            }
            result += "]";
            return result;
        }
    }
}
