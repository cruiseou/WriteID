namespace WriteID.Units
{
    partial class DataReceive
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtData = new System.Windows.Forms.TextBox();
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToInt = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToFloat = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ToDouble = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.rbtnGB2312 = new System.Windows.Forms.RadioButton();
            this.CMS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.ContextMenuStrip = this.CMS_Main;
            this.txtData.Location = new System.Drawing.Point(0, 20);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.MaxLength = 1;
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(696, 223);
            this.txtData.TabIndex = 1;
            // 
            // CMS_Main
            // 
            this.CMS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Clear,
            this.MS_ToInt,
            this.MS_ToFloat,
            this.MS_ToDouble});
            this.CMS_Main.Name = "contextMenuStrip1";
            this.CMS_Main.ShowImageMargin = false;
            this.CMS_Main.Size = new System.Drawing.Size(207, 100);
            this.CMS_Main.VisibleChanged += new System.EventHandler(this.CMS_Main_VisibleChanged);
            // 
            // MS_Clear
            // 
            this.MS_Clear.Name = "MS_Clear";
            this.MS_Clear.Size = new System.Drawing.Size(206, 24);
            this.MS_Clear.Text = "清空";
            this.MS_Clear.Click += new System.EventHandler(this.MS_Clear_Click);
            // 
            // MS_ToInt
            // 
            this.MS_ToInt.Name = "MS_ToInt";
            this.MS_ToInt.Size = new System.Drawing.Size(206, 24);
            this.MS_ToInt.Text = "转换为整数(Int)";
            this.MS_ToInt.Click += new System.EventHandler(this.MS_ToInt_Click);
            // 
            // MS_ToFloat
            // 
            this.MS_ToFloat.Name = "MS_ToFloat";
            this.MS_ToFloat.Size = new System.Drawing.Size(206, 24);
            this.MS_ToFloat.Text = "转换为浮点数(Float)";
            this.MS_ToFloat.Click += new System.EventHandler(this.MS_ToFloat_Click);
            // 
            // MS_ToDouble
            // 
            this.MS_ToDouble.Name = "MS_ToDouble";
            this.MS_ToDouble.Size = new System.Drawing.Size(206, 24);
            this.MS_ToDouble.Text = "转换为浮点数(Double)";
            this.MS_ToDouble.Click += new System.EventHandler(this.MS_ToDouble_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "接收字节数：";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(101, 246);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 15);
            this.lblCount.TabIndex = 6;
            this.lblCount.TabStop = true;
            this.lblCount.Text = "0";
            this.lblCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCount_LinkClicked);
            // 
            // rbtnGB2312
            // 
            this.rbtnGB2312.AutoSize = true;
            this.rbtnGB2312.Checked = true;
            this.rbtnGB2312.Location = new System.Drawing.Point(7, 0);
            this.rbtnGB2312.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnGB2312.Name = "rbtnGB2312";
            this.rbtnGB2312.Size = new System.Drawing.Size(76, 19);
            this.rbtnGB2312.TabIndex = 8;
            this.rbtnGB2312.TabStop = true;
            this.rbtnGB2312.Text = "GB2312";
            this.rbtnGB2312.UseVisualStyleBackColor = true;
            this.rbtnGB2312.CheckedChanged += new System.EventHandler(this.rbtnGB2312_CheckedChanged);
            // 
            // DataReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnGB2312);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataReceive";
            this.Size = new System.Drawing.Size(697, 262);
            this.CMS_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem MS_Clear;
        private System.Windows.Forms.ToolStripMenuItem MS_ToInt;
        private System.Windows.Forms.ToolStripMenuItem MS_ToFloat;
        private System.Windows.Forms.ToolStripMenuItem MS_ToDouble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblCount;
        private System.Windows.Forms.RadioButton rbtnGB2312;
    }
}
