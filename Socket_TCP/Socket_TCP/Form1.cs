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
using System.IO;
using System.Net.Sockets;
using System.Collections;
using Socket_TCP.ucPanel;

namespace Socket_TCP
{
    public partial class Socket_TCP : Form
    {
        ucPanel.ucTCP_Client ucClient = new ucPanel.ucTCP_Client();
        ucPanel.ucTCP_Server ucServer = new ucPanel.ucTCP_Server();
        int iCurrentControl = 0;

        public Socket_TCP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnServerPopup_Click(object sender, EventArgs e)
        {
            tlpMain.Controls.Clear();
            tlpMain.Controls.Add(ucServer);
            LogPrint(" : Server Selected");
            iCurrentControl = 1; 
        }

        private void btnClientPopup_Click(object sender, EventArgs e)
        {
            tlpMain.Controls.Clear();
            tlpMain.Controls.Add(ucClient);
            LogPrint(" : Client Selected");
            iCurrentControl = 2;
        }

        private void LogPrint(string strLogMsg)
        {
            DateTime dTime = DateTime.Now;
            lBoxLog.Items.Add(dTime.ToString("[yyyy-MM-dd hh:mm:ss]") + strLogMsg);
            lBoxLog.SetSelected(lBoxLog.Items.Count - 1, true);
        }

        private void Socket_TCP_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (iCurrentControl == 1)
            {
                ucTCP_Server ucServer = new ucTCP_Server();
                ucServer.ShotDown();
            }
            else if (iCurrentControl == 2)
            {
                ucTCP_Client ucClient = new ucTCP_Client();
                ucClient.ShotDown();
            }
        }
    }
}
