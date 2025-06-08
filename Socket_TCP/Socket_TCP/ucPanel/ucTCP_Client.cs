using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_TCP.ucPanel
{
    public partial class ucTCP_Client : UserControl
    {
        public ucTCP_Client()
        {
            InitializeComponent();
        }

        StreamReader streamReader = null;
        StreamWriter streamWriter = null;
        Thread ConnectionThread = null;
        TcpClient tcpClient = null;

        private void ucTCP_Client_Load(object sender, EventArgs e)
        {
            /// 나중에 지울것
            string strIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            tBoxClientIP.Text = strIP.ToString();
            tBoxClientPort.Text = "5000";
            /// 나중에 지울것

            IPAddress address;
            string sIP = tBoxClientIP.Text;
            int DotCnt = strIP.Count(c => c == '.');
            int portnum;
            bool bResult = strIP != null && DotCnt == 3 && IPAddress.TryParse(strIP, out address) && int.TryParse(tBoxClientPort.Text, out portnum);

            if (!bResult)
            {
                btnClientConnection.BackColor = Color.Gray;
                btnClientConnection.Enabled = false;
            }
            else
            {
                btnClientConnection.BackColor = Color.White;
                btnClientConnection.Enabled = true;
            }

            var vIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            tBoxClientIP.Text = vIP.ToString();

            SetConnectionUnabled();
            SetSendUnabled();
        }



        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (btnClientConnection.Text == "Connection")
            {
                ConnectionThread = new Thread(FuncConnect); // Thread 객체 생성, Form 과 별도 Thread 에서 FuncConnect 함수 실행됨.
                ConnectionThread.IsBackground = true;  // Form이 종료되면 thread1 도 종료
                ConnectionThread.Start();
            }
            else if (btnClientConnection.Text == "Disconnection")
            {
                string strSendData = "";
                if (tcpClient.Connected)
                {
                    strSendData = "Disconnection";
                    streamWriter.WriteLine(strSendData);
                }

                writeRichTextBox("Server : " + strSendData); // 데이터를 수신창에 쓰기
                tcpClient.Dispose();

                SetConnectionUnabled();
                SetSendUnabled();
            }
        }
        private void FuncConnect()  // Thread1에 연결됨 함수. 메인 Form 과는 별도로 동작한다
        {
            tcpClient = new TcpClient(tBoxClientIP.Text, int.Parse(tBoxClientPort.Text));


            streamReader = new StreamReader(tcpClient.GetStream());   // 읽기 스트림 연결
            streamWriter = new StreamWriter(tcpClient.GetStream());   // 쓰기 스트림 연결
            streamWriter.AutoFlush = true; // 쓰기 버퍼 뭔가 자동으로 처리

            writeRichTextBox("Server connection success");

            SetConnectionEnabled();
            SetSendEnabled();

            string receiveData = "";
            try
            {
                while (tcpClient.Connected)
                {
                    receiveData = streamReader.ReadLine();    // 수신 데이터를 읽어서 receiveData1 변수에 저장
                    if (receiveData == "Disconnection")
                    {
                        streamReader.Close();
                        streamWriter.Close();
                        tcpClient.Dispose();

                        SetConnectionUnabled();
                        SetSendUnabled();
                    }
                    if (receiveData != null && receiveData != "") writeRichTextBox("Server : " + receiveData);
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
            lBoxClientChat.Invoke((MethodInvoker)delegate { lBoxClientChat.Items.Add("[" + dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] : " + text); });
            lBoxClientChat.Invoke((MethodInvoker)delegate { lBoxClientChat.SetSelected(lBoxClientChat.Items.Count - 1, true); });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string strSendData = tBoxClientSend.Text;
            streamWriter.WriteLine(strSendData);

            writeRichTextBox("Client : " + strSendData); // 데이터를 수신창에 쓰기
        }

        #region 컨트롤 컨트롤
        private void SetSendEnabled()
        {
            btnClientSend.Invoke(new Action(() => { btnClientSend.Enabled = true; }));
            btnClientSend.Invoke(new Action(() => { btnClientSend.BackColor = Color.FromArgb(123, 104, 238); }));
            btnClientSend.Invoke(new Action(() => { btnClientSend.ForeColor = Color.White; }));
        }
        private void SetSendUnabled()
        {
            btnClientSend.Invoke(new Action(() => { btnClientSend.Enabled = false; }));
            btnClientSend.BackColor = Color.Gray;
            btnClientSend.ForeColor = Color.Black;
        }
        private void SetConnectionUnabled()
        {
            btnClientConnection.Invoke(new Action(() => { btnClientConnection.Text = "Connection"; }));
            btnClientConnection.BackColor = Color.FromArgb(180, 0, 0);
            btnClientConnection.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void SetConnectionEnabled()
        {
            btnClientConnection.Invoke(new Action(() => { btnClientConnection.Text = "Disconnection"; }));
            btnClientConnection.BackColor = Color.FromArgb(0, 255, 0);
            btnClientConnection.ForeColor = Color.FromArgb(0, 0, 0);
        }
        #endregion

        public void ShotDown()
        {
            if (tcpClient.Connected)
            {
                streamReader.Close();
                streamWriter.Close();
                tcpClient.Dispose();

                SetConnectionUnabled();
                SetSendUnabled();
            }
        }
    }
}
