namespace StopwatchTimer
{
    partial class StopwatchTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopwatchTimer));
            tableLayoutPanel2 = new TableLayoutPanel();
            pBoxStart = new PictureBox();
            pBoxReset = new PictureBox();
            pBoxFlag = new PictureBox();
            lblTime = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lViewRecord = new ListView();
            chNum = new ColumnHeader();
            chForS = new ColumnHeader();
            chSpan = new ColumnHeader();
            chTotal = new ColumnHeader();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxFlag).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.949028F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.05098438F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.05098438F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.94901F));
            tableLayoutPanel2.Controls.Add(pBoxStart, 1, 0);
            tableLayoutPanel2.Controls.Add(pBoxReset, 5, 0);
            tableLayoutPanel2.Controls.Add(pBoxFlag, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(162, 256);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.Size = new Size(793, 73);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // pBoxStart
            // 
            pBoxStart.Image = (Image)resources.GetObject("pBoxStart.Image");
            pBoxStart.Location = new Point(247, 0);
            pBoxStart.Margin = new Padding(0);
            pBoxStart.Name = "pBoxStart";
            pBoxStart.Size = new Size(72, 72);
            pBoxStart.TabIndex = 18;
            pBoxStart.TabStop = false;
            pBoxStart.Click += pBoxStart_Click;
            // 
            // pBoxReset
            // 
            pBoxReset.Image = (Image)resources.GetObject("pBoxReset.Image");
            pBoxReset.Location = new Point(471, 0);
            pBoxReset.Margin = new Padding(0);
            pBoxReset.Name = "pBoxReset";
            pBoxReset.Size = new Size(72, 72);
            pBoxReset.TabIndex = 20;
            pBoxReset.TabStop = false;
            pBoxReset.Click += pBoxReset_Click;
            // 
            // pBoxFlag
            // 
            pBoxFlag.Enabled = false;
            pBoxFlag.Image = (Image)resources.GetObject("pBoxFlag.Image");
            pBoxFlag.Location = new Point(359, 0);
            pBoxFlag.Margin = new Padding(0);
            pBoxFlag.Name = "pBoxFlag";
            pBoxFlag.Size = new Size(72, 72);
            pBoxFlag.TabIndex = 21;
            pBoxFlag.TabStop = false;
            pBoxFlag.Click += pBoxFlag_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Dock = DockStyle.Bottom;
            lblTime.Font = new Font("Microsoft YaHei UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = SystemColors.WindowFrame;
            lblTime.Location = new Point(162, 97);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(793, 156);
            lblTime.TabIndex = 8;
            lblTime.Text = "00:00:00.0";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 799F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTime, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 700F));
            tableLayoutPanel1.Size = new Size(1117, 1122);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(label3, 2, 0);
            tableLayoutPanel3.Controls.Add(label2, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(162, 335);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(793, 63);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft YaHei UI", 12F);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(531, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 63);
            label3.TabIndex = 2;
            label3.Text = "Total";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(267, 0);
            label2.Name = "label2";
            label2.Size = new Size(258, 63);
            label2.TabIndex = 1;
            label2.Text = "Time";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 63);
            label1.TabIndex = 0;
            label1.Text = "Laps";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(159, 407);
            label4.Margin = new Padding(0, 6, 0, 13);
            label4.Name = "label4";
            label4.Size = new Size(799, 2);
            label4.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(lViewRecord, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(162, 425);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(793, 694);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // lViewRecord
            // 
            lViewRecord.Activation = ItemActivation.TwoClick;
            lViewRecord.Alignment = ListViewAlignment.Default;
            lViewRecord.BorderStyle = BorderStyle.None;
            lViewRecord.Columns.AddRange(new ColumnHeader[] { chNum, chForS, chSpan, chTotal });
            tableLayoutPanel4.SetColumnSpan(lViewRecord, 50);
            lViewRecord.Dock = DockStyle.Fill;
            lViewRecord.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lViewRecord.HeaderStyle = ColumnHeaderStyle.None;
            lViewRecord.HideSelection = true;
            lViewRecord.Location = new Point(0, 0);
            lViewRecord.Margin = new Padding(0);
            lViewRecord.MultiSelect = false;
            lViewRecord.Name = "lViewRecord";
            tableLayoutPanel4.SetRowSpan(lViewRecord, 50);
            lViewRecord.Size = new Size(793, 694);
            lViewRecord.TabIndex = 13;
            lViewRecord.TabStop = false;
            lViewRecord.UseCompatibleStateImageBehavior = false;
            lViewRecord.View = View.Details;
            // 
            // chNum
            // 
            chNum.Text = "";
            chNum.Width = 45;
            // 
            // chForS
            // 
            chForS.Text = "";
            chForS.Width = 220;
            // 
            // chSpan
            // 
            chSpan.Text = "";
            chSpan.Width = 260;
            // 
            // chTotal
            // 
            chTotal.Text = "";
            chTotal.Width = 260;
            // 
            // StopwatchTimer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1117, 1122);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "StopwatchTimer";
            Text = "StopwatchTimer";
            Load += StopwatchTimer_Load;
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxFlag).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTime;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private PictureBox pBoxStart;
        private PictureBox pBoxReset;
        private PictureBox pBoxFlag;
        private TableLayoutPanel tableLayoutPanel4;
        private ListView lViewRecord;
        private ColumnHeader chNum;
        private ColumnHeader chForS;
        private ColumnHeader chSpan;
        private ColumnHeader chTotal;
    }
}
