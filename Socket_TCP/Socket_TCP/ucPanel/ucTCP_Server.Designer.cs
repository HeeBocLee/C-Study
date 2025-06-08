namespace Socket_TCP.ucPanel
{
    partial class ucTCP_Server
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog1 = new ColorDialog();
            btnServerSend = new Button();
            tBoxServerSend = new TextBox();
            lBoxServerChat = new ListBox();
            btnServerConnection = new Button();
            tBoxServerPort = new TextBox();
            lblPort = new Label();
            tBoxServerIP = new TextBox();
            lblIPAddress = new Label();
            SuspendLayout();
            // 
            // btnServerSend
            // 
            btnServerSend.BackColor = Color.MediumSlateBlue;
            btnServerSend.FlatAppearance.BorderColor = Color.White;
            btnServerSend.FlatAppearance.BorderSize = 3;
            btnServerSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnServerSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnServerSend.ForeColor = SystemColors.ButtonFace;
            btnServerSend.Location = new Point(896, 438);
            btnServerSend.Name = "btnServerSend";
            btnServerSend.Size = new Size(92, 30);
            btnServerSend.TabIndex = 17;
            btnServerSend.Text = "Send";
            btnServerSend.UseVisualStyleBackColor = false;
            btnServerSend.Click += btnSend_Click;
            // 
            // tBoxServerSend
            // 
            tBoxServerSend.Location = new Point(6, 439);
            tBoxServerSend.Name = "tBoxServerSend";
            tBoxServerSend.Size = new Size(884, 27);
            tBoxServerSend.TabIndex = 18;
            // 
            // lBoxServerChat
            // 
            lBoxServerChat.FormattingEnabled = true;
            lBoxServerChat.Location = new Point(6, 56);
            lBoxServerChat.Name = "lBoxServerChat";
            lBoxServerChat.Size = new Size(985, 364);
            lBoxServerChat.TabIndex = 16;
            // 
            // btnServerConnection
            // 
            btnServerConnection.Location = new Point(834, 3);
            btnServerConnection.Name = "btnServerConnection";
            btnServerConnection.Size = new Size(154, 47);
            btnServerConnection.TabIndex = 15;
            btnServerConnection.Text = "Connection";
            btnServerConnection.UseVisualStyleBackColor = true;
            btnServerConnection.Click += btnConnection_Click;
            // 
            // tBoxServerPort
            // 
            tBoxServerPort.Location = new Point(461, 17);
            tBoxServerPort.Name = "tBoxServerPort";
            tBoxServerPort.Size = new Size(79, 27);
            tBoxServerPort.TabIndex = 14;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(376, 20);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(79, 20);
            lblPort.TabIndex = 13;
            lblPort.Text = "Port Num";
            // 
            // tBoxServerIP
            // 
            tBoxServerIP.Location = new Point(104, 17);
            tBoxServerIP.Name = "tBoxServerIP";
            tBoxServerIP.Size = new Size(239, 27);
            tBoxServerIP.TabIndex = 12;
            // 
            // lblIPAddress
            // 
            lblIPAddress.AutoSize = true;
            lblIPAddress.Location = new Point(12, 20);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(86, 20);
            lblIPAddress.TabIndex = 11;
            lblIPAddress.Text = "IP Address";
            // 
            // ucTCP_Server
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(tBoxServerSend);
            Controls.Add(btnServerSend);
            Controls.Add(lBoxServerChat);
            Controls.Add(btnServerConnection);
            Controls.Add(tBoxServerPort);
            Controls.Add(lblPort);
            Controls.Add(tBoxServerIP);
            Controls.Add(lblIPAddress);
            Name = "ucTCP_Server";
            Size = new Size(991, 477);
            Load += ucTCP_Server_Load;
            ControlRemoved += ucTCP_Server_ControlRemoved;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button btnServerSend;
        private TextBox tBoxServerSend;
        private ListBox lBoxServerChat;
        private Button btnServerConnection;
        private TextBox tBoxServerPort;
        private Label lblPort;
        private TextBox tBoxServerIP;
        private Label lblIPAddress;
    }
}
