namespace WeeklyCalendar
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.DaysTab = new System.Windows.Forms.TabControl();
            this.Monday = new System.Windows.Forms.TabPage();
            this.MondayInfo = new System.Windows.Forms.TextBox();
            this.MondayList = new System.Windows.Forms.ListBox();
            this.Tuesday = new System.Windows.Forms.TabPage();
            this.TuesdayInfo = new System.Windows.Forms.TextBox();
            this.TuesdayList = new System.Windows.Forms.ListBox();
            this.Wednesday = new System.Windows.Forms.TabPage();
            this.WednesdayInfo = new System.Windows.Forms.TextBox();
            this.WednesdayList = new System.Windows.Forms.ListBox();
            this.Thursday = new System.Windows.Forms.TabPage();
            this.ThursdayInfo = new System.Windows.Forms.TextBox();
            this.ThursdayList = new System.Windows.Forms.ListBox();
            this.Friday = new System.Windows.Forms.TabPage();
            this.FridayInfo = new System.Windows.Forms.TextBox();
            this.FridayList = new System.Windows.Forms.ListBox();
            this.Saturday = new System.Windows.Forms.TabPage();
            this.SaturdayInfo = new System.Windows.Forms.TextBox();
            this.SaturdayList = new System.Windows.Forms.ListBox();
            this.Sunday = new System.Windows.Forms.TabPage();
            this.SundayList = new System.Windows.Forms.ListBox();
            this.SundayInfo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DaysTab.SuspendLayout();
            this.Monday.SuspendLayout();
            this.Tuesday.SuspendLayout();
            this.Wednesday.SuspendLayout();
            this.Thursday.SuspendLayout();
            this.Friday.SuspendLayout();
            this.Saturday.SuspendLayout();
            this.Sunday.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DaysTab
            // 
            this.DaysTab.AccessibleName = "";
            this.DaysTab.Controls.Add(this.Monday);
            this.DaysTab.Controls.Add(this.Tuesday);
            this.DaysTab.Controls.Add(this.Wednesday);
            this.DaysTab.Controls.Add(this.Thursday);
            this.DaysTab.Controls.Add(this.Friday);
            this.DaysTab.Controls.Add(this.Saturday);
            this.DaysTab.Controls.Add(this.Sunday);
            this.DaysTab.Location = new System.Drawing.Point(12, 31);
            this.DaysTab.Name = "DaysTab";
            this.DaysTab.SelectedIndex = 0;
            this.DaysTab.Size = new System.Drawing.Size(754, 344);
            this.DaysTab.TabIndex = 1;
            // 
            // Monday
            // 
            this.Monday.Controls.Add(this.MondayInfo);
            this.Monday.Controls.Add(this.MondayList);
            this.Monday.Location = new System.Drawing.Point(4, 25);
            this.Monday.Name = "Monday";
            this.Monday.Padding = new System.Windows.Forms.Padding(3);
            this.Monday.Size = new System.Drawing.Size(746, 315);
            this.Monday.TabIndex = 0;
            this.Monday.Text = "Monday";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // MondayInfo
            // 
            this.MondayInfo.Location = new System.Drawing.Point(445, 4);
            this.MondayInfo.Multiline = true;
            this.MondayInfo.Name = "MondayInfo";
            this.MondayInfo.ReadOnly = true;
            this.MondayInfo.Size = new System.Drawing.Size(295, 308);
            this.MondayInfo.TabIndex = 1;
            // 
            // MondayList
            // 
            this.MondayList.FormattingEnabled = true;
            this.MondayList.ItemHeight = 16;
            this.MondayList.Location = new System.Drawing.Point(3, 4);
            this.MondayList.Name = "MondayList";
            this.MondayList.Size = new System.Drawing.Size(435, 308);
            this.MondayList.TabIndex = 0;
            this.MondayList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedListItem);
            // 
            // Tuesday
            // 
            this.Tuesday.Controls.Add(this.TuesdayInfo);
            this.Tuesday.Controls.Add(this.TuesdayList);
            this.Tuesday.Location = new System.Drawing.Point(4, 25);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Padding = new System.Windows.Forms.Padding(3);
            this.Tuesday.Size = new System.Drawing.Size(746, 315);
            this.Tuesday.TabIndex = 1;
            this.Tuesday.Text = "Tuesday";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // TuesdayInfo
            // 
            this.TuesdayInfo.Location = new System.Drawing.Point(445, 4);
            this.TuesdayInfo.Multiline = true;
            this.TuesdayInfo.Name = "TuesdayInfo";
            this.TuesdayInfo.ReadOnly = true;
            this.TuesdayInfo.Size = new System.Drawing.Size(295, 308);
            this.TuesdayInfo.TabIndex = 4;
            // 
            // TuesdayList
            // 
            this.TuesdayList.FormattingEnabled = true;
            this.TuesdayList.ItemHeight = 16;
            this.TuesdayList.Location = new System.Drawing.Point(3, 4);
            this.TuesdayList.Name = "TuesdayList";
            this.TuesdayList.Size = new System.Drawing.Size(435, 308);
            this.TuesdayList.TabIndex = 3;
            this.TuesdayList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedListItem);
            // 
            // Wednesday
            // 
            this.Wednesday.Controls.Add(this.WednesdayInfo);
            this.Wednesday.Controls.Add(this.WednesdayList);
            this.Wednesday.Location = new System.Drawing.Point(4, 25);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Padding = new System.Windows.Forms.Padding(3);
            this.Wednesday.Size = new System.Drawing.Size(746, 315);
            this.Wednesday.TabIndex = 2;
            this.Wednesday.Text = "Wednesday";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // WednesdayInfo
            // 
            this.WednesdayInfo.Location = new System.Drawing.Point(445, 4);
            this.WednesdayInfo.Multiline = true;
            this.WednesdayInfo.Name = "WednesdayInfo";
            this.WednesdayInfo.ReadOnly = true;
            this.WednesdayInfo.Size = new System.Drawing.Size(295, 308);
            this.WednesdayInfo.TabIndex = 1;
            // 
            // WednesdayList
            // 
            this.WednesdayList.FormattingEnabled = true;
            this.WednesdayList.ItemHeight = 16;
            this.WednesdayList.Location = new System.Drawing.Point(3, 4);
            this.WednesdayList.Name = "WednesdayList";
            this.WednesdayList.Size = new System.Drawing.Size(435, 308);
            this.WednesdayList.TabIndex = 0;
            this.WednesdayList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedListItem);
            // 
            // Thursday
            // 
            this.Thursday.Controls.Add(this.ThursdayInfo);
            this.Thursday.Controls.Add(this.ThursdayList);
            this.Thursday.Location = new System.Drawing.Point(4, 25);
            this.Thursday.Name = "Thursday";
            this.Thursday.Padding = new System.Windows.Forms.Padding(3);
            this.Thursday.Size = new System.Drawing.Size(746, 315);
            this.Thursday.TabIndex = 3;
            this.Thursday.Text = "Thursday";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // ThursdayInfo
            // 
            this.ThursdayInfo.Location = new System.Drawing.Point(445, 4);
            this.ThursdayInfo.Multiline = true;
            this.ThursdayInfo.Name = "ThursdayInfo";
            this.ThursdayInfo.ReadOnly = true;
            this.ThursdayInfo.Size = new System.Drawing.Size(295, 308);
            this.ThursdayInfo.TabIndex = 4;
            // 
            // ThursdayList
            // 
            this.ThursdayList.FormattingEnabled = true;
            this.ThursdayList.ItemHeight = 16;
            this.ThursdayList.Location = new System.Drawing.Point(3, 4);
            this.ThursdayList.Name = "ThursdayList";
            this.ThursdayList.Size = new System.Drawing.Size(435, 308);
            this.ThursdayList.TabIndex = 3;
            this.ThursdayList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedListItem);
            // 
            // Friday
            // 
            this.Friday.Controls.Add(this.FridayInfo);
            this.Friday.Controls.Add(this.FridayList);
            this.Friday.Location = new System.Drawing.Point(4, 25);
            this.Friday.Name = "Friday";
            this.Friday.Padding = new System.Windows.Forms.Padding(3);
            this.Friday.Size = new System.Drawing.Size(746, 315);
            this.Friday.TabIndex = 4;
            this.Friday.Text = "Friday";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // FridayInfo
            // 
            this.FridayInfo.Location = new System.Drawing.Point(445, 4);
            this.FridayInfo.Multiline = true;
            this.FridayInfo.Name = "FridayInfo";
            this.FridayInfo.ReadOnly = true;
            this.FridayInfo.Size = new System.Drawing.Size(295, 308);
            this.FridayInfo.TabIndex = 1;
            // 
            // FridayList
            // 
            this.FridayList.FormattingEnabled = true;
            this.FridayList.ItemHeight = 16;
            this.FridayList.Location = new System.Drawing.Point(3, 4);
            this.FridayList.Name = "FridayList";
            this.FridayList.Size = new System.Drawing.Size(435, 308);
            this.FridayList.TabIndex = 0;
            this.FridayList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedListItem);
            // 
            // Saturday
            // 
            this.Saturday.Controls.Add(this.SaturdayInfo);
            this.Saturday.Controls.Add(this.SaturdayList);
            this.Saturday.Location = new System.Drawing.Point(4, 25);
            this.Saturday.Name = "Saturday";
            this.Saturday.Padding = new System.Windows.Forms.Padding(3);
            this.Saturday.Size = new System.Drawing.Size(746, 315);
            this.Saturday.TabIndex = 5;
            this.Saturday.Text = "Saturday";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // SaturdayInfo
            // 
            this.SaturdayInfo.Location = new System.Drawing.Point(445, 4);
            this.SaturdayInfo.Multiline = true;
            this.SaturdayInfo.Name = "SaturdayInfo";
            this.SaturdayInfo.ReadOnly = true;
            this.SaturdayInfo.Size = new System.Drawing.Size(295, 308);
            this.SaturdayInfo.TabIndex = 2;
            // 
            // SaturdayList
            // 
            this.SaturdayList.FormattingEnabled = true;
            this.SaturdayList.ItemHeight = 16;
            this.SaturdayList.Location = new System.Drawing.Point(3, 4);
            this.SaturdayList.Name = "SaturdayList";
            this.SaturdayList.Size = new System.Drawing.Size(435, 308);
            this.SaturdayList.TabIndex = 1;
            this.SaturdayList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedListItem);
            // 
            // Sunday
            // 
            this.Sunday.Controls.Add(this.SundayList);
            this.Sunday.Controls.Add(this.SundayInfo);
            this.Sunday.Location = new System.Drawing.Point(4, 25);
            this.Sunday.Name = "Sunday";
            this.Sunday.Padding = new System.Windows.Forms.Padding(3);
            this.Sunday.Size = new System.Drawing.Size(746, 315);
            this.Sunday.TabIndex = 6;
            this.Sunday.Text = "Sunday";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // SundayList
            // 
            this.SundayList.FormattingEnabled = true;
            this.SundayList.ItemHeight = 16;
            this.SundayList.Location = new System.Drawing.Point(3, 4);
            this.SundayList.Name = "SundayList";
            this.SundayList.Size = new System.Drawing.Size(435, 308);
            this.SundayList.TabIndex = 3;
            this.SundayList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedListItem);
            // 
            // SundayInfo
            // 
            this.SundayInfo.Location = new System.Drawing.Point(445, 4);
            this.SundayInfo.Multiline = true;
            this.SundayInfo.Name = "SundayInfo";
            this.SundayInfo.ReadOnly = true;
            this.SundayInfo.Size = new System.Drawing.Size(295, 308);
            this.SundayInfo.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.timeZoneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.settingsToolStripMenuItem.Text = "Customise";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // timeZoneToolStripMenuItem
            // 
            this.timeZoneToolStripMenuItem.Name = "timeZoneToolStripMenuItem";
            this.timeZoneToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.timeZoneToolStripMenuItem.Text = "Time Zone";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(184, 377);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(103, 377);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(22, 377);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 409);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DaysTab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calendar_FormClosed);
            this.Load += new System.EventHandler(this.onFormOpen);
            this.DaysTab.ResumeLayout(false);
            this.Monday.ResumeLayout(false);
            this.Monday.PerformLayout();
            this.Tuesday.ResumeLayout(false);
            this.Tuesday.PerformLayout();
            this.Wednesday.ResumeLayout(false);
            this.Wednesday.PerformLayout();
            this.Thursday.ResumeLayout(false);
            this.Thursday.PerformLayout();
            this.Friday.ResumeLayout(false);
            this.Friday.PerformLayout();
            this.Saturday.ResumeLayout(false);
            this.Saturday.PerformLayout();
            this.Sunday.ResumeLayout(false);
            this.Sunday.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl DaysTab;
        private System.Windows.Forms.TabPage Monday;
        private System.Windows.Forms.ListBox MondayList;
        private System.Windows.Forms.TabPage Tuesday;
        private System.Windows.Forms.TabPage Wednesday;
        private System.Windows.Forms.TabPage Thursday;
        private System.Windows.Forms.TabPage Friday;
        private System.Windows.Forms.TabPage Saturday;
        private System.Windows.Forms.TabPage Sunday;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeZoneToolStripMenuItem;
        private System.Windows.Forms.ListBox TuesdayList;
        private System.Windows.Forms.ListBox WednesdayList;
        private System.Windows.Forms.ListBox ThursdayList;
        private System.Windows.Forms.ListBox FridayList;
        private System.Windows.Forms.ListBox SaturdayList;
        private System.Windows.Forms.ListBox SundayList;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox MondayInfo;
        private System.Windows.Forms.TextBox TuesdayInfo;
        private System.Windows.Forms.TextBox WednesdayInfo;
        private System.Windows.Forms.TextBox ThursdayInfo;
        private System.Windows.Forms.TextBox FridayInfo;
        private System.Windows.Forms.TextBox SaturdayInfo;
        private System.Windows.Forms.TextBox SundayInfo;
    }
}

