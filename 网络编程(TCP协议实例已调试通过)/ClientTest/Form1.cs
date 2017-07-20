using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace ClientTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //初始化委托类型字段
            listAdd = new ListAdd(ListAddStr);
        }

        //定义list写入函数
        private void ListAddStr(string str)
        {
            listBox1.Items.Add(DateTime.Now.ToString()+str);
        }
        //定义客户端、读、写
        BinaryWriter writer=null;
        BinaryReader reader = null;
        TcpClient tcpClient;

        //定义委托，用于多线程在主界面上显示内容
        private delegate void ListAdd(string str);
        private ListAdd listAdd;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //线程开启客户端连接
            Thread t = new Thread(Client);
            t.Start();
        }
        private void Client()
        {
            //通过服务器的ip和端口号，创建TcpClient实例
            IPAddress ip = IPAddress.Parse(txtIP.Text); //IPAddress.Loopback; //IPAddress.Parse("192.168.3.42");
            int port = int.Parse(txtPort.Text);
            tcpClient = new TcpClient();
            tcpClient.Connect(ip, port);

            this.Invoke(listAdd, "正在连接...");
            this.Invoke(listAdd, "连接状态：" + tcpClient.Client.Connected.ToString());
            this.Invoke(listAdd, "本地端口：" + tcpClient.Client.LocalEndPoint.ToString());
            //
            Thread.Sleep(1000);
            //listBox1.Items.Add(tcpClinet.Connected);
            //利用TcpClient对象GetStream方法得到网络流
            NetworkStream networkStream = tcpClient.GetStream();
            reader = new BinaryReader(networkStream);
            writer = new BinaryWriter(networkStream);
            while (true)
            {
                try
                {
                    //从网络流中读取内容
                    this.Invoke(listAdd, reader.ReadString());
                }
                catch
                {
                    this.Invoke(listAdd, "接收错误");
                    break;
                }

            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (writer == null) return;
            writer.Write(textBox1.Text);
            writer.Flush();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIP.Text = "192.168.3.42";
            txtPort.Text = "7890";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (writer != null) writer.Close();
            if (reader != null) reader.Close();
            if (tcpClient != null) tcpClient.Close();
        }
    }
}
