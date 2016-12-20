using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EnergySaver_CsProject
{
    //enum CMD
    //{
    //    Write,
    //    Read
    //};
    public enum MODE
    {
        MonitorOff,
        Stanby,
        MaxSave
    };
    //enum ACTION
    //{
    //    Wakeup,
    //    Sleep,  //모니터 끄기
    //    Shutdown,   //전원 종료
    //    Suspend,    //대기 모드
    //    Hibernate   //최대 절전 모드
    //};
    public class Processor
    {
        #region 저장되는 설정 변수
        bool reRun = false;
        string id = "2011112289";
        string ip = "210.94.194.100";
        string portNum = "20151"; //port번호
        string pathCurrentOption = "currentOption.txt";    //옵션 저장 경로
        string[] hotkey;// = new string[4];   //단축키 설정

        int autoRunTimeIndex;   //자동 실행시간 = value * 5min
        int dailyTimeHour;      //0시 ~ 23시
        int dailyTimeMin;       //valut * 10min

        MODE mode;
        #endregion

        string pathCMD = "C:\\Users\\Lee Shin Woo\\Desktop\\C#\\nircmd-x64\\nircmd.exe";
        string serverLog;
        string pathDefaultOption = "defaultOption.txt";
        bool monitorSleep = false;

        System.Windows.Forms.Timer autoRunTimer;
        System.Windows.Forms.Timer dailyRunTimer;

        int autoRunCount;
        double dailyRunCount;

        OptionForm of;

        public delegate void AutoRunDelegate();

        public bool ReRun
        {
            get
            {
                return reRun;
            }
            set
            {
                reRun = value;
            }
        }
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string IP
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }
        public string PortNUM
        {
            get
            {
                return portNum;
            }
            set
            {
                portNum = value;
            }
        }
        public MODE Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }
        public int AutoRunTimeIndex
        {
            get
            {
                return autoRunTimeIndex;
            }
            set
            {
                autoRunTimeIndex = value;
            }
        }
        public int DailyTimeHour
        {
            get
            {
                return dailyTimeHour;
            }
            set
            {
                dailyTimeHour = value;
            }
        }
        public int DailyTimeMin
        {
            get
            {
                return dailyTimeMin;
            }
            set
            {
                dailyTimeMin = value;
            }
        }
        public string ServerLog
        {
            get
            {
                return serverLog;
            }
            set
            {
                serverLog = value;
            }
        }
        public string[] HotKey
        {
            get
            {
                return hotkey;
            }
            set
            {
                hotkey = value;
            }
        }
        public string pathDefaultSetting
        {
            get
            {
                return pathDefaultOption;
            }
        }
        public Processor()
        {
            hotkey = new string[4];
            hotkey[0] = hotkey[1] = hotkey[2] = hotkey[3] = "11";
            loadSettingFromCurrnet();
        }
        public Processor(OptionForm op) : this()
        {
            of = op;
            autoRunTimer = new System.Windows.Forms.Timer();
            dailyRunTimer = new System.Windows.Forms.Timer();

            autoRunTimer.Interval = dailyRunTimer.Interval = 1000;//1000ms초 단위로
            autoRunTimer.Tick += new EventHandler(autoRunCountDown);
            dailyRunTimer.Tick += new EventHandler(dailyRunCountDown);
            TimerSetting();
            autoRunTimer.Start();
            dailyRunTimer.Start();
        }
        //regist UserID
        private string registerUser(string _id)
        {
            String resultStr;
            String URL = "http://" + ip + ":" + portNum +"/registerUser.asp";
            String message = "id=" + _id;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            byte[] sendData = UTF8Encoding.UTF8.GetBytes(message);
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.ContentLength = sendData.Length;
            request.Method = "POST";

            StreamWriter sw = new StreamWriter(request.GetRequestStream());
            sw.Write(message);
            sw.Close();

            HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
            resultStr = streamReader.ReadToEnd();
            streamReader.Close();
            httpWebResponse.Close();
            return resultStr;
        }
        //get Log
        private string log(string _cmd, string _action)
        {
            String resultStr;
            String URL = "http://" + ip + ":" + portNum + "/log.asp";
            String message = "id=" + id + "&cmd=" + _cmd + "&action=" + _action;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            byte[] sendData = UTF8Encoding.UTF8.GetBytes(message);
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.ContentLength = sendData.Length;
            request.Method = "POST";

            StreamWriter sw = new StreamWriter(request.GetRequestStream());
            sw.Write(message);
            sw.Close();

            HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
            resultStr = streamReader.ReadToEnd();
            streamReader.Close();
            httpWebResponse.Close();
            return resultStr;
        }
        //cmd = sleep 모니터 끄기
        public void monitorOff()
        {
            string result = log("write", "sleep");  //id=학번&cmd=write&action=sleep를 보냄
            if (result == "OK")
            {
                MessageBox.Show("기록완료");
                serverLog = log("read", "sleep");   //id=학번&cmd=read&action=sleep를 보냄 & log 박스 갱신
                //Process.Start(fileName: pathCMD, arguments: "monitor off");   //monitor off
                MessageBox.Show("모니터 끄기");
                monitorSleep = true;
            }
            else
            {
                MessageBox.Show(result);    //실행 결과를 출력
            }
            
        }
        public void monitorOn()
        {
            if (monitorSleep)
            {
                string result = log("write", "wakeup"); //id=학번&cmd=write&action=wakeup를 보냄
                if (result == "OK")
                {
                    monitorSleep = false;
                    serverLog = log("read", "wakeup");  //id=학번&cmd=read&action=wakeup를 보냄 & log 박스 갱신
                }
                else
                {
                    MessageBox.Show(result);    //실행 결과를 메시지박스로 출력
                }
            }
        }
        //cmd = shutdown 전원 종료
        public void turnOff()
        {
            string result = log("write", "shutdown");   //id=학번&cmd=write&action=shutdown를 보냄
            if (result == "OK")
            {
                MessageBox.Show("기록 완료");
                serverLog = log("read", "shutdown");    //id=학번&cmd=read&action=shutdown를 보냄 & log 박스 갱신
                //Process.Start(fileName: path, arguments: "mutesysvolume 2");  //볼륨 음소거 토글
                //Process.Start(fileName: pathCMD, arguments: "exitwin poweroff"); //컴퓨터 종료
                MessageBox.Show("turnOff");
            }
            else
            {
                MessageBox.Show(result);    //실행 결과를 메시지 박스로 출력
            }

        }
        //cmd = suspend 대기모드
        public void standby()
        {
            string result = log("write", "suspend");
            if (result == "OK")
            {
                MessageBox.Show("기록완료");
                serverLog = log("read", "suspend");
                //Process.Start(fileName: pathCMD, arguments: "standby force");
                MessageBox.Show("절전모드");
            }
            else
            {
                MessageBox.Show(result);
            }
        }
        //cmd = hibernate 최대절전모드
        public void savePower()
        {
            string result = log("write", "hibernate");
            if (result == "OK")
            {
                MessageBox.Show("기록완료");
                serverLog = log("read", "sleep");
                //Process.Start(fileName: "rundll32", arguments: "powrprof.dll, SetSuspendState");
                MessageBox.Show("최대 절전");
            }
            else
            {
                MessageBox.Show(result);
            }
        }
        //설정된 mode에 따라서 기능 실행
        public void ExecuteMode()
        {
            switch (mode)
            {
                case MODE.MonitorOff:
                    monitorOff();
                    break;
                case MODE.Stanby:
                    standby();
                    break;
                case MODE.MaxSave:
                    savePower();
                    break;
            }
        }
        //설정을 string[]으로 변환
        public string[] SetingToStringArr()
        {
            string[] str = new string[13];
            str[0] = reRun.ToString();
            str[1] = id.ToString();
            str[2] = ip.ToString();
            str[3] = portNum.ToString();
            str[4] = pathCurrentOption.ToString();
            str[5] = hotkey[0].ToString();
            str[6] = hotkey[1].ToString();
            str[7] = hotkey[2].ToString();
            str[8] = hotkey[3].ToString();
            str[9] = autoRunTimeIndex.ToString();
            str[10] = dailyTimeHour.ToString();
            str[11] = dailyTimeMin.ToString();
            switch (mode)
            {
                case MODE.MonitorOff:
                    str[12] = "0";
                    break;
                case MODE.Stanby:
                    str[12] = "1";
                    break;
                case MODE.MaxSave:
                    str[12] = "2";
                    break;
            }
            return str;
        }
        //string[]을 설정으로 변환
        public void SetingFromStringArr(string[] str)
        {
            if (str[0].Equals("True"))
            {
                reRun = true;
            }
            else
            {
                reRun = false;
            }
            id = str[1];
            ip = str[2];
            portNum = str[3];
            pathCurrentOption = str[4];
            hotkey[0] = str[5];
            hotkey[1] = str[6];
            hotkey[2] = str[7];
            hotkey[3] = str[8];
            autoRunTimeIndex = Int32.Parse(str[9]);
            dailyTimeHour = Int32.Parse(str[10]);
            dailyTimeMin = Int32.Parse(str[11]);
            switch (str[12])
            {
                case "0":
                    mode = MODE.MonitorOff;
                    break;
                case "1":
                    mode = MODE.Stanby;
                    break;
                case "2":
                    mode = MODE.MaxSave;
                    break;
            }
        }
        //DefaultPath로 부터 옵션 로딩
        public void loadSettingFromDefault()
        {
            if (File.Exists(pathDefaultSetting))
            {
                string[] tmp = File.ReadAllLines(pathDefaultSetting);
                SetingFromStringArr(tmp);
            }
        }
        //CurrentPath로부터 옵션 로딩
        public void loadSettingFromCurrnet()
        {
            if (File.Exists(pathCurrentOption))
            {
                string[] tmp = File.ReadAllLines(pathCurrentOption);
                SetingFromStringArr(tmp);
            }

        }
        public void TimerSetting()
        {
            autoRunCountSetting();
            dailyRunCountSetting();
        }
        void autoRunCountSetting()
        {
            autoRunCount = autoRunTimeIndex * 5 * 60;   //autoRunCount초 이후 실행
            of.ToolProgressBar.Maximum = autoRunCount;
        }
        void dailyRunCountSetting()
        {
            DateTime todayTime;
            DateTime targetTime = new DateTime(
                DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,
                dailyTimeHour, dailyTimeMin * 10, DateTime.Today.Second);
            todayTime = DateTime.Today;
            if(dailyTimeHour < todayTime.Hour)
            {
                targetTime.Add(new TimeSpan(1, 0, 0, 0));
            }
            TimeSpan subTime = targetTime - todayTime;

            dailyRunCount = subTime.TotalSeconds;
        }
        void autoRunCountDown(object sender, EventArgs e)
        {
            autoRunCount--;
            of.ToolProgressBar.Value++;
            if(autoRunCount <= 0)
            {
                autoRunTimer.Stop();
                ExecuteMode();
            }
        }
        void dailyRunCountDown(object sender, EventArgs e)
        {
            dailyRunCount--;
            of.ToolLabelDaily.Text = "매일 종료 : " +
                dailyRunCount / (60 * 60) + "h" +
                (dailyRunCount % (60 * 60)) / 60 + "m" +
                dailyRunCount % 60;
            if (dailyRunCount <= 0)
            {
                dailyRunTimer.Stop();
                turnOff();
            }
        }

    }
}
