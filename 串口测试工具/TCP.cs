using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace 串口测试工具
{
    public partial class Form1 : Form
    {
        private TcpListener local_listener;//监听本地端口
        private TcpClient remoteClient;//用于获取对方发来的消息
        private NetworkStream streamToClient;//用于读取对方发来的消息
        private TcpClient client;//TCP客户端,用于向对方发送消息
        private void StartServer()
        {

            try
            {
                IPAddress.Parse(this.myIP.Text);
                Int32.Parse(this.myPort.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            const int BufferSize = 1024;

            IPAddress ip = IPAddress.Parse(this.myIP.Text);
            Int32 port = Int32.Parse(this.myPort.Text);

            try
            {
                local_listener = new TcpListener(ip, port);
                local_listener.Start();           // 开始侦听
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            this.startListen.Enabled = false;



            // 获取一个连接，中断方法
            remoteClient = local_listener.AcceptTcpClient();

            // 获得流，并写入buffer中
            streamToClient = remoteClient.GetStream();
            try
            {
                do
                {
                    byte[] buffer = new byte[BufferSize];
                    int bytesRead = streamToClient.Read(buffer, 0, BufferSize);

                    // 获得请求的字符串
                    string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                    this.hisMsg.Text = msg;

                    //HandleCmd(msg);
                } while (true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                streamToClient.Close();
                remoteClient.Close();
                local_listener.Stop();
                return;
            }
        }


        private void StartClient()
        {
            try
            {
                IPAddress.Parse(this.hisIP.Text);
                Int32.Parse(this.hisPort.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            if (client == null)
            {
                IPAddress ip = IPAddress.Parse(this.hisIP.Text);
                Int32 port = Int32.Parse(this.hisPort.Text);
                try
                {
                    client = new TcpClient();
                    client.Connect(ip, port);      // 与服务器连接
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            string msg = this.myMsg.Text;
            NetworkStream streamToServer = client.GetStream();
            try
            {
                byte[] buffer = Encoding.Unicode.GetBytes(msg);     // 获得缓存
                streamToServer.Write(buffer, 0, buffer.Length);     // 发往服务器
                //LogHelper.WriteDebug(typeof(MainForm), "发送指令: " + msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                streamToServer.Close();
                client.Close();
                //LogHelper.WriteDebug(typeof(MainForm), "发送指令: " + msg + " fail, error = " + ex.Message);
                return;
            }

        }

        
    }
}