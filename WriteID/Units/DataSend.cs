using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WriteID.Lib;
    using System.Text.RegularExpressions;
using System.Threading;
/*---------------作者：Maximus Ye----------------------*/
/*---------------时间：2013年8月16日---------------*/
/*---------------邮箱：yq@yyzq.net---------*/
/*---------------QQ：275623749---------*/
/*本软件也耗费了我不少的时间和精力，希望各位同行们尊重个人劳动成果，
 * 如果在此版本的基础上修改发布新的版本，请包含原作者信息（包括代码和UI界面相关信息)，为中国的
 * 开源事业做出一点贡献。*/
namespace WriteID.Units
{
    public partial class DataSend : UserControl
    {

        /// <summary>
        /// 写ID指令
        /// </summary>
        private bool isadd;

        /// <summary>
        /// 标志是否接受到了SIGFOX模块DeviceID和PAC
        /// </summary>
        private bool issuccessreceive;


        private bool isread;


        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string SigfoxId
        {
            get { return sigfox_id; }
            set { sigfox_id = value; }
        }

        public string SigfoxPac
        {
            get { return sigfox_pac; }
            set { sigfox_pac = value; }
        }

        /// <summary>
        /// 写ID指令
        /// </summary>
        public bool Isadd
        {
            get { return isadd; }
            set { isadd = value; }
        }

        /// <summary>
        /// 标志是否接受到了SIGFOX模块DeviceID和PAC
        /// </summary>
        public bool Issuccessreceive
        {
            get { return issuccessreceive; }
            set { issuccessreceive = value; }
        }

        public string sigfox_id;

        public string sigfox_pac;

        public event LeafEvent.DataSendHandler EventDataSend;

        public event LeafEvent.DataSendHandlerOfString EventDataSendOfString;

        public event LeafEvent.Savedata EventDataSave;

        //定义Timer类变量
        System.Timers.Timer Mytimer;
        long TimeCount;
        //定义委托
        public delegate void SetControlValue(long value);

        public DataSend()
        {
            InitializeComponent();
            int interval = 3000;
            Mytimer = new System.Timers.Timer(interval);
            //设置重复计时
            Mytimer.AutoReset = true;
            //设置执行System.Timers.Timer.Elapsed事件

            Mytimer.Elapsed += new System.Timers.ElapsedEventHandler(Mytimer_tick);
            isadd = checkBox1.Checked;
            issuccessreceive = false;
            isread = false;
        }

        private void Mytimer_tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            Mytimer.Stop();
            issuccessreceive = false;
            isread = false;
           // this.Id = string.Empty;
            MessageBox.Show("数据发送超时,请重新写入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Invoke(new MethodInvoker(delegate
            {


                btn_write.Enabled = true;



            }));
            //this.Invoke(new SetControlValue(ShowTime), TimeCount);
            //TimeCount++;
        }

      



        /// <summary>
        /// 写入设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_write_Click(object sender, EventArgs e)
        {
            try
            {

                Mytimer.Start();
                this.Id = txt_ID.Text.Trim();
                if (isadd && issuccessreceive)
                {
                    Id = (Convert.ToInt32(this.Id) + 1).ToString();
                    issuccessreceive = false;
                }

                this.Invoke(new MethodInvoker(delegate { txt_ID.Text = Id; }));


                StringBuilder strID = new StringBuilder();
                strID.AppendLine("AT+ID=" + this.txt_ID.Text.Trim());

                this.Invoke(new MethodInvoker(delegate
                {
                    if (EventDataSendOfString != null)
                    {
                        if (EventDataSendOfString(strID.ToString()) == false)
                        {

                            MessageBox.Show("写ID指令发送错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        btn_write.Enabled = false;

                    }

                }));

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }


        /// <summary>
        /// 读SIGFOX模块DeviceID和PAC
        /// </summary>
        void ReadSIGFOX()
        {
            Mytimer.Start();
            StringBuilder strREAD = new StringBuilder();
            strREAD.AppendLine("AT+READ");
            this.Invoke(new MethodInvoker(delegate
            {
                if (EventDataSendOfString != null)
                {
                    if (EventDataSendOfString(strREAD.ToString()) == false)
                    {

                        MessageBox.Show("读SIGFOX模块指令发送错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    isread = true;

                }

            }));
        }


        public void IsSuccessWriteID(byte[] data)
        {
        
            string result = Encoding.GetEncoding("GB2312").GetString(data);

            if (!string.IsNullOrEmpty(Id))
            {
              
                if (result.Contains(id) && result.Contains("成功"))
                {
                    Mytimer.Stop();
                    ReadSIGFOX();
                    

                }

            }

           if (result.Contains("SIGFOX_ID"))
            {
                if (isread)
                {
                    Mytimer.Stop();
                    SigfoxId = result.Split('=')[1].Split('\\')[0].Substring(0, 8); ;
                }
             
              //  Issuccessreceive = true;
               // this.Invoke(new MethodInvoker(delegate { txt_DeviceID.Text = SigfoxId; }));


            }
          if (result.Contains("SIGFOX_PAC"))
            {
                if (isread)
                {
                    Mytimer.Stop();
                    SigfoxPac = result.Split('=')[1].Split('\\')[0].Substring(0, 16); ;
                }
              
              //  Issuccessreceive = true;
               // this.Invoke(new MethodInvoker(delegate { txt_PAC.Text = SigfoxPac; }));

            }

           
            //else
                //{
                //    this.Invoke(new MethodInvoker(delegate
                //    {

                //        btn_write.Enabled = true;

                //    }));
                //}

                if (!string.IsNullOrEmpty(id)&&!string.IsNullOrEmpty(sigfox_id)&&!string.IsNullOrEmpty(sigfox_pac))
            {
                EventDataSave(id, sigfox_id, sigfox_pac);

                id = sigfox_id = sigfox_pac = String.Empty;
                Issuccessreceive = true;


                this.Invoke(new MethodInvoker(delegate
                {
                   
                        btn_write.Enabled = true;
                    
                }));
                isread = false;

            }
            //else
            //{
            //   Issuccessreceive = false;

            //}
        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Isadd = checkBox1.Checked;
        }
    }
}
