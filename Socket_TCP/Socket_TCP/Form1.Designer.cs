namespace Socket_TCP
{
    partial class Socket_TCP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lBoxLog = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnServerPopup = new Button();
            btnClientPopup = new Button();
            button4 = new Button();
            tlpMain = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lBoxLog, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tlpMain, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(997, 703);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lBoxLog
            // 
            lBoxLog.Dock = DockStyle.Fill;
            lBoxLog.FormattingEnabled = true;
            lBoxLog.Location = new Point(3, 3);
            lBoxLog.Name = "lBoxLog";
            lBoxLog.Size = new Size(991, 144);
            lBoxLog.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnServerPopup, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClientPopup, 1, 0);
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 636);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(991, 64);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnServerPopup
            // 
            btnServerPopup.Dock = DockStyle.Fill;
            btnServerPopup.Location = new Point(3, 3);
            btnServerPopup.Name = "btnServerPopup";
            btnServerPopup.Size = new Size(124, 58);
            btnServerPopup.TabIndex = 0;
            btnServerPopup.Text = "Server";
            btnServerPopup.UseVisualStyleBackColor = true;
            btnServerPopup.Click += btnServerPopup_Click;
            // 
            // btnClientPopup
            // 
            btnClientPopup.Dock = DockStyle.Fill;
            btnClientPopup.Location = new Point(133, 3);
            btnClientPopup.Name = "btnClientPopup";
            btnClientPopup.Size = new Size(124, 58);
            btnClientPopup.TabIndex = 1;
            btnClientPopup.Text = "Client";
            btnClientPopup.UseVisualStyleBackColor = true;
            btnClientPopup.Click += btnClientPopup_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(864, 3);
            button4.Name = "button4";
            button4.Size = new Size(124, 58);
            button4.TabIndex = 3;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(3, 153);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(991, 477);
            tlpMain.TabIndex = 2;
            // 
            // Socket_TCP
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 703);
            Controls.Add(tableLayoutPanel1);
            Name = "Socket_TCP";
            Text = "Socket_TCP";
            FormClosed += Socket_TCP_FormClosed;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListBox lBoxLog;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnServerPopup;
        private Button btnClientPopup;
        private TableLayoutPanel tlpMain;
        private Button button4;
    }
}
