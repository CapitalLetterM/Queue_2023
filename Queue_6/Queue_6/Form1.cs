using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] MovesToStamp(string stamp, string target)
        {
            Queue<int> q = new Queue<int>();
            HashSet<int> h = new HashSet<int>();
            Stack<int> ans = new Stack<int>();
            List<Node> l = new List<Node>();

            for (int i = 0; i <= target.Length - stamp.Length; i++)
            {
                Node n = new Node();

                for (int j = 0; j < stamp.Length; j++)
                {
                    if (target[i + j] == stamp[j]) n.Made.Add(i + j);
                    else n.ToDo.Add(i + j);
                }

                l.Add(n);
                if (n.ToDo.Count == 0)
                {
                    ans.Push(i);
                    for (int j = i; j < i + stamp.Length; j++)
                    {
                        if (!h.Contains(j))
                        {
                            q.Enqueue(j);
                            h.Add(j);
                        }
                    }
                }
            }

            while (q.Count > 0)
            {
                int index = q.Dequeue();

                for (int i = Math.Max(0, index - stamp.Length + 1); i <= Math.Min(target.Length - stamp.Length, index); i++)
                {
                    if (l[i].ToDo.Contains(index))
                    {
                        l[i].ToDo.Remove(index);
                        if (l[i].ToDo.Count == 0)
                        {
                            ans.Push(i);
                            foreach (var madeIndex in l[i].Made)
                            {
                                if (!h.Contains(madeIndex))
                                {
                                    q.Enqueue(madeIndex);
                                    h.Add(madeIndex);
                                }
                            }
                        }
                    }
                }
            }

            if (h.Count != target.Length) return new int[0];
            return ans.ToArray();
        }

        class Node
        {
            public HashSet<int> Made { get; } = new HashSet<int>();
            public HashSet<int> ToDo { get; } = new HashSet<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int[] result = MovesToStamp(textBoxStamp.Text, textBoxTarget.Text);
            textBoxResult.Text = parse(result);
        }

        private string parse(int[] arr)
        {
            string result = "[";
            for(int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                if(i != arr.Length - 1)
                {
                    result += ", ";
                }
            }
            result += "]";
            return result;
        }
    }
}
