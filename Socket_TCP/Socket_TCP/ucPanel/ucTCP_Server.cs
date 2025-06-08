using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_TCP.ucPanel
{
    public partial class ucTCP_Server : UserControl
    {
        public ucTCP_Server()
        {
            InitializeComponent();
        }

        StreamReader streamReader = null;
        StreamWriter streamWriter = null;
        Thread ConnectionThread = null;
        TcpClient tcpClient = null;
        TcpListener tcpListener = null;
        bool bIsFirstTime = true;

        private void ucTCP_Server_Load(object sender, EventArgs e)
        {
            /// 나중에 지울것
            string strIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            tBoxServerIP.Text = strIP.ToString();
            tBoxServerPort.Text = "5000";
            /// 나중에 지울것

            IPAddress address;
            string sIP = tBoxServerIP.Text;
            int DotCnt = strIP.Count(c => c == '.');
            int portnum;
            bool bResult = strIP != null && DotCnt == 3 && IPAddress.TryParse(strIP, out address) && int.TryParse(tBoxServerPort.Text, out portnum);

            if (!bResult)
            {
                btnServerConnection.BackColor = Color.Gray;
                btnServerConnection.Enabled = false;
            }
            else
            {
                btnServerConnection.BackColor = Color.White;
                btnServerConnection.Enabled = true;
            }


            var vIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            tBoxServerIP.Text = vIP.ToString();

            SetConnectionUnabled();
            SetSendUnabled();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (btnServerConnection.Text == "Connection")
            {
                ConnectionThread = new Thread(FuncConnect); // Thread 객체 생성, Form 과 별도 Thread 에서 FuncConnect 함수 실행됨.
                ConnectionThread.IsBackground = true;  // Form이 종료되면 thread1 도 종료
                ConnectionThread.Start();
            }
            else if (btnServerConnection.Text == "Disconnection")
            {
                string strSendData = "";
                if (tcpClient.Connected)
                {
                    strSendData = "Disconnection";
                    streamWriter.WriteLine(strSendData);
                }

                writeRichTextBox("Server : " + strSendData); // 데이터를 수신창에 쓰기
                tcpClient.Dispose();
                tcpListener.Dispose();

                SetConnectionUnabled();
                SetSendUnabled();
            }
        }

        private void FuncConnect()
        {
            if (bIsFirstTime)
            {
                tcpListener = new TcpListener(IPAddress.Parse(tBoxServerIP.Text), int.Parse(tBoxServerPort.Text)); // 서버 객체 생성 및 IP 주소와 Port 넘버 할당
                tcpListener.Start();  // 1. 서버 시작

                writeRichTextBox("Server is ready, waiting for client...");

                // listen accept
                tcpClient = tcpListener.AcceptTcpClient();  // 3. Client 접속 확인

                // Recv / Send
                streamReader = new StreamReader(tcpClient.GetStream());     // 읽기 스트림 연결
                streamWriter = new StreamWriter(tcpClient.GetStream());     // 쓰기 스트림 연결
                streamWriter.AutoFlush = true; // 쓰기 버퍼 뭔가 자동으로 처리

                writeRichTextBox("Client connection success");

                SetConnectionEnabled();
                SetSendEnabled();
                bIsFirstTime = false;
            }

            string receiveData = "";
            try
            {
                while (tcpClient.Connected)
                {
                    receiveData = streamReader.ReadLine();           // 수신 데이터를 읽어서 receiveData1 변수에 저장
                    if (receiveData == "Disconnection")
                    {
                        streamReader.Close();
                        streamWriter.Close();
                        tcpClient.Dispose();
                        tcpListener.Dispose();

                        SetConnectionUnabled();
                        SetSendUnabled();
                    }
                    if (receiveData != null && receiveData != "") writeRichTextBox("Client : " + receiveData);

                }
            }
            catch (Exception e)
            {
                writeRichTextBox("Disconnectioned");
                SetConnectionUnabled();
                MessageBox.Show(e.Message);
            }
        }

        private void writeRichTextBox(string text)
        {
            DateTime dateTime = DateTime.Now;
            lBoxServerChat.Invoke((MethodInvoker)delegate { lBoxServerChat.Items.Add("[" + dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] : " + text); });
            lBoxServerChat.Invoke((MethodInvoker)delegate { lBoxServerChat.SetSelected(lBoxServerChat.Items.Count - 1, true); });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string strSendData = tBoxServerSend.Text;
            streamWriter.WriteLine(strSendData);
            writeRichTextBox("Server : " + strSendData); // 데이터를 수신창에 쓰기
        }

        private void FuncHeartBit()
        {

        }

        #region 컨트롤 컨트롤
        private void SetSendEnabled()
        {
            btnServerSend.Invoke(new Action(() => { btnServerSend.Enabled = true; }));
            btnServerSend.Invoke(new Action(() => { btnServerSend.BackColor = Color.FromArgb(123, 104, 238); }));
            btnServerSend.Invoke(new Action(() => { btnServerSend.ForeColor = Color.White; }));
        }

        private void SetSendUnabled()
        {
            btnServerSend.Invoke(new Action(() => { btnServerSend.Enabled = false; }));
            btnServerSend.BackColor = Color.Gray;
            btnServerSend.ForeColor = Color.Black;
        }

        private void SetConnectionUnabled()
        {
            btnServerConnection.Invoke(new Action(() => { btnServerConnection.Text = "Connection"; }));
            btnServerConnection.BackColor = Color.FromArgb(180, 0, 0);
            btnServerConnection.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void SetConnectionEnabled()
        {
            btnServerConnection.Invoke(new Action(() => { btnServerConnection.Text = "Disconnection"; }));
            btnServerConnection.BackColor = Color.FromArgb(0, 255, 0);
            btnServerConnection.ForeColor = Color.FromArgb(0, 0, 0);
        }
        #endregion

        public void ShotDown()
        {
            if (tcpClient.Connected)
            {
                streamReader.Close();
                streamWriter.Close();
                tcpClient.Dispose();
                tcpListener.Dispose();

                SetConnectionUnabled();
                SetSendUnabled();
            }
        }

        private void ucTCP_Server_ControlRemoved(object sender, ControlEventArgs e)
        {

        }
    }
}
