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
            this.倒數 = new System.Windows.Forms.TabPage();
            this.timerClcok = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.時鐘.SuspendLayout();
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
            // 
            // btnSetAlert
            // 
            this.btnSetAlert.Location = new System.Drawing.Point(430, 240);
            this.btnSetAlert.Name = "btnSetAlert";
            this.btnSetAlert.Size = new System.Drawing.Size(158, 37);
            this.btnSetAlert.TabIndex = 3;
            this.btnSetAlert.Text = "設定鬧鐘";
            this.btnSetAlert.UseVisualStyleBackColor = true;
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
            this.碼表.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.碼表.Location = new System.Drawing.Point(4, 22);
            this.碼表.Name = "碼表";
            this.碼表.Padding = new System.Windows.Forms.Padding(3);
            this.碼表.Size = new System.Drawing.Size(768, 400);
            this.碼表.TabIndex = 1;
            this.碼表.Text = "碼表";
            this.碼表.UseVisualStyleBackColor = true;
            // 
            // 倒數
            // 
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
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
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
    }
}

