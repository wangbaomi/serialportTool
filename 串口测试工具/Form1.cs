using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 串口测试工具
{
    public partial class Form1 : Form
    {
        private Thread listen_thread;//监听线程
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void startListen_Click(object sender, EventArgs e)
        {
            this.hisMsg.Clear();
            if (listen_thread != null && listen_thread.ThreadState == ThreadState.Running)
            {
                MessageBox.Show("已经在监听中...");
                return;
            }
            try
            {
                listen_thread = new Thread(new ThreadStart(StartServer));
                listen_thread.Start();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
