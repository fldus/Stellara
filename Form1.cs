using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Stellara
{
    public partial class Form1 : Form
    {
        string astrologyAPI = Environment.GetEnvironmentVariable("ASTROLOGY_API_KEY");
        private static readonly HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 운세기록보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory();
                form.Show();
            }
        }

        private void stellara정보보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void 사용방법보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUse form = Application.OpenForms["FormUse"] as FormUse;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormUse();
                form.Show();
            }
        }

        private async void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(astrologyAPI))
                {
                    MessageBox.Show("환경변수 ASTROLOGY_API_KEY가 설정되어 있지 않습니다.");
                    return;
                }

                string today = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                string birthDay = datePicker.Value.ToString("yyyy-MM-dd");
                string birthTime = timePicker.Value.ToString("HH:mm");
                string city = tbCity.Text;
                if (string.IsNullOrWhiteSpace(city) || city.Any(c => c >= 0xAC00 && c <= 0xD7A3))
                {
                    city = "Seoul";
                }

                // 사용자 별자리 구하기
                
                // 현재 별자리 위치 구하기

                // 오늘의 운세 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
