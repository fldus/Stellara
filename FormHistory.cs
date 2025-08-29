﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stellara
{
    public partial class FormHistory : Form
    {
        List<string> history;
        Form1 form1;

        public FormHistory(Form1 form)
        {
            this.form1 = form;
            InitializeComponent();
            UpdateHistory();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            UpdateHistory();
        }
        private void LoadHistory()
        {
            try
            {
                string filename = "history.csv";
                history = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없어요.\n{ex.Message}", "파일 없음",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"권한이 없어요.\n{ex.Message}", "권한 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateHistory()
        {
            LoadHistory();
            lbHistory.Items.Clear();
            lbHistory.Items.AddRange(history.ToArray());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = history[lbHistory.SelectedIndex];
            var parts = message.Split('|');

            FormResult form = new FormResult(parts[1].Trim(), parts[0].Trim(), 
                parts[2].Trim(), parts[3].Trim());
            form.ShowDialog();
        }
    }
}
