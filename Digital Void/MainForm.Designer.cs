namespace Digital_Void
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入实体文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出实体文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空实体数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空模拟数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模拟参数设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中心固定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视点固定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追随实体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无实体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_EM = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_PC = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_DC = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.PlotPanel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataSubStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_Loacl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_Angle = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MFBackGroundWorker = new System.ComponentModel.BackgroundWorker();
            this.MainMenu.SuspendLayout();
            this.PlotPanel.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.管理ToolStripMenuItem,
            this.控制ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenu.Size = new System.Drawing.Size(1476, 34);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入实体文件ToolStripMenuItem,
            this.导出实体文件ToolStripMenuItem,
            this.导入数据库ToolStripMenuItem,
            this.导出数据库ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 导入实体文件ToolStripMenuItem
            // 
            this.导入实体文件ToolStripMenuItem.Name = "导入实体文件ToolStripMenuItem";
            this.导入实体文件ToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.导入实体文件ToolStripMenuItem.Text = "导入实体文件";
            this.导入实体文件ToolStripMenuItem.Click += new System.EventHandler(this.导入实体文件ToolStripMenuItem_Click);
            // 
            // 导出实体文件ToolStripMenuItem
            // 
            this.导出实体文件ToolStripMenuItem.Name = "导出实体文件ToolStripMenuItem";
            this.导出实体文件ToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.导出实体文件ToolStripMenuItem.Text = "导出实体文件";
            this.导出实体文件ToolStripMenuItem.Click += new System.EventHandler(this.导出实体文件ToolStripMenuItem_Click);
            // 
            // 导入数据库ToolStripMenuItem
            // 
            this.导入数据库ToolStripMenuItem.Enabled = false;
            this.导入数据库ToolStripMenuItem.Name = "导入数据库ToolStripMenuItem";
            this.导入数据库ToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.导入数据库ToolStripMenuItem.Text = "导入模拟数据库";
            this.导入数据库ToolStripMenuItem.Click += new System.EventHandler(this.导入数据库ToolStripMenuItem_Click);
            // 
            // 导出数据库ToolStripMenuItem
            // 
            this.导出数据库ToolStripMenuItem.Enabled = false;
            this.导出数据库ToolStripMenuItem.Name = "导出数据库ToolStripMenuItem";
            this.导出数据库ToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.导出数据库ToolStripMenuItem.Text = "导出模拟数据库";
            this.导出数据库ToolStripMenuItem.Click += new System.EventHandler(this.导出数据库ToolStripMenuItem_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空实体数据ToolStripMenuItem,
            this.清空模拟数据ToolStripMenuItem,
            this.模拟参数设定ToolStripMenuItem});
            this.管理ToolStripMenuItem.Enabled = false;
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.管理ToolStripMenuItem.Text = "管理";
            // 
            // 清空实体数据ToolStripMenuItem
            // 
            this.清空实体数据ToolStripMenuItem.Name = "清空实体数据ToolStripMenuItem";
            this.清空实体数据ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.清空实体数据ToolStripMenuItem.Text = "清空实体数据";
            // 
            // 清空模拟数据ToolStripMenuItem
            // 
            this.清空模拟数据ToolStripMenuItem.Name = "清空模拟数据ToolStripMenuItem";
            this.清空模拟数据ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.清空模拟数据ToolStripMenuItem.Text = "清空模拟数据";
            // 
            // 模拟参数设定ToolStripMenuItem
            // 
            this.模拟参数设定ToolStripMenuItem.Name = "模拟参数设定ToolStripMenuItem";
            this.模拟参数设定ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.模拟参数设定ToolStripMenuItem.Text = "模拟参数设定";
            // 
            // 控制ToolStripMenuItem
            // 
            this.控制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中心固定ToolStripMenuItem,
            this.视点固定ToolStripMenuItem,
            this.追随实体ToolStripMenuItem});
            this.控制ToolStripMenuItem.Enabled = false;
            this.控制ToolStripMenuItem.Name = "控制ToolStripMenuItem";
            this.控制ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.控制ToolStripMenuItem.Text = "视角";
            // 
            // 中心固定ToolStripMenuItem
            // 
            this.中心固定ToolStripMenuItem.Checked = true;
            this.中心固定ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.中心固定ToolStripMenuItem.Name = "中心固定ToolStripMenuItem";
            this.中心固定ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.中心固定ToolStripMenuItem.Text = "中心固定";
            this.中心固定ToolStripMenuItem.Click += new System.EventHandler(this.中心固定ToolStripMenuItem_Click);
            // 
            // 视点固定ToolStripMenuItem
            // 
            this.视点固定ToolStripMenuItem.Enabled = false;
            this.视点固定ToolStripMenuItem.Name = "视点固定ToolStripMenuItem";
            this.视点固定ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.视点固定ToolStripMenuItem.Text = "视点固定";
            this.视点固定ToolStripMenuItem.Click += new System.EventHandler(this.视点固定ToolStripMenuItem_Click);
            // 
            // 追随实体ToolStripMenuItem
            // 
            this.追随实体ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.无实体ToolStripMenuItem});
            this.追随实体ToolStripMenuItem.Enabled = false;
            this.追随实体ToolStripMenuItem.Name = "追随实体ToolStripMenuItem";
            this.追随实体ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.追随实体ToolStripMenuItem.Text = "追随实体";
            this.追随实体ToolStripMenuItem.Click += new System.EventHandler(this.追随实体ToolStripMenuItem_Click);
            // 
            // 无实体ToolStripMenuItem
            // 
            this.无实体ToolStripMenuItem.Name = "无实体ToolStripMenuItem";
            this.无实体ToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.无实体ToolStripMenuItem.Text = "无实体";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_EM,
            this.MainMenu_PC,
            this.MainMenu_DC});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // MainMenu_EM
            // 
            this.MainMenu_EM.Checked = true;
            this.MainMenu_EM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainMenu_EM.Name = "MainMenu_EM";
            this.MainMenu_EM.Size = new System.Drawing.Size(165, 30);
            this.MainMenu_EM.Text = "实体管理";
            this.MainMenu_EM.Click += new System.EventHandler(this.MainMenu_EM_Click);
            // 
            // MainMenu_PC
            // 
            this.MainMenu_PC.Checked = true;
            this.MainMenu_PC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MainMenu_PC.Name = "MainMenu_PC";
            this.MainMenu_PC.Size = new System.Drawing.Size(165, 30);
            this.MainMenu_PC.Text = "模拟控制";
            this.MainMenu_PC.Click += new System.EventHandler(this.MainMenu_PC_Click);
            // 
            // MainMenu_DC
            // 
            this.MainMenu_DC.Enabled = false;
            this.MainMenu_DC.Name = "MainMenu_DC";
            this.MainMenu_DC.Size = new System.Drawing.Size(165, 30);
            this.MainMenu_DC.Text = "数据管理";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem,
            this.MainMenu_About});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Enabled = false;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(129, 30);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // MainMenu_About
            // 
            this.MainMenu_About.Name = "MainMenu_About";
            this.MainMenu_About.Size = new System.Drawing.Size(129, 30);
            this.MainMenu_About.Text = "关于";
            this.MainMenu_About.Click += new System.EventHandler(this.MainMenu_About_Click);
            // 
            // PlotPanel
            // 
            this.PlotPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotPanel.BackColor = System.Drawing.Color.White;
            this.PlotPanel.Controls.Add(this.TimeLabel);
            this.PlotPanel.Location = new System.Drawing.Point(0, 40);
            this.PlotPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlotPanel.Name = "PlotPanel";
            this.PlotPanel.Size = new System.Drawing.Size(1476, 915);
            this.PlotPanel.TabIndex = 1;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeLabel.Location = new System.Drawing.Point(8, 8);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(194, 41);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00:00:00.00";
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripProgressBar,
            this.StripStatusLabel,
            this.DataSubStripStatusLabel,
            this.toolStripStatusLabel1,
            this.StatusLabel_Loacl,
            this.toolStripStatusLabel3,
            this.StatusLabel_Angle});
            this.StatusStrip.Location = new System.Drawing.Point(0, 963);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1476, 30);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // StripProgressBar
            // 
            this.StripProgressBar.MarqueeAnimationSpeed = 1;
            this.StripProgressBar.Name = "StripProgressBar";
            this.StripProgressBar.Size = new System.Drawing.Size(150, 24);
            // 
            // StripStatusLabel
            // 
            this.StripStatusLabel.Name = "StripStatusLabel";
            this.StripStatusLabel.Size = new System.Drawing.Size(94, 25);
            this.StripStatusLabel.Text = "准备就绪...";
            // 
            // DataSubStripStatusLabel
            // 
            this.DataSubStripStatusLabel.Name = "DataSubStripStatusLabel";
            this.DataSubStripStatusLabel.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(990, 25);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "视点位置：";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLabel_Loacl
            // 
            this.StatusLabel_Loacl.Name = "StatusLabel_Loacl";
            this.StatusLabel_Loacl.Size = new System.Drawing.Size(51, 25);
            this.StatusLabel_Loacl.Text = "0,0,0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(115, 25);
            this.toolStripStatusLabel3.Text = "   视点角度：";
            // 
            // StatusLabel_Angle
            // 
            this.StatusLabel_Angle.Name = "StatusLabel_Angle";
            this.StatusLabel_Angle.Size = new System.Drawing.Size(51, 25);
            this.StatusLabel_Angle.Text = "0,0,0";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MFBackGroundWorker
            // 
            this.MFBackGroundWorker.WorkerReportsProgress = true;
            this.MFBackGroundWorker.WorkerSupportsCancellation = true;
            this.MFBackGroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MFBackGroundWorker_DoWork);
            this.MFBackGroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MFBackGroundWorker_ProgressChanged);
            this.MFBackGroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MFBackGroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 993);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.PlotPanel);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Void";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.PlotPanel.ResumeLayout(false);
            this.PlotPanel.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_About;
        private System.Windows.Forms.StatusStrip StatusStrip;
        public System.Windows.Forms.Panel PlotPanel;
        public System.Windows.Forms.ToolStripStatusLabel StripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Loacl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Angle;
        public System.Windows.Forms.Label TimeLabel;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem 导入实体文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出实体文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中心固定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视点固定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 追随实体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无实体ToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MainMenu;
        public System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MainMenu_EM;
        public System.Windows.Forms.ToolStripMenuItem MainMenu_PC;
        public System.Windows.Forms.ToolStripMenuItem MainMenu_DC;
        private System.Windows.Forms.ToolStripMenuItem 导入数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空实体数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空模拟数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模拟参数设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        public System.Windows.Forms.ToolStripProgressBar StripProgressBar;
        public System.Windows.Forms.ToolStripStatusLabel DataSubStripStatusLabel;
        public System.ComponentModel.BackgroundWorker MFBackGroundWorker;
    }
}

