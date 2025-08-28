namespace Stellara
{
    partial class FormHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "지난 운세 목록";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.",
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.",
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.",
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.",
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.",
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.",
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.",
            "2025년 8월 28일 13시 00분 - 오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다."});
            this.listBox1.Location = new System.Drawing.Point(17, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(638, 303);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRe.Location = new System.Drawing.Point(102, 395);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(229, 43);
            this.btnRe.TabIndex = 5;
            this.btnRe.Text = "새로고침";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(337, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(229, 43);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistory";
            this.Text = "운세 기록 보기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnClose;
    }
}