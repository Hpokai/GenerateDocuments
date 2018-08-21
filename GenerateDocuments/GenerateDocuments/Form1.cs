using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GenerateDocuments
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();    

        public Form1()
        {
            InitializeComponent();  
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            if (this.run_timer.Enabled)
            {
                this.stopwatch.Stop();
                this.stopwatch.Reset();

                this.info_timer.Stop();

                this.run_button.Text = "RUN";
                this.run_button.BackColor = Color.LightBlue;
                this.run_timer.Stop();
            }
            else
            {
                this.run_button.Text = "STOP";
                this.run_button.BackColor = Color.LightCoral;

                this.current_no_textBox.Text = this.start_textBox.Text;

                this.run_timer.Interval = 3000;
                this.run_timer.Start();

                this.info_timer.Interval = 1000;
                this.info_timer.Start();

                this.stopwatch.Start();
            }
        }

        private void run_timer_Tick(object sender, EventArgs e)
        {
            string path = string.Format(@"{0}\{1}.rp", this.path_textBox.Text, this.current_no_textBox.Text);
            using (FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                string garbage = "ABCDEFGHIJK012345AABCDEFGHIABCDEFGHIJK0123456789!@#$%^&*()JK0123456789!@#$%^&*()BCDEFGHIJK0123456789!@#$%^&*()ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK012ABCABCDEFGHIJK0123456789!@#$%^&*()DEFGHIJK012345ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()3456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK012ABCABCDEFGHIJK0123456789!@#$%^&*()DEFGHIJK01234ABCDEFGHIJK0123456789!@#$%^&*()56789!@#$%^&*()3456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK01ABCDABCDEFGHIJK0123456789!@#$%^&*()EFGHIJK012345ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()23456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK01ABCDABCDEFGHIJK0123456789!@#$%^&*()EFGHIJK012345ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()23456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK01ABCDABCDEFGHIJK0123456789!@#$%^&*()EFGHIJK012345ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()23456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK01ABCDABCDEFGHIJK0123456789!@#$%^&*()EFGHIJK012345ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()23456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK01ABCDABCDEFGHIJK0123456789!@#$%^&*()EFGHIJK012345ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()23456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK01ABCDABCDEFGHIJK0123456789!@#$%^&*()EFGHIJK012345ABCDEFGHIJK0123456789!@#$%^&*()6789!@#$%^&*()23456789!@#$%^&*()3456789!@#$%^&*()" +
                    "ABCDEFGHIJK012ABCDEFGHIJK012ABCABCDEFGHIJK0123456789!@#$%^&*()DEFGHIJK0123ABCDEFGHIJK0123456789!@#$%^&*()456789!@#$%^&*()3456789!@#$%^&*()3456789!@#$%^&*()";
                Byte[] info = new UTF8Encoding(true).GetBytes(this.current_no_textBox.Text + garbage);
                fs.Write(info, 0, info.Length);
            }
            this.current_no_textBox.Text = (Convert.ToInt32(this.current_no_textBox.Text) + 1).ToString();
        }

        private void info_timer_Tick(object sender, EventArgs e)
        {
            string path = string.Format(@"{0}", this.path_textBox.Text);
            this.files_in_dir_textBox.Text = Directory.GetFiles(path).Length.ToString();
            this.elapsed_time_textBox.Text = string.Format("{0}:{1}:{2}", this.stopwatch.Elapsed.Hours, this.stopwatch.Elapsed.Minutes, this.stopwatch.Elapsed.Seconds);
            this.current_time_textBox.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            if (!this.run_forever_checkBox.Checked)
            {
                if (int.Parse(end_textBox.Text) <= int.Parse(current_no_textBox.Text))
                {
                    this.run_button.PerformClick();
                }
            }
        }

        private void run_forever_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.run_forever_checkBox.Checked)
            {
                this.end_textBox.Enabled = false;
            }
            else
            {
                this.end_textBox.Enabled = true;
            }
        }

        private void clean_all_files_button_Click(object sender, EventArgs e)
        {
            string path = string.Format(@"{0}", this.path_textBox.Text);
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        private void path_textBox_DoubleClick(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.path_textBox.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
