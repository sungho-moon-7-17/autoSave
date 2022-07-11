using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool run = false;
        private void Run()
        {
            while(true)
            {
                if (run)
                    SendKeys.SendWait("^(s)");
                Thread.Sleep(5000);
            }
        }
        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(Run);
            thread.IsBackground = true;
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            run = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            run = true;
        }
    }
}
