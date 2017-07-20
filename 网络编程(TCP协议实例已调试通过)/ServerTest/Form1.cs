using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace ServerTest
{
    public partial class Form1 : Form
    {
        //定义客户端，服务器，读，写
        TcpListener tcpListener;
        TcpClient tcpClient; 
        BinaryReader reader;
        BinaryWriter writer;

        //定义委托，声明委托字段
        private  delegate void LabelAdd(string str);
        private LabelAdd labeladd;

        private delegate void ListAdd(string str);
        private ListAdd listadd;
        
        public void labeladdstr(string str) {
            //this.label1.Text = str;
        }

        private void ListAddstr(string str)
        {
            listBox1.Items.Add(DateTime.Now.ToString()+" "+str);
        }
        public Form1()
        {
            InitializeComponent();
            //初始化委托字段
            labeladd = new LabelAdd(labeladdstr);
            listadd = new ListAdd(ListAddstr);
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtIP.Text == string.Empty) return;
            if (txtPort.Text == string.Empty) return;

            //单独创建一个线程，避免界面卡死
            Thread t = new Thread(Server);
            t.Start();
        }
        private void Server()
        {
            //设置服务器IP和端口
            IPAddress ip = IPAddress.Parse(txtIP.Text);//Loopback;
            int port = int.Parse(txtPort.Text);
          
            //创建TcpListener实例
            tcpListener = new TcpListener(ip, port);
            tcpListener.Start();

            //label1.Invoke(labeladd,"start...");
            this.Invoke(listadd, "server start...");
            Thread.Sleep(1000);
            //等待客户端连接,应该是这里比较卡，所以选用多线程
            tcpClient = tcpListener.AcceptTcpClient();
            
            this.Invoke(listadd, "client connected...");
            this.Invoke(listadd, "远程端口："+tcpClient.Client.RemoteEndPoint.ToString());
            //this.Invoke(listadd, tcpClient.Connected);
            //this.Invoke(listadd, tcpClient.Client); 
            //利用TcpClient对象GetStream方法得到网络流

            NetworkStream networkStream = tcpClient.GetStream();
            reader = new BinaryReader(networkStream);
            writer = new BinaryWriter(networkStream);
            while (true)
            {
                try
                {
                    this.Invoke(listadd, reader.ReadString());
                    // label1.Invoke(labeladd, reader.ReadString());
                    //Thread t2 = new Thread(() => listBox1.Items.Add(reader.ReadString()));
                }
                catch
                {
                    this.Invoke(listadd, "error");
                    break;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtIP.Text = "192.168.3.42";
            txtPort.Text = "7890";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //利用TcpClient对象GetStream方法得到网络流
            writer.Write(textBox1.Text);
        }

        //停止服务
        private void btnStop_Click(object sender, EventArgs e)
        {
            if(writer!=null) writer.Close();
            if(reader!=null) reader.Close();
            if(tcpClient!=null) tcpClient.Close();
        }

        //关闭窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
