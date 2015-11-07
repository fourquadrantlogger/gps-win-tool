using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace GPS串口软件
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
            说话啦 = new System.Speech.Synthesis.SpeechSynthesizer();
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            comboBoxCOMName.Items.AddRange(ports);

            GraphPane 经纬Pane = 经纬view.GraphPane;
            经纬Pane.Title.Text = "轨迹点（经、纬）实时显示";
            经纬Pane.XAxis.Title.Text = "经度";
            经纬Pane.YAxis.Title.Text = "纬度";
            LineItem 经纬Curve = 经纬Pane.AddCurve("轨迹", 经纬Pointlist, Color.Red, SymbolType.Diamond);
            经纬view.AxisChange();

            GraphPane XYPane = XYview.GraphPane;
            XYPane.Title.Text = "轨迹点（X、Y）实时显示";
            XYPane.XAxis.Title.Text = "X";
            XYPane.YAxis.Title.Text = "Y";
            LineItem XYCurve = XYPane.AddCurve("轨迹", 经纬Pointlist, Color.Blue, SymbolType.Diamond);
            XYview.AxisChange();
        }
        PointPairList 经纬Pointlist = new PointPairList();
        PointPairList XYPointlist = new PointPairList();
        System.Speech.Synthesis.SpeechSynthesizer 说话啦;
        #region 事件
        private void 打开_Click(object sender, EventArgs e)
        {        
            try
            {
                Port_GPS = new System.IO.Ports.SerialPort(comboBoxCOMName.Text, Convert.ToInt32(comboBoxCOM波特率.Text));
                Port_GPS.Open();
                filepath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\GPS" + DateTime.Now.ToString().Replace(':', ' ').Replace('/', ' ') + ".dat";
                Receive = new Thread(new ThreadStart(this.ThreadTask));
                Receive.IsBackground = true;
                Receive.Start();
                lastReceive = DateTime.Now;
                说话啦.SpeakAsync("串口打开成功,GPS原始数据已自动保存在桌面");

            }
            catch
            {
                说话啦.SpeakAsync("串口未能打开");
            }
        }
        private void comboBoxCOM波特率_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port_GPS.IsOpen == false)
            {
                Port_GPS = new System.IO.Ports.SerialPort(comboBoxCOMName.Text, Convert.ToInt32(comboBoxCOM波特率.Text));
            }
            else
            {
                try
                {
                    Port_GPS.BaudRate = Convert.ToInt32(comboBoxCOM波特率.Text);
                    说话啦.SpeakAsync("串口当前波特率是：" + Port_GPS.BaudRate.ToString());
                }
                catch
                {
                    说话啦.SpeakAsync("串口波特率修改失败");
                }
            }
        }
        private void 关闭_Click(object sender, EventArgs e)
        {
            try
            {
                Receive.Abort();
                Port_GPS.Close();
            }
            catch
            {
                说话啦.SpeakAsync("串口未能关闭");
            }
        }
        #endregion
        #region 接收
        Thread Receive;
        string[] temp;
        string filepath;
        public delegate void 我的委托();//声明一个委托 
        DateTime lastReceive;
        private void ThreadTask()
        {
            try
            {
                while (Port_GPS.IsOpen)
                {
                    string 原始数据 = Port_GPS.ReadLine();
                    if (DateTime.Now - lastReceive > new TimeSpan(0, 0, 3))
                    {
                        说话啦.SpeakAsync("已经有3秒没有正常收到数据");
                    }
                    lastReceive = DateTime.Now;
                    System.IO.File.AppendAllText(filepath, 原始数据 + "\r\n");
                    temp = 原始数据.Split(',');
                    GPSdata.BeginInvoke(new 我的委托(renderGPSdata));
                }
            }
            catch
            {

            }
        }
        #endregion
        #region 显示及处理
        int 经index, 纬index;
        public void renderGPSdata()
        {
            if (temp.Length - GPSdata.Rows.Count > 0) GPSdata.Rows.Add(temp.Length - GPSdata.Rows.Count);
            double 经 = 0, 纬 = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                GPSdata[0, i].Value = i;
                GPSdata[1, i].Value = temp[i];
            }
            if (经index != 0 && 纬index != 0)
                {
                    经 = Convert.ToDouble(GPSdata[1, 经index].Value);
                    纬 = Convert.ToDouble(GPSdata[1, 纬index].Value);
                    经纬Pointlist.Add(经, 纬);
                    经纬view.AxisChange();
                    经纬view.Refresh();
                }          
        }
        #endregion
        private void comboBox经_DropDown(object sender, EventArgs e)
        {
            comboBox经.Items.Clear();
            for (int i = 0; i < GPSdata.Rows.Count; i++)
            {
                comboBox经.Items.Add(i);
            }
        }
        private void comboBox纬_DropDown(object sender, EventArgs e)
        {
            comboBox纬.Items.Clear();
            for (int i = 0; i < GPSdata.Rows.Count; i++)
            {

                comboBox纬.Items.Add(i);
            }
        }
        private void button经纬_Click(object sender, EventArgs e)
        {
            if (comboBox经.SelectedItem != null && comboBox纬.SelectedItem != null)
            {
                经index = comboBox经.SelectedIndex;
                纬index = comboBox纬.SelectedIndex;
            }
        }
    }
}
