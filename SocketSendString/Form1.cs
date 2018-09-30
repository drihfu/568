using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SocketSendString
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBoxIp.Text = "10.2.3.102";
            textBoxPort.Text= 9100.ToString();

        }

        private void button_Click_SendTxt(object sender, EventArgs e)
        {
            //读取txt文件内容
            String stringTxtContent = textBoxShowTxtContent.Text;
            byte[] buffer = new byte[2048];
            buffer = Encoding.Default.GetBytes(stringTxtContent);

            //判断输入的IP和PORT是否符合格式（IP使用正则表达式判断）
            if (Regex.IsMatch(textBoxIp.Text,
                @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$"))
            {
                if (Convert.ToInt32(textBoxPort.Text) < 66536)
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);

                    //将string转成ip及port类型
                    socket.Connect(IPAddress.Parse(textBoxIp.Text),
                        Convert.ToInt32(textBoxPort.Text));

                    socket.Send(buffer);
                    socket.Close();
                    MessageBox.Show("发送完毕");
                }
                else {
                    MessageBox.Show("port超出范围");
                }
            }
            else {
                MessageBox.Show("IP格式错误");
            }

            
        }

        private void button_Click_ChoseFile(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog(); //定义打开文件   
            //初始路径,这里设置的是程序的起始位置，可自由设置            
            filename.InitialDirectory = Application.StartupPath;

            //设置打开类型,设置个*.*和*.txt就行了            
            filename.Filter = "All files(*.*)|*.*|txt files(*.txt)|*.txt";
            
            //文件类型的显示顺序（上一行.txt设为第二位）            
            filename.FilterIndex = 2;
            filename.RestoreDirectory = true; //对话框记忆之前打开的目录
            if (filename.ShowDialog() == DialogResult.OK){

                //获得完整路径在textBox1中显示
                textBoxFilePath.Text = filename.FileName.ToString();

                //将选中的文件在textBox2中显示
                StreamReader sr = new StreamReader(filename.FileName,Encoding.UTF8);
                textBoxShowTxtContent.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}
