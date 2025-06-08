using System.Data;
using System.IO;
using System.Text;

using System.Runtime.InteropServices;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;


namespace iniFileTest
{
    public partial class Form1 : Form
    {
        private string _striniPath = @"D:\\iniFileTest.ini";
        string _readFile = @"D:\\csvFileTest.csv";
        string _writeFile = @"D:\\csvFileTest.csv";
        FileStream _fsOpen, _fsCreate;
        StreamReader _sr;
        StreamWriter _wr2;

        List<string> strList = new List<string>();

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(string section, string key, string val, string filePath);

        public Form1()
        {
            InitializeComponent();
            GetiniValues();
        }
        private void GetiniValues() // 초기화
        {
            tBoxFruit_001.Text = GetiniValue("Fruit", "001", 30, _striniPath);
            tBoxFruit_002.Text = GetiniValue("Fruit", "002", 30, _striniPath);
            tBoxFruit_003.Text = GetiniValue("Fruit", "003", 30, _striniPath);
            tBoxCar_001.Text = GetiniValue("Car", "001", 30, _striniPath);
            tBoxCar_002.Text = GetiniValue("Car", "002", 30, _striniPath);
            tBoxCar_003.Text = GetiniValue("Car", "003", 30, _striniPath);
        }
        // Read
        public string GetiniValue(string section, string key, int valueCapacity, string filePath)
        {
            string strReturnValue;
            StringBuilder tmp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", tmp, 255, filePath);
            strReturnValue = tmp.ToString();
            return strReturnValue;
        }
        // Write
        //public static void SetiniValue(string section, string key, string value, string filePath)
        //{
        //    WritePrivateProfileString(section, key, value, filePath);
        //}
        // Fruit Save Button
        private void btnFruitSave_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("Fruit", "001", tBoxFruit_001.Text, _striniPath);
            WritePrivateProfileString("Fruit", "002", tBoxFruit_002.Text, _striniPath);
            WritePrivateProfileString("Fruit", "003", tBoxFruit_003.Text, _striniPath);
        }
        // Car Save Button
        private void btnCarSave_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("Car", "001", tBoxCar_001.Text, _striniPath);
            WritePrivateProfileString("Car", "002", tBoxCar_002.Text, _striniPath);
            WritePrivateProfileString("Car", "003", tBoxCar_003.Text, _striniPath);
        }

        private void btnWriteCSV_Click(object sender, EventArgs e)
        {
            _fsCreate = new FileStream(_writeFile, FileMode.Create);
            _wr2 = new StreamWriter(_fsCreate, Encoding.UTF8);
            strList.Add("첫째줄,A,B,C,D");
            strList.Add("둘째줄");
            strList.Add("셋째줄");
            for (int i = 0; i < strList.Count; i++)
            {
                _wr2.WriteLine(strList[i]);
                Console.WriteLine(strList[i]);

                // 중간에 제거할 목록이 있을 시 
                //if (i != 해당 번호)
                //{}
            }

            _wr2.WriteLine("Finish");     // 마지막 줄에 텍스트 추가
            _wr2.Close();
        }
        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            _fsOpen = new FileStream(_readFile, FileMode.OpenOrCreate);
            _sr = new StreamReader(_fsOpen, Encoding.UTF8, false);
            
            while (!_sr.EndOfStream)
            {
                string s = _sr.ReadLine();
                //string[] temp = s.Split(',');
                string[] temp = s.Split(',');
                
                
                strList.Add(s);
            }
            return;
        }
    }
}
