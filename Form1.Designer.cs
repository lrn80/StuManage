namespace stuMange
{
    partial class mainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.systemMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.sysLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.sysExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stuMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.addstuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.managestuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.subManage = new System.Windows.Forms.ToolStripMenuItem();
            this.addsubMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.submsgManage = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreManage = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAddStuInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbManageStuInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddCourseInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbCoureInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScoreInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemMsg,
            this.stuMsg,
            this.subManage,
            this.scoreManage,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "系统管理（S）";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddStuInfo,
            this.tsbManageStuInfo,
            this.toolStripSeparator1,
            this.tsbAddCourseInfo,
            this.tsbCoureInfo,
            this.toolStripSeparator2,
            this.tsbScoreInfo,
            this.toolStripSeparator3,
            this.tsbHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // systemMsg
            // 
            this.systemMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysLogin,
            this.sysExit});
            this.systemMsg.Name = "systemMsg";
            this.systemMsg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.systemMsg.Size = new System.Drawing.Size(100, 24);
            this.systemMsg.Text = "系统管理(S)";
            // 
            // sysLogin
            // 
            this.sysLogin.Name = "sysLogin";
            this.sysLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.sysLogin.Size = new System.Drawing.Size(236, 26);
            this.sysLogin.Text = "用户登录（L）";
            // 
            // sysExit
            // 
            this.sysExit.Name = "sysExit";
            this.sysExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sysExit.Size = new System.Drawing.Size(236, 26);
            this.sysExit.Text = "退出（E）";
            // 
            // stuMsg
            // 
            this.stuMsg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addstuInfo,
            this.managestuInfo});
            this.stuMsg.Name = "stuMsg";
            this.stuMsg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.stuMsg.Size = new System.Drawing.Size(126, 24);
            this.stuMsg.Text = "学生管理（M）";
            // 
            // addstuInfo
            // 
            this.addstuInfo.Name = "addstuInfo";
            this.addstuInfo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addstuInfo.Size = new System.Drawing.Size(316, 26);
            this.addstuInfo.Text = "添加学生信息（A）";
            // 
            // managestuInfo
            // 
            this.managestuInfo.Name = "managestuInfo";
            this.managestuInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.managestuInfo.Size = new System.Drawing.Size(316, 26);
            this.managestuInfo.Text = "学生信息管理（I）";
            // 
            // subManage
            // 
            this.subManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addsubMsg,
            this.submsgManage});
            this.subManage.Name = "subManage";
            this.subManage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.subManage.Size = new System.Drawing.Size(101, 24);
            this.subManage.Text = "课程管理(C)";
            // 
            // addsubMsg
            // 
            this.addsubMsg.Name = "addsubMsg";
            this.addsubMsg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.addsubMsg.Size = new System.Drawing.Size(274, 26);
            this.addsubMsg.Text = "添加课程信息（D）";
            // 
            // submsgManage
            // 
            this.submsgManage.Name = "submsgManage";
            this.submsgManage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.submsgManage.Size = new System.Drawing.Size(274, 26);
            this.submsgManage.Text = "课程信息管理（N）";
            // 
            // scoreManage
            // 
            this.scoreManage.Name = "scoreManage";
            this.scoreManage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.scoreManage.Size = new System.Drawing.Size(122, 24);
            this.scoreManage.Text = "成绩管理（A）";
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.help.Size = new System.Drawing.Size(93, 24);
            this.help.Text = "帮助（H）";
            // 
            // tsbAddStuInfo
            // 
            this.tsbAddStuInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddStuInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddStuInfo.Image")));
            this.tsbAddStuInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddStuInfo.Name = "tsbAddStuInfo";
            this.tsbAddStuInfo.Size = new System.Drawing.Size(24, 24);
            this.tsbAddStuInfo.Text = "添加学生信息";
            // 
            // tsbManageStuInfo
            // 
            this.tsbManageStuInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbManageStuInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbManageStuInfo.Image")));
            this.tsbManageStuInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManageStuInfo.Name = "tsbManageStuInfo";
            this.tsbManageStuInfo.Size = new System.Drawing.Size(24, 24);
            this.tsbManageStuInfo.Text = "管理学生信息";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbAddCourseInfo
            // 
            this.tsbAddCourseInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddCourseInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddCourseInfo.Image")));
            this.tsbAddCourseInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCourseInfo.Name = "tsbAddCourseInfo";
            this.tsbAddCourseInfo.Size = new System.Drawing.Size(24, 24);
            this.tsbAddCourseInfo.Text = "添加课程信息";
            // 
            // tsbCoureInfo
            // 
            this.tsbCoureInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCoureInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbCoureInfo.Image")));
            this.tsbCoureInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCoureInfo.Name = "tsbCoureInfo";
            this.tsbCoureInfo.Size = new System.Drawing.Size(24, 24);
            this.tsbCoureInfo.Text = "课程信息管理";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbScoreInfo
            // 
            this.tsbScoreInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScoreInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbScoreInfo.Image")));
            this.tsbScoreInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreInfo.Name = "tsbScoreInfo";
            this.tsbScoreInfo.Size = new System.Drawing.Size(24, 24);
            this.tsbScoreInfo.Text = "成绩管理";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(24, 24);
            this.tsbHelp.Text = "帮助";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(39, 20);
            this.tssStatus.Text = "就绪";
            this.tssStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(707, 20);
            this.tssMsg.Spring = true;
            this.tssMsg.Text = "请选择一种操作";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemMsg;
        private System.Windows.Forms.ToolStripMenuItem sysLogin;
        private System.Windows.Forms.ToolStripMenuItem sysExit;
        private System.Windows.Forms.ToolStripMenuItem stuMsg;
        private System.Windows.Forms.ToolStripMenuItem addstuInfo;
        private System.Windows.Forms.ToolStripMenuItem managestuInfo;
        private System.Windows.Forms.ToolStripMenuItem subManage;
        private System.Windows.Forms.ToolStripMenuItem addsubMsg;
        private System.Windows.Forms.ToolStripMenuItem submsgManage;
        private System.Windows.Forms.ToolStripMenuItem scoreManage;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripButton tsbAddStuInfo;
        private System.Windows.Forms.ToolStripButton tsbManageStuInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAddCourseInfo;
        private System.Windows.Forms.ToolStripButton tsbCoureInfo;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbScoreInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbHelp;
    }
}

