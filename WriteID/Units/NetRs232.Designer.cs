namespace WriteID.Units
{
    partial class NetRs232
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
            this.label1 = new System.Windows.Forms.Label();
            this.drpComList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drpParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drpDataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drpStopBits = new System.Windows.Forms.ComboBox();
            this.picComStatus = new System.Windows.Forms.PictureBox();
            this.btnCom = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "串口";
            // 
            // drpComList
            // 
            this.drpComList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpComList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpComList.FormattingEnabled = true;
            this.drpComList.Location = new System.Drawing.Point(71, 6);
            this.drpComList.Name = "drpComList";
            this.drpComList.Size = new System.Drawing.Size(106, 20);
            this.drpComList.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "波特率";
            // 
            // drpBaudRate
            // 
            this.drpBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpBaudRate.FormattingEnabled = true;
            this.drpBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.drpBaudRate.Location = new System.Drawing.Point(71, 39);
            this.drpBaudRate.Name = "drpBaudRate";
            this.drpBaudRate.Size = new System.Drawing.Size(106, 20);
            this.drpBaudRate.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "校验位";
            // 
            // drpParity
            // 
            this.drpParity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpParity.FormattingEnabled = true;
            this.drpParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.drpParity.Location = new System.Drawing.Point(71, 72);
            this.drpParity.Name = "drpParity";
            this.drpParity.Size = new System.Drawing.Size(106, 20);
            this.drpParity.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 42;
            this.label4.Text = "数据位";
            // 
            // drpDataBits
            // 
            this.drpDataBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDataBits.FormattingEnabled = true;
            this.drpDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.drpDataBits.Location = new System.Drawing.Point(71, 105);
            this.drpDataBits.Name = "drpDataBits";
            this.drpDataBits.Size = new System.Drawing.Size(106, 20);
            this.drpDataBits.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 44;
            this.label5.Text = "停止位";
            // 
            // drpStopBits
            // 
            this.drpStopBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drpStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStopBits.FormattingEnabled = true;
            this.drpStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.drpStopBits.Location = new System.Drawing.Point(71, 138);
            this.drpStopBits.Name = "drpStopBits";
            this.drpStopBits.Size = new System.Drawing.Size(106, 20);
            this.drpStopBits.TabIndex = 45;
            // 
            // picComStatus
            // 
            this.picComStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picComStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picComStatus.Location = new System.Drawing.Point(3, 168);
            this.picComStatus.Name = "picComStatus";
            this.picComStatus.Size = new System.Drawing.Size(62, 29);
            this.picComStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComStatus.TabIndex = 47;
            this.picComStatus.TabStop = false;
            // 
            // btnCom
            // 
            this.btnCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCom.Enabled = false;
            this.btnCom.Location = new System.Drawing.Point(71, 168);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(106, 29);
            this.btnCom.TabIndex = 46;
            this.btnCom.Tag = "0";
            this.btnCom.Text = "打开串口";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.98883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.01117F));
            this.tableLayoutPanel1.Controls.Add(this.drpComList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.drpBaudRate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.drpParity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.drpDataBits, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.drpStopBits, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCom, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.picComStatus, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 200);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // NetRs232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NetRs232";
            this.Size = new System.Drawing.Size(180, 200);
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpStopBits;
        private System.Windows.Forms.PictureBox picComStatus;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
