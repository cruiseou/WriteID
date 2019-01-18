namespace WriteID.Units
{
    partial class HistoricalRecord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIGFOX_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIGFOX_PAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据写入记录";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainID,
            this.SIGFOX_ID,
            this.SIGFOX_PAC,
            this.Time});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(452, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainID
            // 
            this.mainID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainID.HeaderText = "ID";
            this.mainID.Name = "mainID";
            // 
            // SIGFOX_ID
            // 
            this.SIGFOX_ID.HeaderText = "SIGFOX_ID";
            this.SIGFOX_ID.Name = "SIGFOX_ID";
            // 
            // SIGFOX_PAC
            // 
            this.SIGFOX_PAC.HeaderText = "SIGFOX_PAC";
            this.SIGFOX_PAC.Name = "SIGFOX_PAC";
            // 
            // Time
            // 
            this.Time.HeaderText = "插入时间";
            this.Time.Name = "Time";
            // 
            // HistoricalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "HistoricalRecord";
            this.Size = new System.Drawing.Size(458, 406);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIGFOX_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIGFOX_PAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}
