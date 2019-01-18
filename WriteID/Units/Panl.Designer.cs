namespace WriteID.Units
{
    partial class Panl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.netRs2321 = new WriteID.Units.NetRs232();
            this.dataSend1 = new WriteID.Units.DataSend();
            this.dataReceive1 = new WriteID.Units.DataReceive();
            this.historicalRecord1 = new WriteID.Units.HistoricalRecord();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.47881F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.01986F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.50596F));
            this.tableLayoutPanel1.Controls.Add(this.netRs2321, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataSend1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataReceive1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.historicalRecord1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // netRs2321
            // 
            this.netRs2321.Location = new System.Drawing.Point(3, 2);
            this.netRs2321.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.netRs2321.Name = "netRs2321";
            this.netRs2321.Size = new System.Drawing.Size(213, 245);
            this.netRs2321.TabIndex = 0;
            this.netRs2321.DataReceived += new WriteID.Lib.LeafEvent.DataReceivedHandler(this.netRs2321_DataReceived);
            // 
            // dataSend1
            // 
            this.dataSend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSend1.Id = null;
            this.dataSend1.Location = new System.Drawing.Point(225, 5);
            this.dataSend1.Margin = new System.Windows.Forms.Padding(5);
            this.dataSend1.Name = "dataSend1";
            this.dataSend1.SigfoxId = null;
            this.dataSend1.SigfoxPac = null;
            this.dataSend1.Size = new System.Drawing.Size(304, 240);
            this.dataSend1.TabIndex = 1;
            this.dataSend1.EventDataSend += new WriteID.Lib.LeafEvent.DataSendHandler(this.dataSend1_EventDataSend);
            this.dataSend1.EventDataSendOfString += new WriteID.Lib.LeafEvent.DataSendHandlerOfString(this.dataSend1_EventDataSendOfString);
            this.dataSend1.EventDataSave += new WriteID.Lib.LeafEvent.Savedata(this.dataSend1_EventDataSave);
            // 
            // dataReceive1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dataReceive1, 2);
            this.dataReceive1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataReceive1.Location = new System.Drawing.Point(5, 255);
            this.dataReceive1.Margin = new System.Windows.Forms.Padding(5);
            this.dataReceive1.Name = "dataReceive1";
            this.dataReceive1.Size = new System.Drawing.Size(524, 240);
            this.dataReceive1.TabIndex = 2;
            // 
            // historicalRecord1
            // 
            this.historicalRecord1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historicalRecord1.Location = new System.Drawing.Point(537, 3);
            this.historicalRecord1.Name = "historicalRecord1";
            this.tableLayoutPanel1.SetRowSpan(this.historicalRecord1, 2);
            this.historicalRecord1.Size = new System.Drawing.Size(719, 494);
            this.historicalRecord1.TabIndex = 3;
            // 
            // Panl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Panl";
            this.Size = new System.Drawing.Size(1259, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private NetRs232 netRs2321;
        private DataSend dataSend1;
        private DataReceive dataReceive1;
        private HistoricalRecord historicalRecord1;
    }
}
