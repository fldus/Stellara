namespace Stellara
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.운세기록보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stellara정보보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용방법보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnResult = new System.Windows.Forms.Button();
            this.안내멘트 = new System.Windows.Forms.Label();
            this.제목 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.운세기록보기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 운세기록보기ToolStripMenuItem
            // 
            this.운세기록보기ToolStripMenuItem.Name = "운세기록보기ToolStripMenuItem";
            this.운세기록보기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.운세기록보기ToolStripMenuItem.Text = "운세 기록 보기";
            this.운세기록보기ToolStripMenuItem.Click += new System.EventHandler(this.운세기록보기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stellara정보보기ToolStripMenuItem,
            this.사용방법보기ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // stellara정보보기ToolStripMenuItem
            // 
            this.stellara정보보기ToolStripMenuItem.Name = "stellara정보보기ToolStripMenuItem";
            this.stellara정보보기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stellara정보보기ToolStripMenuItem.Text = "Stellara 정보 보기";
            this.stellara정보보기ToolStripMenuItem.Click += new System.EventHandler(this.stellara정보보기ToolStripMenuItem_Click);
            // 
            // 사용방법보기ToolStripMenuItem
            // 
            this.사용방법보기ToolStripMenuItem.Name = "사용방법보기ToolStripMenuItem";
            this.사용방법보기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.사용방법보기ToolStripMenuItem.Text = "사용 방법 보기";
            this.사용방법보기ToolStripMenuItem.Click += new System.EventHandler(this.사용방법보기ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.안내멘트);
            this.groupBox1.Controls.Add(this.제목);
            this.groupBox1.Location = new System.Drawing.Point(40, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCity.Location = new System.Drawing.Point(267, 243);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(167, 26);
            this.tbCity.TabIndex = 7;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTime.Location = new System.Drawing.Point(267, 211);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(167, 26);
            this.tbTime.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(394, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.Location = new System.Drawing.Point(127, 292);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(325, 50);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "오늘의 운세 보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // 안내멘트
            // 
            this.안내멘트.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.안내멘트.Location = new System.Drawing.Point(11, 33);
            this.안내멘트.Name = "안내멘트";
            this.안내멘트.Size = new System.Drawing.Size(569, 256);
            this.안내멘트.TabIndex = 3;
            this.안내멘트.Text = resources.GetString("안내멘트.Text");
            this.안내멘트.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 제목
            // 
            this.제목.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.제목.Location = new System.Drawing.Point(6, 0);
            this.제목.Name = "제목";
            this.제목.Size = new System.Drawing.Size(574, 43);
            this.제목.TabIndex = 2;
            this.제목.Text = "Stellara";
            this.제목.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Stellara";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 운세기록보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stellara정보보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용방법보기ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label 제목;
        private System.Windows.Forms.Label 안내멘트;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbCity;
    }
}

