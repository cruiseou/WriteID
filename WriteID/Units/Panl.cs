using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteID.Units
{
    public partial class Panl : UserControl
    {
        public Panl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 发送字节流
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private bool dataSend1_EventDataSend(byte[] data)
        {
            return netRs2321.SendData(data);
        }

        /// <summary>
        /// 发送字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private bool dataSend1_EventDataSendOfString(string data)
        {
            return netRs2321.SendData(data);
        }

        /// <summary>
        /// 数据接收展示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void netRs2321_DataReceived(object sender, byte[] data)
        {
            dataReceive1.AddData(data);
            dataSend1.IsSuccessWriteID(data);
        }

        private bool dataSend1_EventDataSave(string ID, string SIGFOX_ID, string SIGFOX_PAC)
        {
            return historicalRecord1.Savedata(ID, SIGFOX_ID, SIGFOX_PAC);
        }
    }
}
