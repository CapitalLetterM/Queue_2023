using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            List<int> line = parse(textBoxIn.Text);
            textBoxOut.Text = search(line, Convert.ToInt32(textBoxDifference.Text)).ToString();
        }

        private List<int> parse(string line)
        {
            List<int> result = new List<int>();
            string temp = "";
            for(int i = 0; i < line.Length; i++)
            {
                if(line[i] == '-' || Char.IsNumber(line[i]) == true)
                {
                    temp += line[i];
                }
                else if(temp != "")
                {
                    result.Add(Convert.ToInt32(temp));
                    temp = "";
                }
            }
            return result;
        }

        private int search(List<int> line, int limit)
        {
            Queue<int> result = new Queue<int>();
            for(int i = 0; i < line.Count; ++i)
            {
                if(result.Count != 0)
                {
                    line[i] += line[result.Peek()];
                }
                while(result.Count != 0 && (i - result.Peek() >= limit || line[i] >= line[result.Last()]))
                {
                    if(line[i] >= line[result.Last()])
                    {
                        for(int j = 0; j < result.Count - 1; j++)
                        {
                            result.Enqueue(result.Dequeue());
                        }
                    }
                    result.Dequeue();
                }
                if(line[i] > 0)
                {
                    result.Enqueue(i);
                }
            }

            if(line.First() > line.Last())
            {
                return line.First();
            }
            else
            {
                return line.Last();
            }
        }
    }
}
