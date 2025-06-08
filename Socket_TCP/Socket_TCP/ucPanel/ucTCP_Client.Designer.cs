namespace Socket_TCP.ucPanel
{
    partial class ucTCP_Client
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
            tBoxClientSend = new TextBox();
            btnClientSend = new Button();
            lBoxClientChat = new ListBox();
            btnClientConnection = new Button();
            tBoxClientPort = new TextBox();
            lblPort = new Label();
            tBoxClientIP = new TextBox();
            lblIPAddress = new Label();
            SuspendLayout();
            // 
            // tBoxClientSend
            // 
            tBoxClientSend.Location = new Point(6, 440);
            tBoxClientSend.Name = "tBoxClientSend";
            tBoxClientSend.Size = new Size(884, 27);
            tBoxClientSend.TabIndex = 18;
            // 
            // btnClientSend
            // 
            btnClientSend.BackColor = Color.MediumSlateBlue;
            btnClientSend.FlatAppearance.BorderColor = Color.White;
            btnClientSend.FlatAppearance.BorderSize = 3;
            btnClientSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnClientSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnClientSend.ForeColor = SystemColors.ButtonFace;
            btnClientSend.Location = new Point(896, 439);
            btnClientSend.Name = "btnClientSend";
            btnClientSend.Size = new Size(92, 30);
            btnClientSend.TabIndex = 17;
            btnClientSend.Text = "Send";
            btnClientSend.UseVisualStyleBackColor = false;
            btnClientSend.Click += btnSend_Click;
            // 
            // lBoxClientChat
            // 
            lBoxClientChat.FormattingEnabled = true;
            lBoxClientChat.Location = new Point(6, 56);
            lBoxClientChat.Name = "lBoxClientChat";
            lBoxClientChat.Size = new Size(985, 364);
            lBoxClientChat.TabIndex = 16;
            // 
            // btnClientConnection
            // 
            btnClientConnection.Location = new Point(834, 3);
            btnClientConnection.Name = "btnClientConnection";
            btnClientConnection.Size = new Size(154, 47);
            btnClientConnection.TabIndex = 15;
            btnClientConnection.Text = "Connection";
            btnClientConnection.UseVisualStyleBackColor = true;
            btnClientConnection.Click += btnConnection_Click;
            // 
            // tBoxClientPort
            // 
            tBoxClientPort.Location = new Point(461, 17);
            tBoxClientPort.Name = "tBoxClientPort";
            tBoxClientPort.Size = new Size(79, 27);
            tBoxClientPort.TabIndex = 14;
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
            // tBoxClientIP
            // 
            tBoxClientIP.Location = new Point(104, 17);
            tBoxClientIP.Name = "tBoxClientIP";
            tBoxClientIP.Size = new Size(239, 27);
            tBoxClientIP.TabIndex = 12;
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
            // ucTCP_Client
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            Controls.Add(tBoxClientSend);
            Controls.Add(btnClientSend);
            Controls.Add(lBoxClientChat);
            Controls.Add(btnClientConnection);
            Controls.Add(tBoxClientPort);
            Controls.Add(lblPort);
            Controls.Add(tBoxClientIP);
            Controls.Add(lblIPAddress);
            Name = "ucTCP_Client";
            Size = new Size(991, 477);
            Load += ucTCP_Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxClientSend;
        private Button btnClientSend;
        private ListBox lBoxClientChat;
        private Button btnClientConnection;
        private TextBox tBoxClientPort;
        private Label lblPort;
        private TextBox tBoxClientIP;
        private Label lblIPAddress;
    }
}
