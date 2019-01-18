namespace WriteID.Units
{
    partial class DataSend
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
            this.btn_write = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(21, 146);
            this.btn_write.Margin = new System.Windows.Forms.Padding(4);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(232, 90);
            this.btn_write.TabIndex = 9;
            this.btn_write.Text = "写入设备";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(96, 86);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "自动加1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(96, 19);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(157, 25);
            this.txt_ID.TabIndex = 15;
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // DataSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_write);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataSend";
            this.Size = new System.Drawing.Size(257, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
    }
}
