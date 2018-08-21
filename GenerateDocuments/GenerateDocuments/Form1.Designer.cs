namespace GenerateDocuments
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.end_textBox = new System.Windows.Forms.TextBox();
            this.run_forever_checkBox = new System.Windows.Forms.CheckBox();
            this.run_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clean_all_files_button = new System.Windows.Forms.Button();
            this.files_in_dir_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.current_time_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.current_no_textBox = new System.Windows.Forms.TextBox();
            this.elapsed_time_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.run_timer = new System.Windows.Forms.Timer(this.components);
            this.info_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_textBox
            // 
            this.start_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_textBox.Location = new System.Drawing.Point(56, 24);
            this.start_textBox.Name = "start_textBox";
            this.start_textBox.Size = new System.Drawing.Size(124, 26);
            this.start_textBox.TabIndex = 0;
            this.start_textBox.Text = "0";
            this.start_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "End";
            // 
            // end_textBox
            // 
            this.end_textBox.Enabled = false;
            this.end_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_textBox.Location = new System.Drawing.Point(56, 66);
            this.end_textBox.Name = "end_textBox";
            this.end_textBox.Size = new System.Drawing.Size(124, 26);
            this.end_textBox.TabIndex = 0;
            this.end_textBox.Text = "0";
            this.end_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // run_forever_checkBox
            // 
            this.run_forever_checkBox.AutoSize = true;
            this.run_forever_checkBox.Checked = true;
            this.run_forever_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.run_forever_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_forever_checkBox.Location = new System.Drawing.Point(186, 68);
            this.run_forever_checkBox.Name = "run_forever_checkBox";
            this.run_forever_checkBox.Size = new System.Drawing.Size(82, 24);
            this.run_forever_checkBox.TabIndex = 2;
            this.run_forever_checkBox.Text = "Forever";
            this.run_forever_checkBox.UseVisualStyleBackColor = true;
            this.run_forever_checkBox.CheckedChanged += new System.EventHandler(this.run_forever_checkBox_CheckedChanged);
            // 
            // run_button
            // 
            this.run_button.BackColor = System.Drawing.Color.LightBlue;
            this.run_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_button.Location = new System.Drawing.Point(308, 24);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(141, 68);
            this.run_button.TabIndex = 3;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = false;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.path_textBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.run_button);
            this.groupBox1.Controls.Add(this.start_textBox);
            this.groupBox1.Controls.Add(this.run_forever_checkBox);
            this.groupBox1.Controls.Add(this.end_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // path_textBox
            // 
            this.path_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path_textBox.Location = new System.Drawing.Point(56, 108);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(393, 26);
            this.path_textBox.TabIndex = 5;
            this.path_textBox.Text = "D:\\TCPIP_test\\CL";
            this.path_textBox.DoubleClick += new System.EventHandler(this.path_textBox_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Path";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.clean_all_files_button);
            this.groupBox2.Controls.Add(this.files_in_dir_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.current_time_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.current_no_textBox);
            this.groupBox2.Controls.Add(this.elapsed_time_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // clean_all_files_button
            // 
            this.clean_all_files_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clean_all_files_button.Location = new System.Drawing.Point(231, 115);
            this.clean_all_files_button.Name = "clean_all_files_button";
            this.clean_all_files_button.Size = new System.Drawing.Size(233, 26);
            this.clean_all_files_button.TabIndex = 6;
            this.clean_all_files_button.Text = "Clean Files";
            this.clean_all_files_button.UseVisualStyleBackColor = true;
            this.clean_all_files_button.Click += new System.EventHandler(this.clean_all_files_button_Click);
            // 
            // files_in_dir_textBox
            // 
            this.files_in_dir_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.files_in_dir_textBox.Location = new System.Drawing.Point(113, 115);
            this.files_in_dir_textBox.Name = "files_in_dir_textBox";
            this.files_in_dir_textBox.ReadOnly = true;
            this.files_in_dir_textBox.Size = new System.Drawing.Size(108, 26);
            this.files_in_dir_textBox.TabIndex = 5;
            this.files_in_dir_textBox.Text = "0";
            this.files_in_dir_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Files in Dir";
            // 
            // current_time_textBox
            // 
            this.current_time_textBox.Enabled = false;
            this.current_time_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_time_textBox.Location = new System.Drawing.Point(329, 76);
            this.current_time_textBox.Name = "current_time_textBox";
            this.current_time_textBox.ReadOnly = true;
            this.current_time_textBox.Size = new System.Drawing.Size(135, 26);
            this.current_time_textBox.TabIndex = 2;
            this.current_time_textBox.Text = "0";
            this.current_time_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Current time";
            // 
            // current_no_textBox
            // 
            this.current_no_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_no_textBox.Location = new System.Drawing.Point(113, 31);
            this.current_no_textBox.Name = "current_no_textBox";
            this.current_no_textBox.ReadOnly = true;
            this.current_no_textBox.Size = new System.Drawing.Size(108, 26);
            this.current_no_textBox.TabIndex = 0;
            this.current_no_textBox.Text = "0";
            this.current_no_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // elapsed_time_textBox
            // 
            this.elapsed_time_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsed_time_textBox.Location = new System.Drawing.Point(113, 76);
            this.elapsed_time_textBox.Name = "elapsed_time_textBox";
            this.elapsed_time_textBox.ReadOnly = true;
            this.elapsed_time_textBox.Size = new System.Drawing.Size(108, 26);
            this.elapsed_time_textBox.TabIndex = 0;
            this.elapsed_time_textBox.Text = "0";
            this.elapsed_time_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Elapsed time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current No.";
            // 
            // run_timer
            // 
            this.run_timer.Interval = 1000;
            this.run_timer.Tick += new System.EventHandler(this.run_timer_Tick);
            // 
            // info_timer
            // 
            this.info_timer.Interval = 1000;
            this.info_timer.Tick += new System.EventHandler(this.info_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 373);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 373);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox start_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox end_textBox;
        private System.Windows.Forms.CheckBox run_forever_checkBox;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox current_no_textBox;
        private System.Windows.Forms.TextBox elapsed_time_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clean_all_files_button;
        private System.Windows.Forms.TextBox files_in_dir_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox current_time_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer run_timer;
        private System.Windows.Forms.Timer info_timer;
    }
}

