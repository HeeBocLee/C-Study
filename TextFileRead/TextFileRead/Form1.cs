using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextFileRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInspDir_Click(object sender, EventArgs e)
        {
            GetTextFile(1, @"E:\B12_ULami\B12_LAMI_NG率\250526\INPECTION\2025-05-26", "Spec out", "[ CAMERA_LAMI_INSPECTION_", "PANEL_ID", false);
        }

        private void btnMainDir_Click(object sender, EventArgs e)
        {
            GetTextFile(2, @"E:\B12_ULami\B12_LAMI_NG率\250526\MAIN\2025-05-26", "score", "CAMERA_LAMI_MAIN_", "MATERIAL_ID", false);
        }

        private void btnPreDir_Click(object sender, EventArgs e)
        {
        }
        private void GetTextFile(int listviewIdx, string pathINI, string Keyword, string Errkeyword, string IDtype, bool film)    // listviewIdx 1: INSP 2: MAIN 3: PRE
        {
            switch (listviewIdx)
            {
                case 1: lViewOutInsp.Items.Clear(); tBoxInspNGCnt.Clear(); break;
                case 2: lViewOutMain.Items.Clear(); tBoxMainNGCnt.Clear(); break;
                case 3: lViewOutPre.Items.Clear(); tBoxPreNGCnt.Clear(); break;
            }
            string fileContant = string.Empty;
            string strFilePath = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = pathINI;
                ofd.Filter = "txt files (*.txt) | *.txt | All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    strFilePath = ofd.FileName;
                    if (File.Exists(strFilePath))
                    {
                        var AllTextLine = File.ReadAllLines(strFilePath, Encoding.UTF8);
                        int iLineCnt = AllTextLine.Length;
                        int iNo = 1;
                        int iListViewIndex = 0;
                        for (int i = 0; i < iLineCnt; i++)           // row 만큼 반복
                        {
                            int iKeywordIdx = AllTextLine[i].IndexOf(Keyword);       // 키워드 검색         // 다름

                            if (iKeywordIdx != -1)  // 키워드 검색 되였을 시
                            {
                                int iStartIdx, iEndIdx;   // 키워드 앞뒤 잘라야할 문자열 Index

                                iStartIdx = AllTextLine[i].IndexOf(Errkeyword);  // 에러 정보 시작 위치
                                iEndIdx = AllTextLine[i].Length - iStartIdx;  // 에러 정보 끝 위치
                                string ErrInfo = AllTextLine[i].Substring(iStartIdx, iEndIdx);  // 에러 정보 잘라내기
                                int curLineNum = i;
                                int iTextIdx = AllTextLine[curLineNum].IndexOf(IDtype);

                                while (-1 == iTextIdx)      // PanalID 찾을 때 까지 반복
                                {
                                    curLineNum++;
                                    if (curLineNum > iLineCnt - 1) break;   // 마지막 줄 초과 시 while 탈출

                                    iTextIdx = AllTextLine[curLineNum].IndexOf(IDtype);
                                }
                                if (curLineNum <= iLineCnt - 1)
                                {
                                    string PanelID = AllTextLine[curLineNum].Substring(AllTextLine[curLineNum].Length - 17, 17);    // panel ID 잘라내기
                                    string FlimID = "";
                                    if (film) FlimID = FlimID = AllTextLine[curLineNum + 1].Substring(iTextIdx + 10, AllTextLine[curLineNum + 1].Length - iTextIdx - 10);    // flim ID 잘라내기
                                    string number = iNo.ToString();
                                    iNo++;
                                    ListViewItem lvi = new ListViewItem(new string[] { number, PanelID, "", ErrInfo });
                                    switch (listviewIdx)
                                    {
                                        case 1: lViewOutInsp.Items.Add(lvi); iListViewIndex = lViewOutInsp.Items.Count; break;
                                        case 2: lViewOutMain.Items.Add(lvi); iListViewIndex = lViewOutMain.Items.Count; break;
                                        case 3: lViewOutPre.Items.Add(lvi); iListViewIndex = lViewOutPre.Items.Count; break;
                                    }
                                }
                            }
                        }
                        /// 실제 NG된 Cell 갯수 구하기
                        int iIdx = 1;   // 첮항목 비교 안하기 때문에 1부터 시작

                        for (int i = 0; i < iListViewIndex; i++)
                        {
                            if (i == 0) continue;   // 첮 항목 비교 안함
                            int iResult = -1;
                            switch (listviewIdx)
                            {
                                case 1: if (lViewOutInsp.Items[i].SubItems[1].Text != lViewOutInsp.Items[i - 1].SubItems[1].Text) iResult = 1; break;
                                case 2: if (lViewOutMain.Items[i].SubItems[1].Text != lViewOutMain.Items[i - 1].SubItems[1].Text) iResult = 1; break;
                                case 3: if (lViewOutPre.Items[i].SubItems[1].Text != lViewOutPre.Items[i - 1].SubItems[1].Text) iResult = 1; break;
                            }
                            if (iResult != -1)
                            {   // 어전 항목과 같지 않아야 카운팅
                                iIdx++;
                            }
                        }
                        switch (listviewIdx)
                        {
                            case 1: tBoxInspNGCnt.Text = iIdx.ToString(); break;
                            case 2: tBoxMainNGCnt.Text = iIdx.ToString(); break;
                            case 3: tBoxPreNGCnt.Text = iIdx.ToString(); break;
                        }
                    }
                }
            }
        }

        private void lViewOutMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                string text = this.lViewOutMain.SelectedItems[0].SubItems[1].Text + this.lViewOutMain.SelectedItems[0].SubItems[2].Text;
                Clipboard.SetText(text);
            }
        }

        private void lViewOutMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iIdx = 0;
            iIdx = lViewOutMain.SelectedItems[0].Index;
            return;
        }
    }
}
