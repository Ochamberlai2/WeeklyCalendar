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
            this.DaysTab = new System.Windows.Forms.TabControl();
            this.Monday = new System.Windows.Forms.TabPage();
            this.MondayEdit = new System.Windows.Forms.Button();
            this.MondayRemove = new System.Windows.Forms.Button();
            this.MondayAdd = new System.Windows.Forms.Button();
            this.MondayInfo = new System.Windows.Forms.TextBox();
            this.MondayList = new System.Windows.Forms.ListBox();
            this.Tuesday = new System.Windows.Forms.TabPage();
            this.TuesdayInfo = new System.Windows.Forms.TextBox();
            this.TuesdayList = new System.Windows.Forms.ListBox();
            this.TuesdayEdit = new System.Windows.Forms.Button();
            this.TuesdayRemove = new System.Windows.Forms.Button();
            this.TuesdayAdd = new System.Windows.Forms.Button();
            this.Wednesday = new System.Windows.Forms.TabPage();
            this.WednesdayEdit = new System.Windows.Forms.Button();
            this.WednesdayRemove = new System.Windows.Forms.Button();
            this.WednesdayAdd = new System.Windows.Forms.Button();
            this.WednesdayInfo = new System.Windows.Forms.TextBox();
            this.WednesdayList = new System.Windows.Forms.ListBox();
            this.Thursday = new System.Windows.Forms.TabPage();
            this.ThursdayInfo = new System.Windows.Forms.TextBox();
            this.ThursdayList = new System.Windows.Forms.ListBox();
            this.ThursdayEdit = new System.Windows.Forms.Button();
            this.ThursdayRemove = new System.Windows.Forms.Button();
            this.ThursdayAdd = new System.Windows.Forms.Button();
            this.Friday = new System.Windows.Forms.TabPage();
            this.FridayEdit = new System.Windows.Forms.Button();
            this.FridayRemove = new System.Windows.Forms.Button();
            this.FridayAdd = new System.Windows.Forms.Button();
            this.FridayInfo = new System.Windows.Forms.TextBox();
            this.FridayList = new System.Windows.Forms.ListBox();
            this.Saturday = new System.Windows.Forms.TabPage();
            this.SaturdayEdit = new System.Windows.Forms.Button();
            this.SaturdayRemove = new System.Windows.Forms.Button();
            this.SaturdayAdd = new System.Windows.Forms.Button();
            this.SaturdayInfo = new System.Windows.Forms.TextBox();
            this.SaturdayList = new System.Windows.Forms.ListBox();
            this.Sunday = new System.Windows.Forms.TabPage();
            this.SundayEdit = new System.Windows.Forms.Button();
            this.SundayRemove = new System.Windows.Forms.Button();
            this.SundayAdd = new System.Windows.Forms.Button();
            this.SundayList = new System.Windows.Forms.ListBox();
            this.SundayInfo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.DaysTab.Size = new System.Drawing.Size(754, 395);
            this.DaysTab.TabIndex = 1;
            // 
            // Monday
            // 
            this.Monday.Controls.Add(this.MondayEdit);
            this.Monday.Controls.Add(this.MondayRemove);
            this.Monday.Controls.Add(this.MondayAdd);
            this.Monday.Controls.Add(this.MondayInfo);
            this.Monday.Controls.Add(this.MondayList);
            this.Monday.Location = new System.Drawing.Point(4, 25);
            this.Monday.Name = "Monday";
            this.Monday.Padding = new System.Windows.Forms.Padding(3);
            this.Monday.Size = new System.Drawing.Size(746, 366);
            this.Monday.TabIndex = 0;
            this.Monday.Text = "Monday";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // MondayEdit
            // 
            this.MondayEdit.Location = new System.Drawing.Point(168, 334);
            this.MondayEdit.Name = "MondayEdit";
            this.MondayEdit.Size = new System.Drawing.Size(75, 23);
            this.MondayEdit.TabIndex = 4;
            this.MondayEdit.Text = "Edit";
            this.MondayEdit.UseVisualStyleBackColor = true;
            // 
            // MondayRemove
            // 
            this.MondayRemove.Location = new System.Drawing.Point(87, 334);
            this.MondayRemove.Name = "MondayRemove";
            this.MondayRemove.Size = new System.Drawing.Size(75, 23);
            this.MondayRemove.TabIndex = 3;
            this.MondayRemove.Text = "Remove";
            this.MondayRemove.UseVisualStyleBackColor = true;
            // 
            // MondayAdd
            // 
            this.MondayAdd.Location = new System.Drawing.Point(6, 334);
            this.MondayAdd.Name = "MondayAdd";
            this.MondayAdd.Size = new System.Drawing.Size(75, 23);
            this.MondayAdd.TabIndex = 2;
            this.MondayAdd.Text = "Add";
            this.MondayAdd.UseVisualStyleBackColor = true;
            this.MondayAdd.Click += new System.EventHandler(this.MondayAdd_Click);
            // 
            // MondayInfo
            // 
            this.MondayInfo.Location = new System.Drawing.Point(445, 4);
            this.MondayInfo.Multiline = true;
            this.MondayInfo.Name = "MondayInfo";
            this.MondayInfo.Size = new System.Drawing.Size(295, 321);
            this.MondayInfo.TabIndex = 1;
            // 
            // MondayList
            // 
            this.MondayList.FormattingEnabled = true;
            this.MondayList.ItemHeight = 16;
            this.MondayList.Location = new System.Drawing.Point(3, 4);
            this.MondayList.Name = "MondayList";
            this.MondayList.Size = new System.Drawing.Size(435, 324);
            this.MondayList.TabIndex = 0;
            this.MondayList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Tuesday
            // 
            this.Tuesday.Controls.Add(this.TuesdayInfo);
            this.Tuesday.Controls.Add(this.TuesdayList);
            this.Tuesday.Controls.Add(this.TuesdayEdit);
            this.Tuesday.Controls.Add(this.TuesdayRemove);
            this.Tuesday.Controls.Add(this.TuesdayAdd);
            this.Tuesday.Location = new System.Drawing.Point(4, 25);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Padding = new System.Windows.Forms.Padding(3);
            this.Tuesday.Size = new System.Drawing.Size(746, 366);
            this.Tuesday.TabIndex = 1;
            this.Tuesday.Text = "Tuesday";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // TuesdayInfo
            // 
            this.TuesdayInfo.Location = new System.Drawing.Point(445, 4);
            this.TuesdayInfo.Multiline = true;
            this.TuesdayInfo.Name = "TuesdayInfo";
            this.TuesdayInfo.Size = new System.Drawing.Size(295, 321);
            this.TuesdayInfo.TabIndex = 4;
            this.TuesdayInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TuesdayList
            // 
            this.TuesdayList.FormattingEnabled = true;
            this.TuesdayList.ItemHeight = 16;
            this.TuesdayList.Location = new System.Drawing.Point(3, 4);
            this.TuesdayList.Name = "TuesdayList";
            this.TuesdayList.Size = new System.Drawing.Size(435, 324);
            this.TuesdayList.TabIndex = 3;
            // 
            // TuesdayEdit
            // 
            this.TuesdayEdit.Location = new System.Drawing.Point(168, 334);
            this.TuesdayEdit.Name = "TuesdayEdit";
            this.TuesdayEdit.Size = new System.Drawing.Size(75, 23);
            this.TuesdayEdit.TabIndex = 2;
            this.TuesdayEdit.Text = "Edit";
            this.TuesdayEdit.UseVisualStyleBackColor = true;
            // 
            // TuesdayRemove
            // 
            this.TuesdayRemove.Location = new System.Drawing.Point(87, 334);
            this.TuesdayRemove.Name = "TuesdayRemove";
            this.TuesdayRemove.Size = new System.Drawing.Size(75, 23);
            this.TuesdayRemove.TabIndex = 1;
            this.TuesdayRemove.Text = "Remove";
            this.TuesdayRemove.UseVisualStyleBackColor = true;
            this.TuesdayRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // TuesdayAdd
            // 
            this.TuesdayAdd.Location = new System.Drawing.Point(6, 334);
            this.TuesdayAdd.Name = "TuesdayAdd";
            this.TuesdayAdd.Size = new System.Drawing.Size(75, 23);
            this.TuesdayAdd.TabIndex = 0;
            this.TuesdayAdd.Text = "Add";
            this.TuesdayAdd.UseVisualStyleBackColor = true;
            this.TuesdayAdd.Click += new System.EventHandler(this.TuesdayAdd_Click);
            // 
            // Wednesday
            // 
            this.Wednesday.Controls.Add(this.WednesdayEdit);
            this.Wednesday.Controls.Add(this.WednesdayRemove);
            this.Wednesday.Controls.Add(this.WednesdayAdd);
            this.Wednesday.Controls.Add(this.WednesdayInfo);
            this.Wednesday.Controls.Add(this.WednesdayList);
            this.Wednesday.Location = new System.Drawing.Point(4, 25);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Padding = new System.Windows.Forms.Padding(3);
            this.Wednesday.Size = new System.Drawing.Size(746, 366);
            this.Wednesday.TabIndex = 2;
            this.Wednesday.Text = "Wednesday";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // WednesdayEdit
            // 
            this.WednesdayEdit.Location = new System.Drawing.Point(170, 334);
            this.WednesdayEdit.Name = "WednesdayEdit";
            this.WednesdayEdit.Size = new System.Drawing.Size(75, 23);
            this.WednesdayEdit.TabIndex = 4;
            this.WednesdayEdit.Text = "Edit";
            this.WednesdayEdit.UseVisualStyleBackColor = true;
            // 
            // WednesdayRemove
            // 
            this.WednesdayRemove.Location = new System.Drawing.Point(88, 334);
            this.WednesdayRemove.Name = "WednesdayRemove";
            this.WednesdayRemove.Size = new System.Drawing.Size(75, 23);
            this.WednesdayRemove.TabIndex = 3;
            this.WednesdayRemove.Text = "Remove";
            this.WednesdayRemove.UseVisualStyleBackColor = true;
            // 
            // WednesdayAdd
            // 
            this.WednesdayAdd.Location = new System.Drawing.Point(6, 334);
            this.WednesdayAdd.Name = "WednesdayAdd";
            this.WednesdayAdd.Size = new System.Drawing.Size(75, 23);
            this.WednesdayAdd.TabIndex = 2;
            this.WednesdayAdd.Text = "Add";
            this.WednesdayAdd.UseVisualStyleBackColor = true;
            this.WednesdayAdd.Click += new System.EventHandler(this.WednesdayAdd_Click);
            // 
            // WednesdayInfo
            // 
            this.WednesdayInfo.Location = new System.Drawing.Point(445, 4);
            this.WednesdayInfo.Multiline = true;
            this.WednesdayInfo.Name = "WednesdayInfo";
            this.WednesdayInfo.Size = new System.Drawing.Size(295, 321);
            this.WednesdayInfo.TabIndex = 1;
            // 
            // WednesdayList
            // 
            this.WednesdayList.FormattingEnabled = true;
            this.WednesdayList.ItemHeight = 16;
            this.WednesdayList.Location = new System.Drawing.Point(3, 4);
            this.WednesdayList.Name = "WednesdayList";
            this.WednesdayList.Size = new System.Drawing.Size(435, 324);
            this.WednesdayList.TabIndex = 0;
            // 
            // Thursday
            // 
            this.Thursday.Controls.Add(this.ThursdayInfo);
            this.Thursday.Controls.Add(this.ThursdayList);
            this.Thursday.Controls.Add(this.ThursdayEdit);
            this.Thursday.Controls.Add(this.ThursdayRemove);
            this.Thursday.Controls.Add(this.ThursdayAdd);
            this.Thursday.Location = new System.Drawing.Point(4, 25);
            this.Thursday.Name = "Thursday";
            this.Thursday.Padding = new System.Windows.Forms.Padding(3);
            this.Thursday.Size = new System.Drawing.Size(746, 366);
            this.Thursday.TabIndex = 3;
            this.Thursday.Text = "Thursday";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // ThursdayInfo
            // 
            this.ThursdayInfo.Location = new System.Drawing.Point(445, 4);
            this.ThursdayInfo.Multiline = true;
            this.ThursdayInfo.Name = "ThursdayInfo";
            this.ThursdayInfo.Size = new System.Drawing.Size(295, 321);
            this.ThursdayInfo.TabIndex = 4;
            // 
            // ThursdayList
            // 
            this.ThursdayList.FormattingEnabled = true;
            this.ThursdayList.ItemHeight = 16;
            this.ThursdayList.Location = new System.Drawing.Point(3, 4);
            this.ThursdayList.Name = "ThursdayList";
            this.ThursdayList.Size = new System.Drawing.Size(435, 324);
            this.ThursdayList.TabIndex = 3;
            this.ThursdayList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ThursdayEdit
            // 
            this.ThursdayEdit.Location = new System.Drawing.Point(170, 336);
            this.ThursdayEdit.Name = "ThursdayEdit";
            this.ThursdayEdit.Size = new System.Drawing.Size(75, 23);
            this.ThursdayEdit.TabIndex = 2;
            this.ThursdayEdit.Text = "Edit";
            this.ThursdayEdit.UseVisualStyleBackColor = true;
            // 
            // ThursdayRemove
            // 
            this.ThursdayRemove.Location = new System.Drawing.Point(88, 337);
            this.ThursdayRemove.Name = "ThursdayRemove";
            this.ThursdayRemove.Size = new System.Drawing.Size(75, 23);
            this.ThursdayRemove.TabIndex = 1;
            this.ThursdayRemove.Text = "Remove";
            this.ThursdayRemove.UseVisualStyleBackColor = true;
            // 
            // ThursdayAdd
            // 
            this.ThursdayAdd.Location = new System.Drawing.Point(7, 337);
            this.ThursdayAdd.Name = "ThursdayAdd";
            this.ThursdayAdd.Size = new System.Drawing.Size(75, 23);
            this.ThursdayAdd.TabIndex = 0;
            this.ThursdayAdd.Text = "Add";
            this.ThursdayAdd.UseVisualStyleBackColor = true;
            this.ThursdayAdd.Click += new System.EventHandler(this.ThursdayAdd_Click);
            // 
            // Friday
            // 
            this.Friday.Controls.Add(this.FridayEdit);
            this.Friday.Controls.Add(this.FridayRemove);
            this.Friday.Controls.Add(this.FridayAdd);
            this.Friday.Controls.Add(this.FridayInfo);
            this.Friday.Controls.Add(this.FridayList);
            this.Friday.Location = new System.Drawing.Point(4, 25);
            this.Friday.Name = "Friday";
            this.Friday.Padding = new System.Windows.Forms.Padding(3);
            this.Friday.Size = new System.Drawing.Size(746, 366);
            this.Friday.TabIndex = 4;
            this.Friday.Text = "Friday";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // FridayEdit
            // 
            this.FridayEdit.Location = new System.Drawing.Point(169, 337);
            this.FridayEdit.Name = "FridayEdit";
            this.FridayEdit.Size = new System.Drawing.Size(75, 23);
            this.FridayEdit.TabIndex = 4;
            this.FridayEdit.Text = "Edit";
            this.FridayEdit.UseVisualStyleBackColor = true;
            // 
            // FridayRemove
            // 
            this.FridayRemove.Location = new System.Drawing.Point(88, 337);
            this.FridayRemove.Name = "FridayRemove";
            this.FridayRemove.Size = new System.Drawing.Size(75, 23);
            this.FridayRemove.TabIndex = 3;
            this.FridayRemove.Text = "Remove";
            this.FridayRemove.UseVisualStyleBackColor = true;
            // 
            // FridayAdd
            // 
            this.FridayAdd.Location = new System.Drawing.Point(7, 337);
            this.FridayAdd.Name = "FridayAdd";
            this.FridayAdd.Size = new System.Drawing.Size(75, 23);
            this.FridayAdd.TabIndex = 2;
            this.FridayAdd.Text = "Add";
            this.FridayAdd.UseVisualStyleBackColor = true;
            this.FridayAdd.Click += new System.EventHandler(this.FridayAdd_Click);
            // 
            // FridayInfo
            // 
            this.FridayInfo.Location = new System.Drawing.Point(445, 4);
            this.FridayInfo.Multiline = true;
            this.FridayInfo.Name = "FridayInfo";
            this.FridayInfo.Size = new System.Drawing.Size(295, 321);
            this.FridayInfo.TabIndex = 1;
            // 
            // FridayList
            // 
            this.FridayList.FormattingEnabled = true;
            this.FridayList.ItemHeight = 16;
            this.FridayList.Location = new System.Drawing.Point(3, 4);
            this.FridayList.Name = "FridayList";
            this.FridayList.Size = new System.Drawing.Size(435, 324);
            this.FridayList.TabIndex = 0;
            // 
            // Saturday
            // 
            this.Saturday.Controls.Add(this.SaturdayEdit);
            this.Saturday.Controls.Add(this.SaturdayRemove);
            this.Saturday.Controls.Add(this.SaturdayAdd);
            this.Saturday.Controls.Add(this.SaturdayInfo);
            this.Saturday.Controls.Add(this.SaturdayList);
            this.Saturday.Location = new System.Drawing.Point(4, 25);
            this.Saturday.Name = "Saturday";
            this.Saturday.Padding = new System.Windows.Forms.Padding(3);
            this.Saturday.Size = new System.Drawing.Size(746, 366);
            this.Saturday.TabIndex = 5;
            this.Saturday.Text = "Saturday";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // SaturdayEdit
            // 
            this.SaturdayEdit.Location = new System.Drawing.Point(169, 340);
            this.SaturdayEdit.Name = "SaturdayEdit";
            this.SaturdayEdit.Size = new System.Drawing.Size(75, 23);
            this.SaturdayEdit.TabIndex = 5;
            this.SaturdayEdit.Text = "Edit";
            this.SaturdayEdit.UseVisualStyleBackColor = true;
            // 
            // SaturdayRemove
            // 
            this.SaturdayRemove.Location = new System.Drawing.Point(88, 339);
            this.SaturdayRemove.Name = "SaturdayRemove";
            this.SaturdayRemove.Size = new System.Drawing.Size(75, 23);
            this.SaturdayRemove.TabIndex = 4;
            this.SaturdayRemove.Text = "Remove";
            this.SaturdayRemove.UseVisualStyleBackColor = true;
            // 
            // SaturdayAdd
            // 
            this.SaturdayAdd.Location = new System.Drawing.Point(7, 337);
            this.SaturdayAdd.Name = "SaturdayAdd";
            this.SaturdayAdd.Size = new System.Drawing.Size(75, 23);
            this.SaturdayAdd.TabIndex = 3;
            this.SaturdayAdd.Text = "Add";
            this.SaturdayAdd.UseVisualStyleBackColor = true;
            this.SaturdayAdd.Click += new System.EventHandler(this.SaturdayAdd_Click);
            // 
            // SaturdayInfo
            // 
            this.SaturdayInfo.Location = new System.Drawing.Point(445, 4);
            this.SaturdayInfo.Multiline = true;
            this.SaturdayInfo.Name = "SaturdayInfo";
            this.SaturdayInfo.Size = new System.Drawing.Size(295, 321);
            this.SaturdayInfo.TabIndex = 2;
            // 
            // SaturdayList
            // 
            this.SaturdayList.FormattingEnabled = true;
            this.SaturdayList.ItemHeight = 16;
            this.SaturdayList.Location = new System.Drawing.Point(3, 4);
            this.SaturdayList.Name = "SaturdayList";
            this.SaturdayList.Size = new System.Drawing.Size(435, 324);
            this.SaturdayList.TabIndex = 1;
            // 
            // Sunday
            // 
            this.Sunday.Controls.Add(this.SundayEdit);
            this.Sunday.Controls.Add(this.SundayRemove);
            this.Sunday.Controls.Add(this.SundayAdd);
            this.Sunday.Controls.Add(this.SundayList);
            this.Sunday.Controls.Add(this.SundayInfo);
            this.Sunday.Location = new System.Drawing.Point(4, 25);
            this.Sunday.Name = "Sunday";
            this.Sunday.Padding = new System.Windows.Forms.Padding(3);
            this.Sunday.Size = new System.Drawing.Size(746, 366);
            this.Sunday.TabIndex = 6;
            this.Sunday.Text = "Sunday";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // SundayEdit
            // 
            this.SundayEdit.Location = new System.Drawing.Point(169, 337);
            this.SundayEdit.Name = "SundayEdit";
            this.SundayEdit.Size = new System.Drawing.Size(75, 23);
            this.SundayEdit.TabIndex = 6;
            this.SundayEdit.Text = "Edit";
            this.SundayEdit.UseVisualStyleBackColor = true;
            // 
            // SundayRemove
            // 
            this.SundayRemove.Location = new System.Drawing.Point(88, 337);
            this.SundayRemove.Name = "SundayRemove";
            this.SundayRemove.Size = new System.Drawing.Size(75, 23);
            this.SundayRemove.TabIndex = 5;
            this.SundayRemove.Text = "Remove";
            this.SundayRemove.UseVisualStyleBackColor = true;
            // 
            // SundayAdd
            // 
            this.SundayAdd.Location = new System.Drawing.Point(7, 337);
            this.SundayAdd.Name = "SundayAdd";
            this.SundayAdd.Size = new System.Drawing.Size(75, 23);
            this.SundayAdd.TabIndex = 4;
            this.SundayAdd.Text = "Add";
            this.SundayAdd.UseVisualStyleBackColor = true;
            this.SundayAdd.Click += new System.EventHandler(this.SundayAdd_Click);
            // 
            // SundayList
            // 
            this.SundayList.FormattingEnabled = true;
            this.SundayList.ItemHeight = 16;
            this.SundayList.Location = new System.Drawing.Point(3, 4);
            this.SundayList.Name = "SundayList";
            this.SundayList.Size = new System.Drawing.Size(435, 324);
            this.SundayList.TabIndex = 3;
            // 
            // SundayInfo
            // 
            this.SundayInfo.Location = new System.Drawing.Point(444, 4);
            this.SundayInfo.Multiline = true;
            this.SundayInfo.Name = "SundayInfo";
            this.SundayInfo.Size = new System.Drawing.Size(295, 321);
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
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 430);
            this.Controls.Add(this.DaysTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calendar";
            this.Text = "Calendar";
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
        private System.Windows.Forms.TextBox MondayInfo;
        private System.Windows.Forms.Button MondayRemove;
        private System.Windows.Forms.Button MondayAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button MondayEdit;
        private System.Windows.Forms.ToolStripMenuItem timeZoneToolStripMenuItem;
        private System.Windows.Forms.TextBox TuesdayInfo;
        private System.Windows.Forms.ListBox TuesdayList;
        private System.Windows.Forms.Button TuesdayEdit;
        private System.Windows.Forms.Button TuesdayRemove;
        private System.Windows.Forms.Button TuesdayAdd;
        private System.Windows.Forms.Button WednesdayEdit;
        private System.Windows.Forms.Button WednesdayRemove;
        private System.Windows.Forms.Button WednesdayAdd;
        private System.Windows.Forms.TextBox WednesdayInfo;
        private System.Windows.Forms.ListBox WednesdayList;
        private System.Windows.Forms.ListBox ThursdayList;
        private System.Windows.Forms.Button ThursdayEdit;
        private System.Windows.Forms.Button ThursdayRemove;
        private System.Windows.Forms.Button ThursdayAdd;
        private System.Windows.Forms.TextBox ThursdayInfo;
        private System.Windows.Forms.Button FridayEdit;
        private System.Windows.Forms.Button FridayRemove;
        private System.Windows.Forms.Button FridayAdd;
        private System.Windows.Forms.TextBox FridayInfo;
        private System.Windows.Forms.ListBox FridayList;
        private System.Windows.Forms.Button SaturdayEdit;
        private System.Windows.Forms.Button SaturdayRemove;
        private System.Windows.Forms.Button SaturdayAdd;
        private System.Windows.Forms.TextBox SaturdayInfo;
        private System.Windows.Forms.ListBox SaturdayList;
        private System.Windows.Forms.Button SundayEdit;
        private System.Windows.Forms.Button SundayRemove;
        private System.Windows.Forms.Button SundayAdd;
        private System.Windows.Forms.ListBox SundayList;
        private System.Windows.Forms.TextBox SundayInfo;
    }
}

