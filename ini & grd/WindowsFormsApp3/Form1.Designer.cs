using System.Windows.Forms;

namespace WindowsFormsApp3
{
    partial class dlgINIFileTest
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgINIFileTest));
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.grdItem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWrite1 = new System.Windows.Forms.Button();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.grdItem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblData3 = new System.Windows.Forms.Label();
            this.grd3 = new System.Windows.Forms.DataGridView();
            this.grdItem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdValue3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblData4 = new System.Windows.Forms.Label();
            this.grd4 = new System.Windows.Forms.DataGridView();
            this.grdItem4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdValue4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFileList = new System.Windows.Forms.Label();
            this.grdFileList = new System.Windows.Forms.DataGridView();
            this.grdFileList_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.btnWrite2 = new System.Windows.Forms.Button();
            this.btnAdd4 = new System.Windows.Forms.Button();
            this.btnRead4 = new System.Windows.Forms.Button();
            this.btnWrite4 = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.btnRead3 = new System.Windows.Forms.Button();
            this.btnWrite3 = new System.Windows.Forms.Button();
            this.btnAdd5 = new System.Windows.Forms.Button();
            this.btnWrite5 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnDelete4 = new System.Windows.Forms.Button();
            this.btnDelete5 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxDir = new System.Windows.Forms.TextBox();
            this.btnDirSave = new System.Windows.Forms.Button();
            this.btnCopy1 = new System.Windows.Forms.Button();
            this.btnCopy3 = new System.Windows.Forms.Button();
            this.btnCopy5 = new System.Windows.Forms.Button();
            this.btnCopy4 = new System.Windows.Forms.Button();
            this.btnCopy2 = new System.Windows.Forms.Button();
            this.btnPaste4 = new System.Windows.Forms.Button();
            this.btnPaste2 = new System.Windows.Forms.Button();
            this.btnPaste5 = new System.Windows.Forms.Button();
            this.btnPaste3 = new System.Windows.Forms.Button();
            this.btnPaste1 = new System.Windows.Forms.Button();
            this.lBoxLog = new System.Windows.Forms.ListBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblCurFile = new System.Windows.Forms.Label();
            this.tBoxCurFile = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // grd1
            // 
            this.grd1.AllowUserToAddRows = false;
            this.grd1.AllowUserToDeleteRows = false;
            this.grd1.BackgroundColor = System.Drawing.Color.White;
            this.grd1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd1.ColumnHeadersHeight = 29;
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdItem1,
            this.grdValue1});
            this.grd1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grd1.Location = new System.Drawing.Point(12, 151);
            this.grd1.Margin = new System.Windows.Forms.Padding(4);
            this.grd1.Name = "grd1";
            this.grd1.RowHeadersWidth = 50;
            this.grd1.RowTemplate.Height = 23;
            this.grd1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd1.Size = new System.Drawing.Size(350, 438);
            this.grd1.TabIndex = 0;
            // 
            // grdItem1
            // 
            this.grdItem1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdItem1.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdItem1.HeaderText = "Item";
            this.grdItem1.MinimumWidth = 6;
            this.grdItem1.Name = "grdItem1";
            this.grdItem1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItem1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdItem1.Width = 45;
            // 
            // grdValue1
            // 
            this.grdValue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdValue1.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdValue1.HeaderText = "Value";
            this.grdValue1.MinimumWidth = 6;
            this.grdValue1.Name = "grdValue1";
            this.grdValue1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdValue1.Width = 53;
            // 
            // btnWrite1
            // 
            this.btnWrite1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite1.Location = new System.Drawing.Point(370, 522);
            this.btnWrite1.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite1.Name = "btnWrite1";
            this.btnWrite1.Size = new System.Drawing.Size(100, 29);
            this.btnWrite1.TabIndex = 1;
            this.btnWrite1.Text = "Save";
            this.btnWrite1.UseVisualStyleBackColor = true;
            this.btnWrite1.Visible = false;
            this.btnWrite1.Click += new System.EventHandler(this.btnWrite1_Click);
            // 
            // btnRead1
            // 
            this.btnRead1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead1.Location = new System.Drawing.Point(370, 559);
            this.btnRead1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(100, 29);
            this.btnRead1.TabIndex = 2;
            this.btnRead1.Text = "Read";
            this.btnRead1.UseVisualStyleBackColor = true;
            this.btnRead1.Visible = false;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd1.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnAdd1.FlatAppearance.BorderSize = 3;
            this.btnAdd1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAdd1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd1.Location = new System.Drawing.Point(370, 150);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(118, 44);
            this.btnAdd1.TabIndex = 3;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData1.Location = new System.Drawing.Point(12, 109);
            this.lblData1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(106, 39);
            this.lblData1.TabIndex = 5;
            this.lblData1.Text = "Data1";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData2.Location = new System.Drawing.Point(12, 599);
            this.lblData2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(106, 39);
            this.lblData2.TabIndex = 7;
            this.lblData2.Text = "Data2";
            // 
            // grd2
            // 
            this.grd2.AllowUserToAddRows = false;
            this.grd2.BackgroundColor = System.Drawing.Color.White;
            this.grd2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd2.ColumnHeadersHeight = 29;
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdItem2,
            this.grdValue2});
            this.grd2.Cursor = System.Windows.Forms.Cursors.Default;
            this.grd2.Location = new System.Drawing.Point(12, 641);
            this.grd2.Margin = new System.Windows.Forms.Padding(4);
            this.grd2.Name = "grd2";
            this.grd2.RowHeadersWidth = 50;
            this.grd2.RowTemplate.Height = 23;
            this.grd2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd2.Size = new System.Drawing.Size(350, 438);
            this.grd2.TabIndex = 6;
            // 
            // grdItem2
            // 
            this.grdItem2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdItem2.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdItem2.HeaderText = "Item";
            this.grdItem2.MinimumWidth = 6;
            this.grdItem2.Name = "grdItem2";
            this.grdItem2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItem2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdItem2.Width = 45;
            // 
            // grdValue2
            // 
            this.grdValue2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdValue2.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdValue2.HeaderText = "Value";
            this.grdValue2.MinimumWidth = 6;
            this.grdValue2.Name = "grdValue2";
            this.grdValue2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdValue2.Width = 53;
            // 
            // lblData3
            // 
            this.lblData3.AutoSize = true;
            this.lblData3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData3.Location = new System.Drawing.Point(508, 109);
            this.lblData3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData3.Name = "lblData3";
            this.lblData3.Size = new System.Drawing.Size(106, 39);
            this.lblData3.TabIndex = 9;
            this.lblData3.Text = "Data3";
            // 
            // grd3
            // 
            this.grd3.AllowUserToAddRows = false;
            this.grd3.BackgroundColor = System.Drawing.Color.White;
            this.grd3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd3.ColumnHeadersHeight = 29;
            this.grd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdItem3,
            this.grdValue3});
            this.grd3.Location = new System.Drawing.Point(509, 151);
            this.grd3.Margin = new System.Windows.Forms.Padding(4);
            this.grd3.Name = "grd3";
            this.grd3.RowHeadersWidth = 50;
            this.grd3.RowTemplate.Height = 23;
            this.grd3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd3.Size = new System.Drawing.Size(350, 438);
            this.grd3.TabIndex = 8;
            // 
            // grdItem3
            // 
            this.grdItem3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdItem3.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdItem3.HeaderText = "Item";
            this.grdItem3.MinimumWidth = 6;
            this.grdItem3.Name = "grdItem3";
            this.grdItem3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItem3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdItem3.Width = 45;
            // 
            // grdValue3
            // 
            this.grdValue3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdValue3.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdValue3.HeaderText = "Value";
            this.grdValue3.MinimumWidth = 6;
            this.grdValue3.Name = "grdValue3";
            this.grdValue3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdValue3.Width = 53;
            // 
            // lblData4
            // 
            this.lblData4.AutoSize = true;
            this.lblData4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData4.Location = new System.Drawing.Point(508, 600);
            this.lblData4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData4.Name = "lblData4";
            this.lblData4.Size = new System.Drawing.Size(106, 39);
            this.lblData4.TabIndex = 11;
            this.lblData4.Text = "Data4";
            // 
            // grd4
            // 
            this.grd4.AllowUserToAddRows = false;
            this.grd4.BackgroundColor = System.Drawing.Color.White;
            this.grd4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grd4.ColumnHeadersHeight = 29;
            this.grd4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdItem4,
            this.grdValue4});
            this.grd4.Cursor = System.Windows.Forms.Cursors.Default;
            this.grd4.Location = new System.Drawing.Point(509, 642);
            this.grd4.Margin = new System.Windows.Forms.Padding(4);
            this.grd4.Name = "grd4";
            this.grd4.RowHeadersWidth = 50;
            this.grd4.RowTemplate.Height = 23;
            this.grd4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd4.Size = new System.Drawing.Size(350, 438);
            this.grd4.TabIndex = 10;
            // 
            // grdItem4
            // 
            this.grdItem4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdItem4.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdItem4.HeaderText = "Item";
            this.grdItem4.MinimumWidth = 6;
            this.grdItem4.Name = "grdItem4";
            this.grdItem4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItem4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdItem4.Width = 45;
            // 
            // grdValue4
            // 
            this.grdValue4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdValue4.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdValue4.HeaderText = "Value";
            this.grdValue4.MinimumWidth = 6;
            this.grdValue4.Name = "grdValue4";
            this.grdValue4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdValue4.Width = 53;
            // 
            // lblFileList
            // 
            this.lblFileList.AutoSize = true;
            this.lblFileList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileList.Location = new System.Drawing.Point(1005, 108);
            this.lblFileList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileList.Name = "lblFileList";
            this.lblFileList.Size = new System.Drawing.Size(122, 39);
            this.lblFileList.TabIndex = 13;
            this.lblFileList.Text = "FileList";
            // 
            // grdFileList
            // 
            this.grdFileList.AllowUserToAddRows = false;
            this.grdFileList.BackgroundColor = System.Drawing.Color.White;
            this.grdFileList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdFileList.ColumnHeadersHeight = 29;
            this.grdFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdFileList_Name});
            this.grdFileList.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdFileList.Location = new System.Drawing.Point(1007, 150);
            this.grdFileList.Margin = new System.Windows.Forms.Padding(4);
            this.grdFileList.Name = "grdFileList";
            this.grdFileList.RowHeadersWidth = 50;
            this.grdFileList.RowTemplate.Height = 23;
            this.grdFileList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFileList.Size = new System.Drawing.Size(304, 929);
            this.grdFileList.TabIndex = 12;
            this.grdFileList.Click += new System.EventHandler(this.grdFileList_Click);
            // 
            // grdFileList_Name
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdFileList_Name.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdFileList_Name.HeaderText = "Name";
            this.grdFileList_Name.MinimumWidth = 6;
            this.grdFileList_Name.Name = "grdFileList_Name";
            this.grdFileList_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFileList_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grdFileList_Name.Width = 252;
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd2.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnAdd2.FlatAppearance.BorderSize = 3;
            this.btnAdd2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAdd2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd2.Location = new System.Drawing.Point(370, 641);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(118, 44);
            this.btnAdd2.TabIndex = 22;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead2.Location = new System.Drawing.Point(370, 1050);
            this.btnRead2.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(100, 29);
            this.btnRead2.TabIndex = 21;
            this.btnRead2.Text = "Read";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Visible = false;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
            // 
            // btnWrite2
            // 
            this.btnWrite2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite2.Location = new System.Drawing.Point(370, 1013);
            this.btnWrite2.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite2.Name = "btnWrite2";
            this.btnWrite2.Size = new System.Drawing.Size(100, 29);
            this.btnWrite2.TabIndex = 20;
            this.btnWrite2.Text = "Save";
            this.btnWrite2.UseVisualStyleBackColor = true;
            this.btnWrite2.Visible = false;
            this.btnWrite2.Click += new System.EventHandler(this.btnWrite2_Click);
            // 
            // btnAdd4
            // 
            this.btnAdd4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd4.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnAdd4.FlatAppearance.BorderSize = 3;
            this.btnAdd4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAdd4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd4.Location = new System.Drawing.Point(867, 642);
            this.btnAdd4.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd4.Name = "btnAdd4";
            this.btnAdd4.Size = new System.Drawing.Size(118, 44);
            this.btnAdd4.TabIndex = 28;
            this.btnAdd4.Text = "Add";
            this.btnAdd4.UseVisualStyleBackColor = false;
            this.btnAdd4.Click += new System.EventHandler(this.btnAdd4_Click);
            // 
            // btnRead4
            // 
            this.btnRead4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead4.Location = new System.Drawing.Point(867, 1050);
            this.btnRead4.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead4.Name = "btnRead4";
            this.btnRead4.Size = new System.Drawing.Size(100, 29);
            this.btnRead4.TabIndex = 27;
            this.btnRead4.Text = "Read";
            this.btnRead4.UseVisualStyleBackColor = true;
            this.btnRead4.Visible = false;
            this.btnRead4.Click += new System.EventHandler(this.btnRead4_Click);
            // 
            // btnWrite4
            // 
            this.btnWrite4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite4.Location = new System.Drawing.Point(867, 1013);
            this.btnWrite4.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite4.Name = "btnWrite4";
            this.btnWrite4.Size = new System.Drawing.Size(100, 29);
            this.btnWrite4.TabIndex = 26;
            this.btnWrite4.Text = "Save";
            this.btnWrite4.UseVisualStyleBackColor = true;
            this.btnWrite4.Visible = false;
            this.btnWrite4.Click += new System.EventHandler(this.btnWrite4_Click);
            // 
            // btnAdd3
            // 
            this.btnAdd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd3.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnAdd3.FlatAppearance.BorderSize = 3;
            this.btnAdd3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAdd3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd3.Location = new System.Drawing.Point(867, 151);
            this.btnAdd3.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(118, 44);
            this.btnAdd3.TabIndex = 25;
            this.btnAdd3.Text = "Add";
            this.btnAdd3.UseVisualStyleBackColor = false;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // btnRead3
            // 
            this.btnRead3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead3.Location = new System.Drawing.Point(867, 559);
            this.btnRead3.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead3.Name = "btnRead3";
            this.btnRead3.Size = new System.Drawing.Size(100, 29);
            this.btnRead3.TabIndex = 24;
            this.btnRead3.Text = "Read";
            this.btnRead3.UseVisualStyleBackColor = true;
            this.btnRead3.Visible = false;
            this.btnRead3.Click += new System.EventHandler(this.btnRead3_Click);
            // 
            // btnWrite3
            // 
            this.btnWrite3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite3.Location = new System.Drawing.Point(867, 522);
            this.btnWrite3.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite3.Name = "btnWrite3";
            this.btnWrite3.Size = new System.Drawing.Size(100, 29);
            this.btnWrite3.TabIndex = 23;
            this.btnWrite3.Text = "Save";
            this.btnWrite3.UseVisualStyleBackColor = true;
            this.btnWrite3.Visible = false;
            this.btnWrite3.Click += new System.EventHandler(this.btnWrite3_Click);
            // 
            // btnAdd5
            // 
            this.btnAdd5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAdd5.FlatAppearance.BorderSize = 3;
            this.btnAdd5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnAdd5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd5.Location = new System.Drawing.Point(1319, 264);
            this.btnAdd5.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd5.Name = "btnAdd5";
            this.btnAdd5.Size = new System.Drawing.Size(151, 44);
            this.btnAdd5.TabIndex = 31;
            this.btnAdd5.Text = "Add";
            this.btnAdd5.UseVisualStyleBackColor = false;
            this.btnAdd5.Click += new System.EventHandler(this.btnAdd5_Click);
            // 
            // btnWrite5
            // 
            this.btnWrite5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnWrite5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnWrite5.FlatAppearance.BorderSize = 3;
            this.btnWrite5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnWrite5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWrite5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWrite5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWrite5.Location = new System.Drawing.Point(1319, 368);
            this.btnWrite5.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite5.Name = "btnWrite5";
            this.btnWrite5.Size = new System.Drawing.Size(151, 44);
            this.btnWrite5.TabIndex = 29;
            this.btnWrite5.Text = "Save";
            this.btnWrite5.UseVisualStyleBackColor = false;
            this.btnWrite5.Click += new System.EventHandler(this.btnWrite5_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete2.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnDelete2.FlatAppearance.BorderSize = 3;
            this.btnDelete2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDelete2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete2.Location = new System.Drawing.Point(370, 693);
            this.btnDelete2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(118, 44);
            this.btnDelete2.TabIndex = 50;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnDelete4
            // 
            this.btnDelete4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete4.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnDelete4.FlatAppearance.BorderSize = 3;
            this.btnDelete4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDelete4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete4.Location = new System.Drawing.Point(867, 694);
            this.btnDelete4.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete4.Name = "btnDelete4";
            this.btnDelete4.Size = new System.Drawing.Size(118, 44);
            this.btnDelete4.TabIndex = 52;
            this.btnDelete4.Text = "Delete";
            this.btnDelete4.UseVisualStyleBackColor = false;
            this.btnDelete4.Click += new System.EventHandler(this.btnDelete4_Click);
            // 
            // btnDelete5
            // 
            this.btnDelete5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDelete5.FlatAppearance.BorderSize = 3;
            this.btnDelete5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDelete5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete5.Location = new System.Drawing.Point(1319, 316);
            this.btnDelete5.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete5.Name = "btnDelete5";
            this.btnDelete5.Size = new System.Drawing.Size(151, 44);
            this.btnDelete5.TabIndex = 46;
            this.btnDelete5.Text = "Delete";
            this.btnDelete5.UseVisualStyleBackColor = false;
            this.btnDelete5.Click += new System.EventHandler(this.btnDelete5_Click);
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete3.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnDelete3.FlatAppearance.BorderSize = 3;
            this.btnDelete3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDelete3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete3.Location = new System.Drawing.Point(867, 203);
            this.btnDelete3.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(118, 44);
            this.btnDelete3.TabIndex = 44;
            this.btnDelete3.Text = "Delete";
            this.btnDelete3.UseVisualStyleBackColor = false;
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete1.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnDelete1.FlatAppearance.BorderSize = 3;
            this.btnDelete1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDelete1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete1.Location = new System.Drawing.Point(370, 202);
            this.btnDelete1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(118, 44);
            this.btnDelete1.TabIndex = 42;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "File Path :";
            // 
            // tBoxDir
            // 
            this.tBoxDir.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDir.Location = new System.Drawing.Point(189, 19);
            this.tBoxDir.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tBoxDir.Name = "tBoxDir";
            this.tBoxDir.Size = new System.Drawing.Size(549, 36);
            this.tBoxDir.TabIndex = 58;
            // 
            // btnDirSave
            // 
            this.btnDirSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirSave.Location = new System.Drawing.Point(768, 19);
            this.btnDirSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDirSave.Name = "btnDirSave";
            this.btnDirSave.Size = new System.Drawing.Size(107, 38);
            this.btnDirSave.TabIndex = 59;
            this.btnDirSave.Text = "保存";
            this.btnDirSave.UseVisualStyleBackColor = true;
            this.btnDirSave.Visible = false;
            this.btnDirSave.Click += new System.EventHandler(this.btnDirSave_Click);
            // 
            // btnCopy1
            // 
            this.btnCopy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopy1.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCopy1.FlatAppearance.BorderSize = 3;
            this.btnCopy1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnCopy1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopy1.Location = new System.Drawing.Point(370, 264);
            this.btnCopy1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(118, 44);
            this.btnCopy1.TabIndex = 60;
            this.btnCopy1.Text = "Copy";
            this.btnCopy1.UseVisualStyleBackColor = false;
            this.btnCopy1.Click += new System.EventHandler(this.btnCopy1_Click);
            // 
            // btnCopy3
            // 
            this.btnCopy3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopy3.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCopy3.FlatAppearance.BorderSize = 3;
            this.btnCopy3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnCopy3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopy3.Location = new System.Drawing.Point(867, 264);
            this.btnCopy3.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy3.Name = "btnCopy3";
            this.btnCopy3.Size = new System.Drawing.Size(118, 44);
            this.btnCopy3.TabIndex = 61;
            this.btnCopy3.Text = "Copy";
            this.btnCopy3.UseVisualStyleBackColor = false;
            this.btnCopy3.Click += new System.EventHandler(this.btnCopy3_Click);
            // 
            // btnCopy5
            // 
            this.btnCopy5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy5.Location = new System.Drawing.Point(1319, 641);
            this.btnCopy5.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy5.Name = "btnCopy5";
            this.btnCopy5.Size = new System.Drawing.Size(100, 25);
            this.btnCopy5.TabIndex = 62;
            this.btnCopy5.Text = "Copy";
            this.btnCopy5.UseVisualStyleBackColor = true;
            this.btnCopy5.Visible = false;
            this.btnCopy5.Click += new System.EventHandler(this.btnCopy5_Click);
            // 
            // btnCopy4
            // 
            this.btnCopy4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopy4.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCopy4.FlatAppearance.BorderSize = 3;
            this.btnCopy4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnCopy4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopy4.Location = new System.Drawing.Point(867, 756);
            this.btnCopy4.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy4.Name = "btnCopy4";
            this.btnCopy4.Size = new System.Drawing.Size(118, 44);
            this.btnCopy4.TabIndex = 65;
            this.btnCopy4.Text = "Copy";
            this.btnCopy4.UseVisualStyleBackColor = false;
            this.btnCopy4.Click += new System.EventHandler(this.btnCopy4_Click);
            // 
            // btnCopy2
            // 
            this.btnCopy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCopy2.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCopy2.FlatAppearance.BorderSize = 3;
            this.btnCopy2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnCopy2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCopy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopy2.Location = new System.Drawing.Point(370, 754);
            this.btnCopy2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy2.Name = "btnCopy2";
            this.btnCopy2.Size = new System.Drawing.Size(118, 44);
            this.btnCopy2.TabIndex = 64;
            this.btnCopy2.Text = "Copy";
            this.btnCopy2.UseVisualStyleBackColor = false;
            this.btnCopy2.Click += new System.EventHandler(this.btnCopy2_Click);
            // 
            // btnPaste4
            // 
            this.btnPaste4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPaste4.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnPaste4.FlatAppearance.BorderSize = 3;
            this.btnPaste4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPaste4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaste4.Location = new System.Drawing.Point(867, 803);
            this.btnPaste4.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaste4.Name = "btnPaste4";
            this.btnPaste4.Size = new System.Drawing.Size(118, 44);
            this.btnPaste4.TabIndex = 73;
            this.btnPaste4.Text = "Paste";
            this.btnPaste4.UseVisualStyleBackColor = false;
            this.btnPaste4.Click += new System.EventHandler(this.btnPaste4_Click);
            // 
            // btnPaste2
            // 
            this.btnPaste2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPaste2.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnPaste2.FlatAppearance.BorderSize = 3;
            this.btnPaste2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPaste2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaste2.Location = new System.Drawing.Point(370, 802);
            this.btnPaste2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaste2.Name = "btnPaste2";
            this.btnPaste2.Size = new System.Drawing.Size(118, 44);
            this.btnPaste2.TabIndex = 72;
            this.btnPaste2.Text = "Paste";
            this.btnPaste2.UseVisualStyleBackColor = false;
            this.btnPaste2.Click += new System.EventHandler(this.btnPaste2_Click);
            // 
            // btnPaste5
            // 
            this.btnPaste5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste5.Location = new System.Drawing.Point(1319, 674);
            this.btnPaste5.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaste5.Name = "btnPaste5";
            this.btnPaste5.Size = new System.Drawing.Size(100, 25);
            this.btnPaste5.TabIndex = 70;
            this.btnPaste5.Text = "Paste";
            this.btnPaste5.UseVisualStyleBackColor = true;
            this.btnPaste5.Visible = false;
            this.btnPaste5.Click += new System.EventHandler(this.btnPaste5_Click);
            // 
            // btnPaste3
            // 
            this.btnPaste3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPaste3.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnPaste3.FlatAppearance.BorderSize = 3;
            this.btnPaste3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPaste3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaste3.Location = new System.Drawing.Point(867, 312);
            this.btnPaste3.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaste3.Name = "btnPaste3";
            this.btnPaste3.Size = new System.Drawing.Size(118, 44);
            this.btnPaste3.TabIndex = 69;
            this.btnPaste3.Text = "Paste";
            this.btnPaste3.UseVisualStyleBackColor = false;
            this.btnPaste3.Click += new System.EventHandler(this.btnPaste3_Click);
            // 
            // btnPaste1
            // 
            this.btnPaste1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPaste1.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnPaste1.FlatAppearance.BorderSize = 3;
            this.btnPaste1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnPaste1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaste1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPaste1.Location = new System.Drawing.Point(370, 312);
            this.btnPaste1.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaste1.Name = "btnPaste1";
            this.btnPaste1.Size = new System.Drawing.Size(118, 44);
            this.btnPaste1.TabIndex = 68;
            this.btnPaste1.Text = "Paste";
            this.btnPaste1.UseVisualStyleBackColor = false;
            this.btnPaste1.Click += new System.EventHandler(this.btnPaste1_Click);
            // 
            // lBoxLog
            // 
            this.lBoxLog.BackColor = System.Drawing.SystemColors.Window;
            this.lBoxLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.lBoxLog.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lBoxLog.FormattingEnabled = true;
            this.lBoxLog.ItemHeight = 25;
            this.lBoxLog.Location = new System.Drawing.Point(1503, 150);
            this.lBoxLog.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lBoxLog.Name = "lBoxLog";
            this.lBoxLog.Size = new System.Drawing.Size(519, 929);
            this.lBoxLog.TabIndex = 76;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(1496, 108);
            this.lblLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(225, 39);
            this.lblLog.TabIndex = 77;
            this.lblLog.Text = "Operation Log";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLoad.FlatAppearance.BorderSize = 3;
            this.btnLoad.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.Location = new System.Drawing.Point(1319, 150);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(151, 44);
            this.btnLoad.TabIndex = 78;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblCurFile
            // 
            this.lblCurFile.AutoSize = true;
            this.lblCurFile.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurFile.Location = new System.Drawing.Point(20, 61);
            this.lblCurFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurFile.Name = "lblCurFile";
            this.lblCurFile.Size = new System.Drawing.Size(157, 28);
            this.lblCurFile.TabIndex = 79;
            this.lblCurFile.Text = "Current File :";
            // 
            // tBoxCurFile
            // 
            this.tBoxCurFile.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCurFile.Location = new System.Drawing.Point(189, 59);
            this.tBoxCurFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tBoxCurFile.Name = "tBoxCurFile";
            this.tBoxCurFile.Size = new System.Drawing.Size(549, 38);
            this.tBoxCurFile.TabIndex = 80;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSelect.FlatAppearance.BorderSize = 3;
            this.btnSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.Location = new System.Drawing.Point(1319, 202);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(151, 44);
            this.btnSelect.TabIndex = 81;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dlgINIFileTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2119, 1094);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tBoxCurFile);
            this.Controls.Add(this.lblCurFile);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBoxLog);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.btnAdd4);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnDelete3);
            this.Controls.Add(this.btnDelete4);
            this.Controls.Add(this.btnWrite1);
            this.Controls.Add(this.btnWrite2);
            this.Controls.Add(this.btnWrite3);
            this.Controls.Add(this.btnWrite4);
            this.Controls.Add(this.btnCopy1);
            this.Controls.Add(this.btnCopy2);
            this.Controls.Add(this.btnCopy3);
            this.Controls.Add(this.btnCopy4);
            this.Controls.Add(this.btnPaste1);
            this.Controls.Add(this.btnPaste2);
            this.Controls.Add(this.btnPaste3);
            this.Controls.Add(this.btnPaste4);
            this.Controls.Add(this.btnRead1);
            this.Controls.Add(this.btnRead2);
            this.Controls.Add(this.btnRead3);
            this.Controls.Add(this.btnRead4);
            this.Controls.Add(this.lblData1);
            this.Controls.Add(this.lblData2);
            this.Controls.Add(this.lblData3);
            this.Controls.Add(this.lblData4);
            this.Controls.Add(this.grd1);
            this.Controls.Add(this.grd2);
            this.Controls.Add(this.grd3);
            this.Controls.Add(this.grd4);
            this.Controls.Add(this.lblFileList);
            this.Controls.Add(this.grdFileList);
            this.Controls.Add(this.btnDirSave);
            this.Controls.Add(this.tBoxDir);
            this.Controls.Add(this.btnPaste5);
            this.Controls.Add(this.btnAdd5);
            this.Controls.Add(this.btnDelete5);
            this.Controls.Add(this.btnWrite5);
            this.Controls.Add(this.btnCopy5);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dlgINIFileTest";
            this.Text = "iniFileTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFileList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd1;
        private System.Windows.Forms.DataGridView grd2;
        private System.Windows.Forms.DataGridView grd3;
        private System.Windows.Forms.DataGridView grd4;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblData3;
        private System.Windows.Forms.Label lblData4;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Button btnAdd4;
        private System.Windows.Forms.Button btnAdd5;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnDelete4;
        private System.Windows.Forms.Button btnDelete5;
        private System.Windows.Forms.Button btnWrite1;
        private System.Windows.Forms.Button btnWrite2;
        private System.Windows.Forms.Button btnWrite3;
        private System.Windows.Forms.Button btnWrite4;
        private System.Windows.Forms.Button btnWrite5;
        private System.Windows.Forms.Button btnRead1;
        private System.Windows.Forms.Button btnRead2;
        private System.Windows.Forms.Button btnRead4;
        private System.Windows.Forms.Button btnRead3;
        private System.Windows.Forms.Button btnCopy1;
        private System.Windows.Forms.Button btnCopy3;
        private System.Windows.Forms.Button btnCopy5;
        private System.Windows.Forms.Button btnCopy4;
        private System.Windows.Forms.Button btnCopy2;
        private System.Windows.Forms.Button btnPaste4;
        private System.Windows.Forms.Button btnPaste2;
        private System.Windows.Forms.Button btnPaste5;
        private System.Windows.Forms.Button btnPaste3;
        private System.Windows.Forms.Button btnPaste1;
        private System.Windows.Forms.Button btnDirSave;
        private System.Windows.Forms.Label lblFileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ListBox lBoxLog;
        private System.Windows.Forms.TextBox tBoxDir;
        private System.Windows.Forms.DataGridView grdFileList;
        private DataGridViewTextBoxColumn grdItem1;
        private DataGridViewTextBoxColumn grdItem2;
        private DataGridViewTextBoxColumn grdItem3;
        private DataGridViewTextBoxColumn grdItem4;
        private DataGridViewTextBoxColumn grdValue1;
        private DataGridViewTextBoxColumn grdValue2;
        private DataGridViewTextBoxColumn grdValue3;
        private DataGridViewTextBoxColumn grdValue4;
        private DataGridViewTextBoxColumn grdFileList_Name;
        private Button btnLoad;
        private Button btnSelect;
        private Label lblCurFile;
        private TextBox tBoxCurFile;
        DataGridViewRow[] dgvrRow;
        string[] strEntry1, strEntry2, strEntry3, strEntry4, strEntry5, strEntry6, strEntry7, strEntry8;
        public class Section
        {
            public string[] _strKeys;
            public string[] _strValues;
        }
        Section[] clsSection = new Section[4];
        int iSelectedRow = 0;
    }
}

