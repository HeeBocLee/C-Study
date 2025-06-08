using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StopwatchTimer
{
    public partial class StopwatchTimer : Form
    {
        public StopwatchTimer()
        {
            InitializeComponent();
        }

        int iHour       = 0,
            iMinute     = 0,
            iSecond     = 0,
            iMiliSec    = 0,
            iSlowest    = 0,
            iFastest    = 0,
            iSlowestRow = 0,
            iFastestRow = 0;

        Stopwatch stopwatch;
        Thread thrd;
        bool bIsStarted = false;

        private void StopwatchTimer_Load(object sender, EventArgs e)
        {
            lblTime.Text = "00:00:00.0";
            stopwatch = new Stopwatch();
            thrd = new Thread(OnElapsed);
            thrd.IsBackground = true;
            thrd.Start();
            pBoxFlag.Enabled = false;
        }

        private void pBoxStart_Click(object sender, EventArgs e)
        {
            if (!bIsStarted) TimerStart();
            else TimerPause();
        }

        private void pBoxFlag_Click(object sender, EventArgs e)
        {
            int iRowCount = lViewRecord.Items.Count;
            int iRowNum = iRowCount + 1;

            // 시간 비교용 저장 변수
            int iTimeDataNow    = 0,
                iTimeDataLast   = 0,
                iCurSpan        = 0;

            string strDT = "";
            DateTime dt;

            // Row 간격 설정
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 50);
            lViewRecord.SmallImageList = imgList;

            // 현재 시간 DateTime 타입으로 가져오기
            dt = DateTime.Parse(lblTime.Text);
            iTimeDataNow = DateTimeToMiliSec(dt);

            // 기록 시간 DateTime 타입으로 가져오기
            // 첮줄 시 0 으로 입력
            if (iRowCount > 0) dt = DateTime.Parse(lViewRecord.Items[iRowCount - 1].SubItems[3].Text);
            else dt = DateTime.Parse("00:00:00.0");
            iTimeDataLast = DateTimeToMiliSec(dt);

            // 시간 차 계산 밋 결과 값 가져오기
            strDT = GetSpanTimeData(iTimeDataNow - iTimeDataLast);

            // 현재 경과 시간 Mili초 단위로 계산 밋 int 타입으로 가져오기
            dt = DateTime.Parse(strDT);
            iCurSpan = DateTimeToMiliSec(dt);

            // 줄 추가
            lViewRecord.Items.Add(new ListViewItem(new string[] { iRowNum.ToString(), "", strDT, lblTime.Text }));

            if (lViewRecord.Items.Count == 1)
            {
                // 첫째 줄일 때 Max Min 에 현재값을 삽입
                iFastest = iSlowest = iCurSpan;
            }
            if (lViewRecord.Items.Count == 2) 
            {
                if (iCurSpan > iFastest)
                {
                    lViewRecord.Items[0].SubItems[1].Text = "Fastest";
                    iFastestRow = 0;
                    lViewRecord.Items[1].SubItems[1].Text = "Slowest";
                    iSlowestRow = 1;
                }
                else
                {
                    lViewRecord.Items[0].SubItems[1].Text = "Slowest";
                    iSlowestRow = 0;
                    lViewRecord.Items[1].SubItems[1].Text = "Fastest";
                    iFastestRow = 1;
                }
             }

            if (lViewRecord.Items.Count > 2)
            {
                if (iCurSpan > iSlowest)
                {
                    iSlowest = iCurSpan;
                    lViewRecord.Items[iSlowestRow].SubItems[1].Text = "";
                    iSlowestRow = iRowCount;
                    lViewRecord.Items[iSlowestRow].SubItems[1].Text = "Slowest";
                }
                if (iCurSpan < iFastest)
                {
                    iFastest = iCurSpan;
                    lViewRecord.Items[iFastestRow].SubItems[1].Text = "";
                    iFastestRow = iRowCount;
                    lViewRecord.Items[iFastestRow].SubItems[1].Text = "Fastest";
                }
            }

        }

        private void pBoxReset_Click(object sender, EventArgs e)
        {
            TimerPause();
            lblTime.Text = "";
            lViewRecord.Items.Clear();
            iHour = 0;
            iMinute = 0;
            iSecond = 0;
            iMiliSec = 0;
        }

        private void OnElapsed()
        {
            while (true)
            {
                if (stopwatch.ElapsedMilliseconds == 100 && bIsStarted)
                {
                    iMiliSec++;
                    if (iMiliSec == 10) { iSecond++; iMiliSec = 0; }
                    if (iSecond == 60) { iMinute++; iSecond = 0; }
                    if (iMinute == 60) { iHour++; iMinute = 0; }
                    if (iHour == 24) { iHour = 0; }
                    string strTime = iHour.ToString("00") + ":" + iMinute.ToString("00") + ":" + iSecond.ToString("00") + "." + iMiliSec.ToString();

                    lblTime.Invoke(new Action(() => { lblTime.Text = strTime; }));
                    stopwatch.Restart();
                }
            }
        }

        private int DateTimeToMiliSec(DateTime datetime)
        {
            int iHour = int.Parse(datetime.ToString("HH"));
            int iMin = int.Parse(datetime.ToString("mm"));
            int iSec = int.Parse(datetime.ToString("ss"));
            int iMiliSec = int.Parse(datetime.ToString("fff"));
            return ((iHour * 60 + iMin) * 60 + iSec) * 1000 + iMiliSec;
        }

        private string GetSpanTimeData(int spanMiliSec)
        {
            int iHour = spanMiliSec / (1000 * 60 * 60);
            int itemp = spanMiliSec % (1000 * 60 * 60);

            int iMin = itemp / (1000 * 60);
            itemp = itemp % (1000 * 60);

            int iSec = itemp / 1000;
            int iMiliSec = itemp % 1000 / 100;

            return iHour.ToString("00") + ":" + iMin.ToString("00") + ":" + iSec.ToString("00") + "." + iMiliSec.ToString();
        }

        private void TimerStart()
        {
            bIsStarted = true;

            lblTime.ForeColor = Color.Black;
            stopwatch.Start();

            pBoxStart.Image = Image.FromFile("D:\\SuitLee\\Downloads\\pause.png");

            pBoxFlag.Enabled = true;
            pBoxFlag.Image = Image.FromFile("D:\\SuitLee\\Downloads\\flagEnable.png");
        }

        private void TimerPause()
        {
            bIsStarted = false;

            lblTime.ForeColor = Color.FromArgb(100, 100, 100);
            stopwatch.Stop();

            pBoxStart.Image = Image.FromFile("D:\\SuitLee\\Downloads\\play.png");

            pBoxFlag.Enabled = false;
            pBoxFlag.Image = Image.FromFile("D:\\SuitLee\\Downloads\\flagUnable.png");
        }
    }
}
