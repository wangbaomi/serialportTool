using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Net.Sockets;
using System.Net;



namespace 串口测试工具
{
    public partial class Form1 : Form
    {
        private static string result_filename = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-result.txt";
        private static FileStream result_file = new FileStream(result_filename, FileMode.Create);//保存自动测试的结果
        private StreamWriter result_sw = new StreamWriter(result_file);

        private void HandleCmd(string cmd)
        {
            //LogHelper.WriteDebug(typeof(MainForm), "接收指令: " + cmd);
            //如果收到USE XML XXX的消息，就加载这个配置文件，并打开串口, 然后发送指令 USE OK
            if (cmd.Contains("USE XML"))
            {
                string file = cmd.Split(default(Char[]), 3, StringSplitOptions.RemoveEmptyEntries)[2];
                result_sw.WriteLine("配置文件：" + file);
                //LoadConfig(file);
                //this.richTextBox2.Text = "USE OK";
                //SendMsgButton_Click(null, null);
            }
            //如果收到USE OK的消息，说明对方已经加载好配置文件，并已经打开了串口；
            //这边就可以发字符串了，然后发送指令 SEND OK
            else if (cmd.Contains("USE OK"))
            {
                //startSendButton_Click(null, null);
                //this.richTextBox2.Text = "SEND OK";
                //SendMsgButton_Click(null, null);
            }
            //如果收到SEND OK消息，说明对方已经发送了字符串，这边可以接收并检查接收的字符串了，
            //然后发送字符串到串口，最后发送 SEND OVER指令，表明双方都发送完毕
            else if (cmd.Contains("SEND OK"))
            {
                //bool ret = check();
                //startSendButton_Click(null, null);
                //this.richTextBox2.Text = "SEND OVER";
                //SendMsgButton_Click(null, null);
            }
            //如果收到 SEND OVER消息，说明己方和对方都已发送了串口消息，一个配置文件测试完毕
            else if (cmd.Contains("SEND OVER"))
            {
                //bool ret = check();
                //this.richTextBox1.Text = ("OVER");
            }
            //自动测试完毕
            else if (cmd.Contains("AutoTest Over"))
            {
                result_sw.Flush();
                result_sw.Close();
                result_file.Close();
            }
            else
            {
                //LogHelper.WriteDebug(typeof(MainForm), "接收指令: " + cmd + ", 非法指令!");
            }

        }
    }
}
