using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.IO;
using System.Net.Configuration;
//using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp3
{
    public partial class dlgINIFileTest : Form
    {
        [DllImport("kernel32")] private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")] private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder reVal, int size, string filepath);
        [DllImport("kernel32")] static extern int GetPrivateProfileString(string Section, int Key, string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result, int Size, string FileName);
        [DllImport("kernel32")] static extern int GetPrivateProfileString(int Section, string Key, string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result, int Size, string FileName);

        public string _filePath = @"C:\FileList";

        public dlgINIFileTest()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tBoxDir.Text = _filePath;

            if (tBoxDir.Text != "" && tBoxCurFile.Text != "") 
            {
                _filePath = tBoxDir.Text + "\\" + tBoxCurFile.Text;
            }
            else 
            {
            }

            // 파일 명칭 가져오고 확장자 자르기
            string fileName = "";
            DirectoryInfo di = new DirectoryInfo(_filePath);
            if (!di.Exists) di.Create();

            // 파일 리스트에 줄 추가하고 파일 명칭 입력
            foreach (FileInfo File in di.GetFiles()) 
            {
                fileName = System.IO.Path.GetFileName(File.FullName);
                grdFileList.Rows.Add();
                grdFileList.Rows[grdFileList.Rows.Count - 1].Cells[0].Value = fileName.Substring(0, fileName.Length - 4);
                grdFileList.Rows[grdFileList.Rows.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(244, 247, 252);
                grdFileList.Rows[grdFileList.Rows.Count - 1].HeaderCell.Value = grdFileList.Rows.Count.ToString();
            }
            ReadINISetHeadNum(_filePath);

            RowsRemove(grd1); FuncReadINI("Data1", grd1);
            RowsRemove(grd2); FuncReadINI("Data2", grd2);
            RowsRemove(grd3); FuncReadINI("Data3", grd3);
            RowsRemove(grd4); FuncReadINI("Data4", grd4);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Add
        private void btnAdd1_Click( object sender, EventArgs e )
        {
            FuncAdd( grd1, "Data1" );
        }
        private void btnAdd2_Click( object sender, EventArgs e )
        {
            FuncAdd( grd2, "Data2" );
        }
        private void btnAdd3_Click( object sender, EventArgs e )
        {
            FuncAdd( grd3, "Data3" );
        }
        private void btnAdd4_Click( object sender, EventArgs e )
        {
            FuncAdd( grd4, "Data4" );
        }
        private void FuncAdd( DataGridView dgvGrid, string strSection )
        {
            dgvGrid.Rows.Add();
            dgvGrid.Rows[ dgvGrid.Rows.Count - 1 ].HeaderCell.Value = dgvGrid.Rows.Count.ToString();
            dgvGrid.Rows[ dgvGrid.Rows.Count - 1 ].DefaultCellStyle.BackColor = Color.FromArgb(244, 247, 252);
            LogPrint( strSection.ToString(), " Add", " Complete" );
        }
        #endregion
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Save
        private void btnWrite1_Click( object sender, EventArgs e )
        {
            WriteData( grd1, "Data1", strEntry1, _filePath);
        }
        private void btnWrite2_Click( object sender, EventArgs e )
        {
            WriteData( grd2, "Data2", strEntry2, _filePath);
        }
        private void btnWrite3_Click( object sender, EventArgs e )
        {
            WriteData( grd3, "Data3", strEntry3, _filePath);
        }
        private void btnWrite4_Click( object sender, EventArgs e )
        {
            WriteData( grd4, "Data4", strEntry4, _filePath );
        }
        private void WriteData( DataGridView gGrid, string strSection, string[] strEntry, string strPath )
        {
            try 
            {
                strEntry = GetEntryNames( strSection, strPath); // 파일에서 Key값 가져오기

                for( int i = 0; i < strEntry.Length; i++ )      // 파일 내부 Key 값에 Value 지우기
                {
                    WritePrivateProfileString( strSection, strEntry[ i ], null, strPath);
                }

                for( int i = 0; i < gGrid.RowCount; i++ )       // Grid 에 Key 값과 Value 값을 파일에 쓰기
                {
                    WritePrivateProfileString( strSection, gGrid.Rows[ i ].Cells[ 0 ].Value.ToString(), gGrid.Rows[ i ].Cells[ 1 ].Value.ToString(), strPath);
                }

                LogPrint( strSection.ToString(), " Save", " Complete");
            } 
            catch 
            {
                MessageBox.Show( "빈 데이터를 작성하거나 제거 해주세요" );
                LogPrint( strSection.ToString(), " Save", " Failed" );
            }
        }
        #endregion
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Read
        private void btnRead1_Click( object sender, EventArgs e )
        {
            FuncReadINI( "Data1", grd1 );
        }
        private void btnRead2_Click( object sender, EventArgs e )
        {
            FuncReadINI( "Data2", grd2 );
        }
        private void btnRead3_Click( object sender, EventArgs e )
        {
            FuncReadINI( "Data3", grd3 );
        }
        private void btnRead4_Click( object sender, EventArgs e )
        {
            FuncReadINI( "Data4", grd4 );
        }
        private void FuncReadINI( string strSection, DataGridView dgvGrid )
        {
            // Read ini to grid

            // 파일 경로 가져오기
            string strFilePath = tBoxDir.Text + "\\" + grdFileList.SelectedRows[0].Cells[0].Value.ToString() + ".ini";
            // key값 읽어오기
            string[] strEntry = GetEntryNames( strSection, strFilePath);
            StringBuilder strValue = new StringBuilder( 255 );
            // 파일 내부 내용 유무 확인
            if( strEntry[ 0 ].Length > 0 ) 
            {
                // 파일의 key 수량과 그리드의 row 맞추기
                if( strEntry.Length > dgvGrid.Rows.Count ) 
                {
                    while( strEntry.Length != dgvGrid.Rows.Count ) 
                    {
                        dgvGrid.Rows.Add();
                    }
                } 
                else if( strEntry.Length < dgvGrid.Rows.Count ) 
                {
                    while( strEntry.Length != dgvGrid.Rows.Count ) 
                    {
                        FuncDelete( dgvGrid, strSection, dgvGrid.Rows.Count - 1 );
                    }
                }
                for( int i = 0; i < strEntry.Length; i++ ) 
                {
                    // value 값 읽어오기
                    GetPrivateProfileString( strSection, strEntry[ i ].ToString(), "", strValue, 255, strFilePath);
                    
                    // 읽어온 key값과 value 값을 그리드에 삽입하기
                    dgvGrid.Rows[ i ].Cells[ 0 ].Value = strEntry[ i ].ToString();
                    dgvGrid.Rows[ i ].Cells[ 1 ].Value = strValue.ToString();
                }
            }
            SetRowHeader( dgvGrid );
            LogPrint( strSection.ToString(), " Add", " Complete" );
        }
        #endregion
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Delete
        private void btnDelete1_Click( object sender, EventArgs e )
        {
            if(grd1.Rows.Count > 0){ FuncDelete( grd1, "Data1", grd1.SelectedRows[ 0 ].Index );} 
        }
        private void btnDelete2_Click( object sender, EventArgs e )
        {
            if(grd2.Rows.Count > 0){ FuncDelete( grd2, "Data2", grd2.SelectedRows[ 0 ].Index );}
        }
        private void btnDelete3_Click( object sender, EventArgs e )
        {
            if(grd3.Rows.Count > 0){ FuncDelete( grd3, "Data3", grd3.SelectedRows[ 0 ].Index );}
        }
        private void btnDelete4_Click( object sender, EventArgs e )
        {
            if(grd4.Rows.Count > 0){ FuncDelete( grd4, "Data4", grd4.SelectedRows[ 0 ].Index );}
        }
        private void FuncDelete( DataGridView dgvGrid, string strSection, int iRowNum )
        {
            dgvGrid.Rows.RemoveAt( iRowNum );
            SetRowHeader( dgvGrid );
            LogPrint( strSection.ToString(), " Delete", " Complete" );
        }
        #endregion
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Copy
        private void btnCopy1_Click( object sender, EventArgs e )
        {
            dgvrRow = FuncGridCopied( grd1, "Data1" );
        }
        private void btnCopy2_Click( object sender, EventArgs e )
        {
            dgvrRow = FuncGridCopied( grd2, "Data2" );
        }
        private void btnCopy3_Click( object sender, EventArgs e )
        {
            dgvrRow = FuncGridCopied( grd3, "Data3" );
        }
        private void btnCopy4_Click( object sender, EventArgs e )
        {
            dgvrRow = FuncGridCopied( grd4, "Data4" );
        }
        private DataGridViewRow[] FuncGridCopied( DataGridView dgvGrid, string strSection )
        {
            DataGridViewRow[] dr = new DataGridViewRow[dgvGrid.Rows.Count];
            for( int i = 0; i < dgvGrid.Rows.Count; i++ ) 
            {
                dr[ i ] = ( DataGridViewRow )dgvGrid.Rows[ i ].Clone();
                for( int j = 0; j < dr[ i ].Cells.Count; j++ ) 
                {
                    dr[ i ].Cells[ j ].Value = dgvGrid.Rows[ i ].Cells[ j ].Value;
                }
            }
            LogPrint( strSection.ToString(), " Copy", " Complete" );
            return dr;
        }
        #endregion
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Paste
        private void btnPaste1_Click( object sender, EventArgs e )
        {
            FuncGridPaste( grd1, "Data1" );
        }
        private void btnPaste2_Click( object sender, EventArgs e )
        {
            FuncGridPaste( grd2, "Data2" );
        }
        private void btnPaste3_Click( object sender, EventArgs e )
        {
            FuncGridPaste( grd3, "Data3" );
        }
        private void btnPaste4_Click( object sender, EventArgs e )
        {
            FuncGridPaste( grd4, "Data4" );
        }
        private void FuncGridPaste( DataGridView dgvGrid, string strSection )
        {
            dgvGrid.Rows.Clear();
            for( int i = 0; i < dgvrRow.Length; i++ ) 
            {
                dgvGrid.Rows.Add();
                for( int j = 0; j < dgvrRow[ i ].Cells.Count; j++ ) 
                {
                    dgvGrid.Rows[ i ].Cells[ j ].Value = dgvrRow[ i ].Cells[ j ].Value.ToString();
                }
            }
            SetRowHeader( dgvGrid );
            LogPrint( strSection.ToString(), " Paste", " Complete" );
        }
        #endregion
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void SetRowHeader(DataGridView dgvGrid)
        {
            for( int i = 0; i < dgvGrid.Rows.Count; i++ ) 
            {
                dgvGrid.Rows[ i ].HeaderCell.Value = (i + 1).ToString();
            }
        }
        private void btnDirSave_Click( object sender, EventArgs e )
        {
            _filePath = tBoxDir.Text;
            ReadINISetHeadNum(_filePath);
        }
        private void ReadINISetHeadNum(string strPath)
        {
            // ini 파일 존재하면 Read 하고 Head Number 설정
            // 존재하지 않으면 파일 생성 및 Section 값 설정
            FileInfo fiFileInfo = new FileInfo(strPath);
            if( fiFileInfo.Exists ) 
            {
                grd1.Rows.Clear(); FuncReadINI("Data1", grd1);
                grd2.Rows.Clear(); FuncReadINI("Data2", grd2);
                grd3.Rows.Clear(); FuncReadINI("Data3", grd3);
                grd4.Rows.Clear(); FuncReadINI("Data4", grd4);
                SetRowHeader( grd1 );
                SetRowHeader( grd2 );
                SetRowHeader( grd3 );
                SetRowHeader( grd4 );
            } 
            else 
            {
                WritePrivateProfileString( "Data1", "", "", strPath );
                WritePrivateProfileString( "Data2", "", "", strPath );
                WritePrivateProfileString( "Data3", "", "", strPath );
                WritePrivateProfileString( "Data4", "", "", strPath );
            }
        }
        private void btnAdd5_Click( object sender, EventArgs e )
        {
            FuncAdd( grdFileList, "FileList" );
        }
        private void btnDelete5_Click( object sender, EventArgs e )
        {
            if(grdFileList.SelectedRows[0].Cells[0].Value.ToString() == tBoxCurFile.Text) 
            {
                MessageBox.Show("Unable to delete the currently selected file");
                return;
            }
            else 
            {
                File.Delete(tBoxDir.Text + "\\" + grdFileList.SelectedRows[0].Cells[0].Value.ToString() + ".ini");
            }
        }
        private void btnWrite5_Click( object sender, EventArgs e )
        {
            // 선택된 항목으로 파일 명칭과 경로 추출
            string strSelectedFileName = grdFileList.SelectedRows[ 0 ].Cells[ 0 ].Value.ToString();
            string strSelectedfilePath = tBoxDir.Text + "\\" + strSelectedFileName + ".ini";

            WriteData(grd1, "Data1", strEntry1, strSelectedfilePath);
            WriteData(grd2, "Data2", strEntry2, strSelectedfilePath);
            WriteData(grd3, "Data3", strEntry3, strSelectedfilePath);
            WriteData(grd4, "Data4", strEntry4, strSelectedfilePath);
            FuncReadINI("Data1", grd1);
            FuncReadINI("Data2", grd2);
            FuncReadINI("Data3", grd3);
            FuncReadINI("Data4", grd4);
        }
        private void btnCopy5_Click(object sender, EventArgs e)
        {
            //clsSection[0] = FileListCopy( "Data1");
            //clsSection[1] = FileListCopy( "Data2");
            //clsSection[2] = FileListCopy( "Data3");
            //clsSection[3] = FileListCopy( "Data4");
        }
        //private Section FileListCopy(string strSection)
        //{
        //    string strFilePath = tBoxDir.Text + "\\" + grdFileList.SelectedRows[0].Cells[0].Value.ToString() + ".ini";

        //    Section sc = new Section();
        //    sc._strKeys = GetEntryNames(strSection, strFilePath);
        //    sc._strValues = new string[sc._strKeys.Length];
        //    StringBuilder strbValue = new StringBuilder(255);

        //    // 파일 내부 내용 유무 확인
        //    if (sc._strKeys[0].Length > 0) {
        //        for (int i = 0; i < sc._strKeys.Length; i++) {
        //            // value 값 읽어서 Section 클래스 멤버에 넣기
        //            GetPrivateProfileString(strSection, sc._strKeys[i].ToString(), "", strbValue, 255, strFilePath);
        //            sc._strValues[i] = strbValue.ToString();
        //        }
        //    }
        //    return sc;
        //}
        private void btnPaste5_Click( object sender, EventArgs e )
        {
        }
        private void btnLoad_Click( object sender, EventArgs e )
        {
        }
        public string[] GetEntryNames( string section, string path )   // 해당 section 안의 모든 키 값 가져오기       
        {
            for( int maxsize = 500; true; maxsize *= 2 ) 
            {
                byte[] bytes = new byte[ maxsize ];
                int size = GetPrivateProfileString( section, 0, "", bytes, maxsize, path );

                if( size < maxsize - 2 ) 
                {
                    string entries = Encoding.ASCII.GetString( bytes, 0, size - ( size > 0 ? 1 : 0 ) );
                    return entries.Split( new char[] { '\0' } );
                }
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if ( DialogResult.OK == MessageBox.Show("Would you like to set file " + grdFileList.SelectedRows[0].Cells[0].Value.ToString() + "?", "Confirmation", MessageBoxButtons.OKCancel) ) 
            {
                tBoxCurFile.Text = grdFileList.Rows[grdFileList.SelectedRows[0].Index].Cells[0].Value.ToString();
            }
        }
        private void RowsRemove(DataGridView dgvGrid)
        {
            if (dgvGrid.Rows.Count > 0) 
            {
                while (dgvGrid.Rows.Count != 0) 
                {
                    dgvGrid.Rows.RemoveAt(dgvGrid.Rows.Count - 1);
                }
            }
        }

        private void grdFileList_Click(object sender, EventArgs e)
        {
            if( iSelectedRow != grdFileList.SelectedRows[0].Index ) 
            {
                RowsRemove(grd1); FuncReadINI("Data1", grd1);
                RowsRemove(grd2); FuncReadINI("Data2", grd2);
                RowsRemove(grd3); FuncReadINI("Data3", grd3);
                RowsRemove(grd4); FuncReadINI("Data4", grd4);
            }
            iSelectedRow = grdFileList.SelectedRows[0].Index;
        }

        private void LogPrint(string str1, string str2, string str3)
        {
            lBoxLog.Items.Add( str1 + str2 + str3 );
        }
    }
}
