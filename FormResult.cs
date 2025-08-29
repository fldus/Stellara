using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stellara
{
    public partial class FormResult : Form
    {
        public FormResult(string title, string day, string content, string detail)
        {
            InitializeComponent();
            lbTitle.Text = title;
            lbDay.Text = day;
            lbContent.Text = content;
            lbDetail.Text = detail;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
