using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class RecentCounter
        {
            Queue<int> pings;

            public RecentCounter()
            {
                pings = new Queue<int>();
            }

            public int ping(int time)
            {
                pings.Enqueue(time);
                while(pings.Last() - pings.Peek() > 3000)
                {
                    pings.Dequeue();
                }
                return pings.Count();
            }
        }

        public RecentCounter counter;

        private void Form1_Load(object sender, EventArgs e)
        {
            counter = new RecentCounter();
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            textBoxCount.Text = counter.ping(Convert.ToInt32(textBoxTime.Text)).ToString();
        }
    }
}
