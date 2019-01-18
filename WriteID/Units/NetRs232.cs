﻿using System;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WriteID.Lib;

namespace WriteID.Units
{
    public partial class NetRs232 : UserControl
    {
        private SerialPort ComDevice = new SerialPort();

        public NetRs232()
        {
            InitializeComponent();
            drpComList.Items.AddRange(SerialPort.GetPortNames());
            if (drpComList.Items.Count > 0)
            {
                drpComList.SelectedIndex = 0;
                btnCom.Enabled = true;
            }
            picComStatus.BackgroundImage = Properties.Resources.redlight;
            drpBaudRate.SelectedIndex = 11;
            drpParity.SelectedIndex = 0;
            drpDataBits.SelectedIndex = 0;
            drpStopBits.SelectedIndex = 0;
            ComDevice.RtsEnable = true;
            ComDevice.DtrEnable = true;
            ComDevice.ReceivedBytesThreshold = 1;
            ComDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);
        }

        /// <summary>
        /// 输出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            DataReceived(this, ReDatas);//输出数据
        }

        /// <summary>
        /// 串口打开/关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCom_Click(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen == false)
            {
                ComDevice.PortName = drpComList.SelectedItem.ToString();
                ComDevice.BaudRate = Convert.ToInt32(drpBaudRate.SelectedItem.ToString());
                ComDevice.Parity = (Parity)Convert.ToInt32(drpParity.SelectedIndex.ToString());
                ComDevice.DataBits = Convert.ToInt32(drpDataBits.SelectedItem.ToString());
                ComDevice.StopBits = (StopBits)Convert.ToInt32(drpStopBits.SelectedItem.ToString());
                try
                {
                    ComDevice.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnCom.Text = "关闭串口";
                picComStatus.BackgroundImage = Properties.Resources.greenlight;
            }
            else
            {
                try
                {
                    ComDevice.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnCom.Text = "打开串口";
                picComStatus.BackgroundImage = Properties.Resources.redlight;
            }

            drpComList.Enabled = !ComDevice.IsOpen;
            drpBaudRate.Enabled = !ComDevice.IsOpen;
            drpParity.Enabled = !ComDevice.IsOpen;
            drpDataBits.Enabled = !ComDevice.IsOpen;
            drpStopBits.Enabled = !ComDevice.IsOpen;
        }

        public event LeafEvent.DataReceivedHandler DataReceived;
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    ComDevice.Write(data, 0, data.Length);//发送数据
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        public bool SendData(string  data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    ComDevice.Write(data);//发送数据
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }



        /// <summary>
        /// 关闭串口
        /// </summary>
        public void ClearSelf()
        {
            if (ComDevice.IsOpen)
            {
                ComDevice.Close();
            }
        }










    }
}
