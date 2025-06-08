namespace TextFileRead
{
    partial class Form1
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
            btnINSP = new Button();
            lViewOutInsp = new ListView();
            lViewNum = new ColumnHeader();
            lViewPanelID = new ColumnHeader();
            iViewFlim = new ColumnHeader();
            lViewSpecOut = new ColumnHeader();
            lViewOutMain = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button3 = new Button();
            lViewOutPre = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            tBoxInspDir = new TextBox();
            tBoxMainDir = new TextBox();
            btnMainDir = new Button();
            tBoxMainNGCnt = new TextBox();
            lblMainNGCnt = new Label();
            btnInspDir = new Button();
            label1 = new Label();
            tBoxInspNGCnt = new TextBox();
            label2 = new Label();
            tBoxPreNGCnt = new TextBox();
            btnPreDir = new Button();
            SuspendLayout();
            // 
            // btnINSP
            // 
            btnINSP.Font = new Font("Arial", 12F);
            btnINSP.Location = new Point(720, 56);
            btnINSP.Name = "btnINSP";
            btnINSP.Size = new Size(164, 39);
            btnINSP.TabIndex = 0;
            btnINSP.Text = "INSPECTION";
            btnINSP.UseVisualStyleBackColor = true;
            // 
            // lViewOutInsp
            // 
            lViewOutInsp.Columns.AddRange(new ColumnHeader[] { lViewNum, lViewPanelID, iViewFlim, lViewSpecOut });
            lViewOutInsp.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 10);
            lViewOutInsp.FullRowSelect = true;
            lViewOutInsp.Location = new Point(12, 45);
            lViewOutInsp.Name = "lViewOutInsp";
            lViewOutInsp.Size = new Size(1105, 596);
            lViewOutInsp.TabIndex = 2;
            lViewOutInsp.UseCompatibleStateImageBehavior = false;
            lViewOutInsp.View = View.Details;
            // 
            // lViewNum
            // 
            lViewNum.Text = "No";
            lViewNum.Width = 40;
            // 
            // lViewPanelID
            // 
            lViewPanelID.Text = "PanelID";
            lViewPanelID.Width = 200;
            // 
            // iViewFlim
            // 
            iViewFlim.Text = "FlimID";
            iViewFlim.Width = 130;
            // 
            // lViewSpecOut
            // 
            lViewSpecOut.Text = "Spec Out";
            lViewSpecOut.Width = 700;
            // 
            // lViewOutMain
            // 
            lViewOutMain.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lViewOutMain.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 10);
            lViewOutMain.FullRowSelect = true;
            lViewOutMain.Location = new Point(1139, 45);
            lViewOutMain.Name = "lViewOutMain";
            lViewOutMain.Size = new Size(1105, 596);
            lViewOutMain.TabIndex = 3;
            lViewOutMain.UseCompatibleStateImageBehavior = false;
            lViewOutMain.View = View.Details;
            lViewOutMain.SelectedIndexChanged += lViewOutMain_SelectedIndexChanged;
            lViewOutMain.KeyDown += lViewOutMain_KeyDown;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PanelID";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "FlimID";
            columnHeader3.Width = 1;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Spec Out";
            columnHeader4.Width = 900;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 10);
            listView2.FullRowSelect = true;
            listView2.Location = new Point(1139, 685);
            listView2.Name = "listView2";
            listView2.Size = new Size(1105, 596);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "No";
            columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "PanelID";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "FlimID";
            columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Spec Out";
            columnHeader8.Width = 700;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 12F);
            button3.Location = new Point(1139, 643);
            button3.Name = "button3";
            button3.Size = new Size(164, 39);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // lViewOutPre
            // 
            lViewOutPre.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            lViewOutPre.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 10);
            lViewOutPre.FullRowSelect = true;
            lViewOutPre.Location = new Point(12, 685);
            lViewOutPre.Name = "lViewOutPre";
            lViewOutPre.Size = new Size(1105, 596);
            lViewOutPre.TabIndex = 7;
            lViewOutPre.UseCompatibleStateImageBehavior = false;
            lViewOutPre.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "No";
            columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "PanelID";
            columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "FlimID";
            columnHeader11.Width = 130;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Spec Out";
            columnHeader12.Width = 700;
            // 
            // tBoxInspDir
            // 
            tBoxInspDir.BackColor = SystemColors.Window;
            tBoxInspDir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tBoxInspDir.Location = new Point(12, 8);
            tBoxInspDir.Name = "tBoxInspDir";
            tBoxInspDir.Size = new Size(671, 30);
            tBoxInspDir.TabIndex = 8;
            // 
            // tBoxMainDir
            // 
            tBoxMainDir.BackColor = SystemColors.Window;
            tBoxMainDir.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tBoxMainDir.Location = new Point(1139, 8);
            tBoxMainDir.Name = "tBoxMainDir";
            tBoxMainDir.Size = new Size(671, 30);
            tBoxMainDir.TabIndex = 9;
            // 
            // btnMainDir
            // 
            btnMainDir.BackColor = Color.MediumSlateBlue;
            btnMainDir.Font = new Font("Arial", 12F);
            btnMainDir.ForeColor = SystemColors.ButtonFace;
            btnMainDir.Location = new Point(1831, 3);
            btnMainDir.Name = "btnMainDir";
            btnMainDir.Size = new Size(94, 39);
            btnMainDir.TabIndex = 10;
            btnMainDir.Text = "Dir";
            btnMainDir.UseVisualStyleBackColor = false;
            btnMainDir.Click += btnMainDir_Click;
            // 
            // tBoxMainNGCnt
            // 
            tBoxMainNGCnt.BackColor = SystemColors.Window;
            tBoxMainNGCnt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tBoxMainNGCnt.Location = new Point(2039, 8);
            tBoxMainNGCnt.Name = "tBoxMainNGCnt";
            tBoxMainNGCnt.Size = new Size(121, 30);
            tBoxMainNGCnt.TabIndex = 11;
            // 
            // lblMainNGCnt
            // 
            lblMainNGCnt.AutoSize = true;
            lblMainNGCnt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainNGCnt.Location = new Point(1967, 11);
            lblMainNGCnt.Name = "lblMainNGCnt";
            lblMainNGCnt.RightToLeft = RightToLeft.No;
            lblMainNGCnt.Size = new Size(51, 23);
            lblMainNGCnt.TabIndex = 12;
            lblMainNGCnt.Text = "NG :";
            // 
            // btnInspDir
            // 
            btnInspDir.BackColor = Color.MediumSlateBlue;
            btnInspDir.Font = new Font("Arial", 12F);
            btnInspDir.ForeColor = SystemColors.ButtonFace;
            btnInspDir.Location = new Point(709, 3);
            btnInspDir.Name = "btnInspDir";
            btnInspDir.Size = new Size(94, 39);
            btnInspDir.TabIndex = 13;
            btnInspDir.Text = "Dir";
            btnInspDir.UseVisualStyleBackColor = false;
            btnInspDir.Click += btnInspDir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(851, 11);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(51, 23);
            label1.TabIndex = 15;
            label1.Text = "NG :";
            // 
            // tBoxInspNGCnt
            // 
            tBoxInspNGCnt.BackColor = SystemColors.Window;
            tBoxInspNGCnt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tBoxInspNGCnt.Location = new Point(923, 8);
            tBoxInspNGCnt.Name = "tBoxInspNGCnt";
            tBoxInspNGCnt.Size = new Size(121, 30);
            tBoxInspNGCnt.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(862, 651);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(51, 23);
            label2.TabIndex = 18;
            label2.Text = "NG :";
            // 
            // tBoxPreNGCnt
            // 
            tBoxPreNGCnt.BackColor = SystemColors.Window;
            tBoxPreNGCnt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tBoxPreNGCnt.Location = new Point(934, 648);
            tBoxPreNGCnt.Name = "tBoxPreNGCnt";
            tBoxPreNGCnt.Size = new Size(121, 30);
            tBoxPreNGCnt.TabIndex = 17;
            // 
            // btnPreDir
            // 
            btnPreDir.BackColor = Color.MediumSlateBlue;
            btnPreDir.Font = new Font("Arial", 12F);
            btnPreDir.ForeColor = SystemColors.ButtonFace;
            btnPreDir.Location = new Point(720, 643);
            btnPreDir.Name = "btnPreDir";
            btnPreDir.Size = new Size(94, 39);
            btnPreDir.TabIndex = 16;
            btnPreDir.Text = "Dir";
            btnPreDir.UseVisualStyleBackColor = false;
            btnPreDir.Click += btnPreDir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2256, 1293);
            Controls.Add(label2);
            Controls.Add(tBoxPreNGCnt);
            Controls.Add(btnPreDir);
            Controls.Add(label1);
            Controls.Add(tBoxInspNGCnt);
            Controls.Add(btnInspDir);
            Controls.Add(lblMainNGCnt);
            Controls.Add(tBoxMainNGCnt);
            Controls.Add(btnMainDir);
            Controls.Add(tBoxMainDir);
            Controls.Add(tBoxInspDir);
            Controls.Add(lViewOutPre);
            Controls.Add(listView2);
            Controls.Add(button3);
            Controls.Add(lViewOutMain);
            Controls.Add(lViewOutInsp);
            Controls.Add(btnINSP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnINSP;
        private ListView lViewOutInsp;
        private ColumnHeader lViewPanelID;
        private ColumnHeader iViewFlim;
        private ColumnHeader lViewSpecOut;
        private ColumnHeader lViewNum;
        private ListView lViewOutMain;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button3;
        private ListView lViewOutPre;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private TextBox tBoxInspDir;
        private TextBox tBoxMainDir;
        private Button btnMainDir;
        private TextBox tBoxMainNGCnt;
        private Label lblMainNGCnt;
        private Button btnInspDir;
        private Label label1;
        private TextBox tBoxInspNGCnt;
        private Label label2;
        private TextBox tBoxPreNGCnt;
        private Button btnPreDir;
    }
}
