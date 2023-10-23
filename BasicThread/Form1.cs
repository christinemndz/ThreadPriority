using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread ThreadA, ThreadB, ThreadC, ThreadD;


        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start1= new ThreadStart(MyThreadClass.Thread1);
            ThreadStart start2 = new ThreadStart(MyThreadClass.Thread2);

           Thread ThreadA = new Thread(start1);
           Thread ThreadB = new Thread(start2);
           Thread ThreadC = new Thread(start1);
           Thread ThreadD = new Thread(start2);
            
            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";
            Console.WriteLine(label1.Text.ToString());

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();
            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();
        
            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());  


         }
    }
}
