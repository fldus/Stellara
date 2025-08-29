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
using Newtonsoft.Json;

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

                // 위도, 경도, 시간대
                var (lat, lon, tz) = await GetLocation(city);

                // 사용자 별자리 + 위치 구하기
                string birthConstellation = await GetConstellation(birthDay, birthTime, lat, lon, tz);

                // 현재 별자리 위치 구하기

                // 오늘의 운세 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<(double lat, double lon, double tz)> GetLocation(string city)
        {
            string url = "https://json.freeastrologyapi.com/geo-details";

            // 요청 바디
            var req = new { location = city };
            
            string json = JsonConvert.SerializeObject(req);

            // HttpRequestMessage 객체 생성 (post요청)
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("x-api-key", astrologyAPI);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            // api 호출
            var res = await httpClient.SendAsync(request);
            res.EnsureSuccessStatusCode();

            string content = await res.Content.ReadAsStringAsync();

            var arr = JArray.Parse(content);
            if (!arr.Any())
                throw new Exception("도시 정보를 찾을 수 없습니다.");

            var obj = arr[0];
            double lat = (double)obj["latitude"];
            double lon = (double)obj["longitude"];
            double tz = (double)obj["timezone_offset"];

            return (lat, lon, tz);
        }

        private async Task<string> GetConstellation(string birthDay, string birthTime, double lat, double lon, double tz)
        {
            var day = birthDay.Split('-');
            var time = birthTime.Split(':');

            string url = "https://json.freeastrologyapi.com/western/planets";

            // 요청 바디
            var reqDate = new
            {
                year = int.Parse(day[0]),
                month = int.Parse(day[1].TrimStart('0')),
                date = int.Parse(day[2].TrimStart('0')),
                hours = int.Parse(time[0].TrimStart('0')),
                minutes = int.Parse(time[1].TrimStart('0')),
                seconds = 0,
                latitude = lat,
                longitude = lon,
                timezone = tz,
                settings = new
                {
                    observation_point = "topocentric",
                    ayanamsha = "tropical",
                    language = "en"
                }
            };

            string jsonPayload = JsonConvert.SerializeObject(reqDate);

            // 요청 메시지 생성
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Headers.Add("x-api-key", astrologyAPI);
            request.Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

            // api 호출
            var res = await httpClient.SendAsync(request);
            res.EnsureSuccessStatusCode();

            string content = await res.Content.ReadAsStringAsync();

            var result = JObject.Parse(content);

            return result.ToString();
        }
    }
}
