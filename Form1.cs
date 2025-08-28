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
    public partial class Form1 : Form
    {
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

        private void btnResult_Click(object sender, EventArgs e)
        {
            FormResult form = new FormResult();
            form.ShowDialog();
        }
    }
}
