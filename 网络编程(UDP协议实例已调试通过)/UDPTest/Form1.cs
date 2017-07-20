using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UDPTest
{
    public partial class Form1 : Form
    {
       //定义接收和发送端
        private UdpClient sendUdpClient;
        private UdpClient ReceiveUdpClient;
        public Form1()
        {
            InitializeComponent();
        }
        //使用委托
        private delegate void ListAdd(string str);
        private ListAdd listAdd;

        private void ListAddStr(string str)
        {
            listBox1.Items.Add(str);
            //总是显示最后添加的行
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listAdd = new ListAdd(ListAddStr);
            IPAddress[] ips=Dns.GetHostAddresses("");
            int port = 51883;

            txtLocalIP.Text=ips[3].ToString();
            txtLocalPort.Text = port.ToString();
            txtRemoteIP.Text = ips[3].ToString();
            txtRemotePort.Text = port.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                //实名发送，如果接收套接字使用了此端口，就会报错
                IPAddress localIp = IPAddress.Parse(txtLocalIP.Text);
                int localPort = int.Parse(txtLocalPort.Text);
                IPEndPoint localIpEndPoint = new IPEndPoint(localIp, localPort);
                sendUdpClient = new UdpClient(localIpEndPoint);
            }
            else
            {
                //匿名发送
                sendUdpClient = new UdpClient(0);
            }
            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(txtSend.Text);
        }

        //发送字节信息
        private void SendMessage(object obj)
        {
            string message = (string)obj;
            byte[] sendbytes = Encoding.Unicode.GetBytes(message);
            IPAddress remoteIp = IPAddress.Parse(txtRemoteIP.Text);
            int remotePort = int.Parse(txtRemotePort.Text);
            IPEndPoint remoteIpEndPoint = new IPEndPoint(remoteIp,remotePort);
            sendUdpClient.Send(sendbytes, sendbytes.Length, remoteIpEndPoint);
            sendUdpClient.Close();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            // 创建接收套接字  
            IPAddress localIP = IPAddress.Parse(txtLocalIP.Text);
            int localPort = int.Parse(txtLocalPort.Text);
            IPEndPoint localIPEndPoint = new IPEndPoint(localIP,localPort);
            ReceiveUdpClient = new UdpClient(localIPEndPoint);
            Thread receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();
        }

        // 接受消息    
        private void ReceiveMessage()
        {
            IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any,0);
            while (true)
            {
                try
                {
                    // 关闭receiveUdpClient时此时会产生异常
                    byte[] receiveBytes = ReceiveUdpClient.Receive(ref remoteIPEndPoint);
                    string message = Encoding.Unicode.GetString(receiveBytes);
                    // 显示消息内容    
                    this.Invoke(listAdd,string.Format("{0}  {1}",remoteIPEndPoint,message));
                }
                catch 
                {
                    break;
                }
            
            
            }
        
            
        }
    }
}
