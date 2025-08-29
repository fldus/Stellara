namespace Stellara
{
    partial class FormResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResult));
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(219, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(229, 43);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTitle.Location = new System.Drawing.Point(10, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(643, 49);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "운세 제목";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContent
            // 
            this.lbContent.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbContent.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbContent.Location = new System.Drawing.Point(35, 88);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(586, 82);
            this.lbContent.TabIndex = 10;
            this.lbContent.Text = "오늘은 당신의 불타는 열정이 새로운 시작에 유리하게 작용할 것입니다.\r\n";
            this.lbContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDetail
            // 
            this.lbDetail.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDetail.Location = new System.Drawing.Point(35, 170);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(586, 222);
            this.lbDetail.TabIndex = 11;
            this.lbDetail.Text = resources.GetString("lbDetail.Text");
            this.lbDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDay
            // 
            this.lbDay.Font = new System.Drawing.Font("굴림", 10F);
            this.lbDay.Location = new System.Drawing.Point(487, 67);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(134, 20);
            this.lbDay.TabIndex = 12;
            this.lbDay.Text = "2025-08-28 15:09";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResult";
            this.Text = "운세 결과";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lbTitle;
        public System.Windows.Forms.Label lbContent;
        public System.Windows.Forms.Label lbDetail;
        public System.Windows.Forms.Label lbDay;
    }
}