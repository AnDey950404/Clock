namespace SimpleClock
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.時鐘 = new System.Windows.Forms.TabPage();
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.btnCancelAlert = new System.Windows.Forms.Button();
            this.btnSetAlert = new System.Windows.Forms.Button();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.碼表 = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.listStopWatchLog = new System.Windows.Forms.ListBox();
            this.txtStopWatch = new System.Windows.Forms.TextBox();
            this.倒數 = new System.Windows.Forms.TabPage();
            this.timerClcok = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.cmbCountHour = new System.Windows.Forms.ComboBox();
            this.cmbCountMin = new System.Windows.Forms.ComboBox();
            this.cmbCountSecond = new System.Windows.Forms.ComboBox();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.btnCountPause = new System.Windows.Forms.Button();
            this.btnCountStop = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.時鐘.SuspendLayout();
            this.碼表.SuspendLayout();
            this.倒數.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.時鐘);
            this.tabControl1.Controls.Add(this.碼表);
            this.tabControl1.Controls.Add(this.倒數);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // 時鐘
            // 
            this.時鐘.Controls.Add(this.cmbMin);
            this.時鐘.Controls.Add(this.cmbHour);
            this.時鐘.Controls.Add(this.btnCancelAlert);
            this.時鐘.Controls.Add(this.btnSetAlert);
            this.時鐘.Controls.Add(this.txtWeekDay);
            this.時鐘.Controls.Add(this.txtDate);
            this.時鐘.Controls.Add(this.txtTime);
            this.時鐘.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.時鐘.Location = new System.Drawing.Point(4, 22);
            this.時鐘.Name = "時鐘";
            this.時鐘.Padding = new System.Windows.Forms.Padding(3);
            this.時鐘.Size = new System.Drawing.Size(768, 400);
            this.時鐘.TabIndex = 0;
            this.時鐘.Text = "時鐘";
            this.時鐘.UseVisualStyleBackColor = true;
            // 
            // cmbMin
            // 
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(240, 245);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(137, 29);
            this.cmbMin.TabIndex = 6;
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(60, 245);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(137, 29);
            this.cmbHour.TabIndex = 5;
            // 
            // btnCancelAlert
            // 
            this.btnCancelAlert.Location = new System.Drawing.Point(594, 240);
            this.btnCancelAlert.Name = "btnCancelAlert";
            this.btnCancelAlert.Size = new System.Drawing.Size(158, 37);
            this.btnCancelAlert.TabIndex = 4;
            this.btnCancelAlert.Text = "關閉鬧鐘";
            this.btnCancelAlert.UseVisualStyleBackColor = true;
            this.btnCancelAlert.Click += new System.EventHandler(this.btnCancelAlert_Click);
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Location = new System.Drawing.Point(430, 240);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(158, 37);
            this.btnSetAlert.TabIndex = 3;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
            this.btnSetAlert.Click += new System.EventHandler(this.btnSetAlert_Click);
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWeekDay.Location = new System.Drawing.Point(442, 149);
            this.txtWeekDay.Multiline = true;
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(320, 72);
            this.txtWeekDay.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(6, 149);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(430, 72);
            this.txtDate.TabIndex = 1;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("新細明體", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.Location = new System.Drawing.Point(7, 6);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(756, 137);
            this.txtTime.TabIndex = 0;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 碼表
            // 
            this.碼表.Controls.Add(this.btnStop);
            this.碼表.Controls.Add(this.btnLog);
            this.碼表.Controls.Add(this.btnReset);
            this.碼表.Controls.Add(this.btnPause);
            this.碼表.Controls.Add(this.btnStart);
            this.碼表.Controls.Add(this.listStopWatchLog);
            this.碼表.Controls.Add(this.txtStopWatch);
            this.碼表.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.碼表.Location = new System.Drawing.Point(4, 22);
            this.碼表.Name = "碼表";
            this.碼表.Padding = new System.Windows.Forms.Padding(3);
            this.碼表.Size = new System.Drawing.Size(768, 400);
            this.碼表.TabIndex = 1;
            this.碼表.Text = "碼表";
            this.碼表.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(242, 232);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(276, 34);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停止並歸零";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(383, 191);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(135, 35);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "紀錄";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(242, 191);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "歸零";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Yellow;
            this.btnPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPause.Location = new System.Drawing.Point(383, 150);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(135, 35);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(242, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listStopWatchLog
            // 
            this.listStopWatchLog.FormattingEnabled = true;
            this.listStopWatchLog.ItemHeight = 21;
            this.listStopWatchLog.Location = new System.Drawing.Point(7, 150);
            this.listStopWatchLog.Name = "listStopWatchLog";
            this.listStopWatchLog.Size = new System.Drawing.Size(228, 235);
            this.listStopWatchLog.TabIndex = 2;
            // 
            // txtStopWatch
            // 
            this.txtStopWatch.Enabled = false;
            this.txtStopWatch.Font = new System.Drawing.Font("新細明體", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStopWatch.Location = new System.Drawing.Point(6, 6);
            this.txtStopWatch.Multiline = true;
            this.txtStopWatch.Name = "txtStopWatch";
            this.txtStopWatch.Size = new System.Drawing.Size(756, 137);
            this.txtStopWatch.TabIndex = 1;
            this.txtStopWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 倒數
            // 
            this.倒數.Controls.Add(this.btnCountStop);
            this.倒數.Controls.Add(this.btnCountPause);
            this.倒數.Controls.Add(this.btnCountStart);
            this.倒數.Controls.Add(this.cmbCountSecond);
            this.倒數.Controls.Add(this.cmbCountMin);
            this.倒數.Controls.Add(this.cmbCountHour);
            this.倒數.Controls.Add(this.txtCountDown);
            this.倒數.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.倒數.Location = new System.Drawing.Point(4, 22);
            this.倒數.Name = "倒數";
            this.倒數.Size = new System.Drawing.Size(768, 400);
            this.倒數.TabIndex = 2;
            this.倒數.Text = "倒數";
            this.倒數.UseVisualStyleBackColor = true;
            // 
            // timerClcok
            // 
            this.timerClcok.Tick += new System.EventHandler(this.timerClcok_Tick);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1;
            // 
            // txtCountDown
            // 
            this.txtCountDown.Enabled = false;
            this.txtCountDown.Font = new System.Drawing.Font("新細明體", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCountDown.Location = new System.Drawing.Point(3, 3);
            this.txtCountDown.Multiline = true;
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(756, 137);
            this.txtCountDown.TabIndex = 2;
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbCountHour
            // 
            this.cmbCountHour.FormattingEnabled = true;
            this.cmbCountHour.Location = new System.Drawing.Point(14, 146);
            this.cmbCountHour.Name = "cmbCountHour";
            this.cmbCountHour.Size = new System.Drawing.Size(137, 29);
            this.cmbCountHour.TabIndex = 6;
            // 
            // cmbCountMin
            // 
            this.cmbCountMin.FormattingEnabled = true;
            this.cmbCountMin.Location = new System.Drawing.Point(157, 146);
            this.cmbCountMin.Name = "cmbCountMin";
            this.cmbCountMin.Size = new System.Drawing.Size(137, 29);
            this.cmbCountMin.TabIndex = 7;
            // 
            // cmbCountSecond
            // 
            this.cmbCountSecond.FormattingEnabled = true;
            this.cmbCountSecond.Location = new System.Drawing.Point(300, 146);
            this.cmbCountSecond.Name = "cmbCountSecond";
            this.cmbCountSecond.Size = new System.Drawing.Size(137, 29);
            this.cmbCountSecond.TabIndex = 8;
            // 
            // btnCountStart
            // 
            this.btnCountStart.Location = new System.Drawing.Point(14, 181);
            this.btnCountStart.Name = "btnCountStart";
            this.btnCountStart.Size = new System.Drawing.Size(384, 35);
            this.btnCountStart.TabIndex = 9;
            this.btnCountStart.Text = "開始倒數";
            this.btnCountStart.UseVisualStyleBackColor = true;
            this.btnCountStart.Click += new System.EventHandler(this.btnCountStart_Click);
            // 
            // btnCountPause
            // 
            this.btnCountPause.Location = new System.Drawing.Point(14, 222);
            this.btnCountPause.Name = "btnCountPause";
            this.btnCountPause.Size = new System.Drawing.Size(384, 35);
            this.btnCountPause.TabIndex = 10;
            this.btnCountPause.Text = "暫停";
            this.btnCountPause.UseVisualStyleBackColor = true;
            this.btnCountPause.Click += new System.EventHandler(this.btnCountPause_Click);
            // 
            // btnCountStop
            // 
            this.btnCountStop.BackColor = System.Drawing.Color.Red;
            this.btnCountStop.ForeColor = System.Drawing.Color.White;
            this.btnCountStop.Location = new System.Drawing.Point(14, 263);
            this.btnCountStop.Name = "btnCountStop";
            this.btnCountStop.Size = new System.Drawing.Size(384, 35);
            this.btnCountStop.TabIndex = 11;
            this.btnCountStop.Text = "停止";
            this.btnCountStop.UseVisualStyleBackColor = false;
            this.btnCountStop.Click += new System.EventHandler(this.btnCountStop_Click);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "簡單時鐘";
            this.tabControl1.ResumeLayout(false);
            this.時鐘.ResumeLayout(false);
            this.時鐘.PerformLayout();
            this.碼表.ResumeLayout(false);
            this.碼表.PerformLayout();
            this.倒數.ResumeLayout(false);
            this.倒數.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 時鐘;
        private System.Windows.Forms.TabPage 碼表;
        private System.Windows.Forms.TabPage 倒數;
        private System.Windows.Forms.Button btnSetAlert;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Button btnCancelAlert;
        private System.Windows.Forms.Timer timerClcok;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listStopWatchLog;
        private System.Windows.Forms.TextBox txtStopWatch;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.ComboBox cmbCountSecond;
        private System.Windows.Forms.ComboBox cmbCountMin;
        private System.Windows.Forms.ComboBox cmbCountHour;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnCountPause;
        private System.Windows.Forms.Button btnCountStart;
        private System.Windows.Forms.Button btnCountStop;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

