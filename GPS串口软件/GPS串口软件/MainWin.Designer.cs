namespace GPS串口软件
{
    partial class MainWin
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.Port_GPS = new System.IO.Ports.SerialPort(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox连接 = new System.Windows.Forms.GroupBox();
            this.comboBoxCOM波特率 = new System.Windows.Forms.ComboBox();
            this.关闭 = new System.Windows.Forms.Button();
            this.打开 = new System.Windows.Forms.Button();
            this.comboBoxCOMName = new System.Windows.Forms.ComboBox();
            this.tab显示框 = new System.Windows.Forms.TabControl();
            this.经纬 = new System.Windows.Forms.TabPage();
            this.经纬view = new ZedGraph.ZedGraphControl();
            this.XY = new System.Windows.Forms.TabPage();
            this.XYview = new ZedGraph.ZedGraphControl();
            this.groupBox处理 = new System.Windows.Forms.GroupBox();
            this.button经纬 = new System.Windows.Forms.Button();
            this.comboBox纬 = new System.Windows.Forms.ComboBox();
            this.comboBox经 = new System.Windows.Forms.ComboBox();
            this.label纬 = new System.Windows.Forms.Label();
            this.label所在次序 = new System.Windows.Forms.Label();
            this.label经 = new System.Windows.Forms.Label();
            this.groupBox状态 = new System.Windows.Forms.GroupBox();
            this.GPSdata = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox连接.SuspendLayout();
            this.tab显示框.SuspendLayout();
            this.经纬.SuspendLayout();
            this.XY.SuspendLayout();
            this.groupBox处理.SuspendLayout();
            this.groupBox状态.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GPSdata)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox连接);
            this.splitContainer1.Panel1.Controls.Add(this.tab显示框);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox处理);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox状态);
            this.splitContainer1.Size = new System.Drawing.Size(961, 503);
            this.splitContainer1.SplitterDistance = 552;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox连接
            // 
            this.groupBox连接.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox连接.Controls.Add(this.comboBoxCOM波特率);
            this.groupBox连接.Controls.Add(this.关闭);
            this.groupBox连接.Controls.Add(this.打开);
            this.groupBox连接.Controls.Add(this.comboBoxCOMName);
            this.groupBox连接.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox连接.Location = new System.Drawing.Point(13, 13);
            this.groupBox连接.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox连接.Name = "groupBox连接";
            this.groupBox连接.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox连接.Size = new System.Drawing.Size(521, 95);
            this.groupBox连接.TabIndex = 5;
            this.groupBox连接.TabStop = false;
            this.groupBox连接.Text = "GPS连接";
            // 
            // comboBoxCOM波特率
            // 
            this.comboBoxCOM波特率.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCOM波特率.FormattingEnabled = true;
            this.comboBoxCOM波特率.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.comboBoxCOM波特率.Location = new System.Drawing.Point(128, 38);
            this.comboBoxCOM波特率.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCOM波特率.Name = "comboBoxCOM波特率";
            this.comboBoxCOM波特率.Size = new System.Drawing.Size(106, 29);
            this.comboBoxCOM波特率.TabIndex = 5;
            this.comboBoxCOM波特率.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOM波特率_SelectedIndexChanged);
            // 
            // 关闭
            // 
            this.关闭.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.关闭.Location = new System.Drawing.Point(335, 19);
            this.关闭.Margin = new System.Windows.Forms.Padding(5);
            this.关闭.Name = "关闭";
            this.关闭.Size = new System.Drawing.Size(85, 59);
            this.关闭.TabIndex = 4;
            this.关闭.Text = "关闭";
            this.关闭.UseVisualStyleBackColor = true;
            this.关闭.Click += new System.EventHandler(this.关闭_Click);
            // 
            // 打开
            // 
            this.打开.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.打开.Location = new System.Drawing.Point(244, 19);
            this.打开.Margin = new System.Windows.Forms.Padding(5);
            this.打开.Name = "打开";
            this.打开.Size = new System.Drawing.Size(81, 59);
            this.打开.TabIndex = 3;
            this.打开.Text = "打开";
            this.打开.UseVisualStyleBackColor = true;
            this.打开.Click += new System.EventHandler(this.打开_Click);
            // 
            // comboBoxCOMName
            // 
            this.comboBoxCOMName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCOMName.FormattingEnabled = true;
            this.comboBoxCOMName.Location = new System.Drawing.Point(10, 38);
            this.comboBoxCOMName.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxCOMName.Name = "comboBoxCOMName";
            this.comboBoxCOMName.Size = new System.Drawing.Size(108, 29);
            this.comboBoxCOMName.TabIndex = 1;
            // 
            // tab显示框
            // 
            this.tab显示框.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab显示框.Controls.Add(this.经纬);
            this.tab显示框.Controls.Add(this.XY);
            this.tab显示框.Location = new System.Drawing.Point(13, 118);
            this.tab显示框.Margin = new System.Windows.Forms.Padding(5);
            this.tab显示框.Name = "tab显示框";
            this.tab显示框.SelectedIndex = 0;
            this.tab显示框.Size = new System.Drawing.Size(525, 378);
            this.tab显示框.TabIndex = 4;
            // 
            // 经纬
            // 
            this.经纬.Controls.Add(this.经纬view);
            this.经纬.Location = new System.Drawing.Point(4, 30);
            this.经纬.Margin = new System.Windows.Forms.Padding(5);
            this.经纬.Name = "经纬";
            this.经纬.Padding = new System.Windows.Forms.Padding(5);
            this.经纬.Size = new System.Drawing.Size(517, 344);
            this.经纬.TabIndex = 0;
            this.经纬.Text = "经纬";
            this.经纬.UseVisualStyleBackColor = true;
            // 
            // 经纬view
            // 
            this.经纬view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.经纬view.Location = new System.Drawing.Point(5, 5);
            this.经纬view.Margin = new System.Windows.Forms.Padding(5);
            this.经纬view.Name = "经纬view";
            this.经纬view.ScrollGrace = 0D;
            this.经纬view.ScrollMaxX = 0D;
            this.经纬view.ScrollMaxY = 0D;
            this.经纬view.ScrollMaxY2 = 0D;
            this.经纬view.ScrollMinX = 0D;
            this.经纬view.ScrollMinY = 0D;
            this.经纬view.ScrollMinY2 = 0D;
            this.经纬view.Size = new System.Drawing.Size(507, 334);
            this.经纬view.TabIndex = 0;
            // 
            // XY
            // 
            this.XY.Controls.Add(this.XYview);
            this.XY.Location = new System.Drawing.Point(4, 22);
            this.XY.Margin = new System.Windows.Forms.Padding(5);
            this.XY.Name = "XY";
            this.XY.Padding = new System.Windows.Forms.Padding(5);
            this.XY.Size = new System.Drawing.Size(517, 352);
            this.XY.TabIndex = 1;
            this.XY.Text = "XY";
            this.XY.UseVisualStyleBackColor = true;
            // 
            // XYview
            // 
            this.XYview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XYview.Location = new System.Drawing.Point(5, 5);
            this.XYview.Margin = new System.Windows.Forms.Padding(5);
            this.XYview.Name = "XYview";
            this.XYview.ScrollGrace = 0D;
            this.XYview.ScrollMaxX = 0D;
            this.XYview.ScrollMaxY = 0D;
            this.XYview.ScrollMaxY2 = 0D;
            this.XYview.ScrollMinX = 0D;
            this.XYview.ScrollMinY = 0D;
            this.XYview.ScrollMinY2 = 0D;
            this.XYview.Size = new System.Drawing.Size(507, 342);
            this.XYview.TabIndex = 0;
            // 
            // groupBox处理
            // 
            this.groupBox处理.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox处理.Controls.Add(this.button经纬);
            this.groupBox处理.Controls.Add(this.comboBox纬);
            this.groupBox处理.Controls.Add(this.comboBox经);
            this.groupBox处理.Controls.Add(this.label纬);
            this.groupBox处理.Controls.Add(this.label所在次序);
            this.groupBox处理.Controls.Add(this.label经);
            this.groupBox处理.Location = new System.Drawing.Point(5, 337);
            this.groupBox处理.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox处理.MinimumSize = new System.Drawing.Size(382, 0);
            this.groupBox处理.Name = "groupBox处理";
            this.groupBox处理.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox处理.Size = new System.Drawing.Size(382, 155);
            this.groupBox处理.TabIndex = 2;
            this.groupBox处理.TabStop = false;
            this.groupBox处理.Text = "处理";
            // 
            // button经纬
            // 
            this.button经纬.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button经纬.Location = new System.Drawing.Point(275, 24);
            this.button经纬.Margin = new System.Windows.Forms.Padding(5);
            this.button经纬.Name = "button经纬";
            this.button经纬.Size = new System.Drawing.Size(97, 29);
            this.button经纬.TabIndex = 6;
            this.button经纬.Text = "确定";
            this.button经纬.UseVisualStyleBackColor = true;
            this.button经纬.Click += new System.EventHandler(this.button经纬_Click);
            // 
            // comboBox纬
            // 
            this.comboBox纬.FormattingEnabled = true;
            this.comboBox纬.Location = new System.Drawing.Point(210, 24);
            this.comboBox纬.Name = "comboBox纬";
            this.comboBox纬.Size = new System.Drawing.Size(57, 29);
            this.comboBox纬.TabIndex = 4;
            this.comboBox纬.DropDown += new System.EventHandler(this.comboBox纬_DropDown);
            // 
            // comboBox经
            // 
            this.comboBox经.FormattingEnabled = true;
            this.comboBox经.Location = new System.Drawing.Point(123, 24);
            this.comboBox经.Name = "comboBox经";
            this.comboBox经.Size = new System.Drawing.Size(57, 29);
            this.comboBox经.TabIndex = 3;
            this.comboBox经.DropDown += new System.EventHandler(this.comboBox经_DropDown);
            // 
            // label纬
            // 
            this.label纬.AutoSize = true;
            this.label纬.Location = new System.Drawing.Point(188, 27);
            this.label纬.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label纬.Name = "label纬";
            this.label纬.Size = new System.Drawing.Size(26, 21);
            this.label纬.TabIndex = 1;
            this.label纬.Text = "纬";
            // 
            // label所在次序
            // 
            this.label所在次序.AutoSize = true;
            this.label所在次序.Location = new System.Drawing.Point(10, 27);
            this.label所在次序.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label所在次序.Name = "label所在次序";
            this.label所在次序.Size = new System.Drawing.Size(90, 21);
            this.label所在次序.TabIndex = 2;
            this.label所在次序.Text = "所在次序：";
            // 
            // label经
            // 
            this.label经.AutoSize = true;
            this.label经.Location = new System.Drawing.Point(98, 27);
            this.label经.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label经.Name = "label经";
            this.label经.Size = new System.Drawing.Size(26, 21);
            this.label经.TabIndex = 0;
            this.label经.Text = "经";
            // 
            // groupBox状态
            // 
            this.groupBox状态.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox状态.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox状态.Controls.Add(this.GPSdata);
            this.groupBox状态.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox状态.Location = new System.Drawing.Point(0, 0);
            this.groupBox状态.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox状态.Name = "groupBox状态";
            this.groupBox状态.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox状态.Size = new System.Drawing.Size(395, 332);
            this.groupBox状态.TabIndex = 1;
            this.groupBox状态.TabStop = false;
            this.groupBox状态.Text = "GPS状态";
            // 
            // GPSdata
            // 
            this.GPSdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GPSdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.值});
            this.GPSdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPSdata.Location = new System.Drawing.Point(5, 27);
            this.GPSdata.Margin = new System.Windows.Forms.Padding(5);
            this.GPSdata.Name = "GPSdata";
            this.GPSdata.RowHeadersVisible = false;
            this.GPSdata.RowTemplate.Height = 23;
            this.GPSdata.Size = new System.Drawing.Size(385, 300);
            this.GPSdata.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.HeaderText = "顺序";
            this.Index.Name = "Index";
            this.Index.Width = 30;
            // 
            // 值
            // 
            this.值.HeaderText = "值";
            this.值.Name = "值";
            this.值.Width = 150;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 503);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWin";
            this.Text = "GPS串口软件";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox连接.ResumeLayout(false);
            this.tab显示框.ResumeLayout(false);
            this.经纬.ResumeLayout(false);
            this.XY.ResumeLayout(false);
            this.groupBox处理.ResumeLayout(false);
            this.groupBox处理.PerformLayout();
            this.groupBox状态.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GPSdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort Port_GPS;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox连接;
        private System.Windows.Forms.ComboBox comboBoxCOM波特率;
        private System.Windows.Forms.Button 关闭;
        private System.Windows.Forms.Button 打开;
        private System.Windows.Forms.ComboBox comboBoxCOMName;
        private System.Windows.Forms.GroupBox groupBox状态;
        private System.Windows.Forms.DataGridView GPSdata;
        private System.Windows.Forms.TabControl tab显示框;
        private System.Windows.Forms.TabPage 经纬;
        private ZedGraph.ZedGraphControl 经纬view;
        private System.Windows.Forms.TabPage XY;
        private ZedGraph.ZedGraphControl XYview;
        private System.Windows.Forms.GroupBox groupBox处理;
        private System.Windows.Forms.Label label纬;
        private System.Windows.Forms.Label label经;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn 值;
        private System.Windows.Forms.Label label所在次序;
        private System.Windows.Forms.ComboBox comboBox纬;
        private System.Windows.Forms.ComboBox comboBox经;
        private System.Windows.Forms.Button button经纬;
    }
}

