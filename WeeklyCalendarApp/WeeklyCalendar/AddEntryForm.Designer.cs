namespace WeeklyCalendar
{
    partial class AddEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEntryForm));
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DayBox = new System.Windows.Forms.TextBox();
            this.HourNum = new System.Windows.Forms.NumericUpDown();
            this.minuteNum = new System.Windows.Forms.NumericUpDown();
            this.AdditionalInfoBox = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HourNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(53, 27);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(323, 22);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Additional Info";
            // 
            // DayBox
            // 
            this.DayBox.Location = new System.Drawing.Point(53, 62);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(323, 22);
            this.DayBox.TabIndex = 5;
            // 
            // HourNum
            // 
            this.HourNum.Location = new System.Drawing.Point(58, 97);
            this.HourNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.HourNum.Name = "HourNum";
            this.HourNum.Size = new System.Drawing.Size(51, 22);
            this.HourNum.TabIndex = 6;
            // 
            // minuteNum
            // 
            this.minuteNum.Location = new System.Drawing.Point(116, 96);
            this.minuteNum.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minuteNum.Name = "minuteNum";
            this.minuteNum.Size = new System.Drawing.Size(51, 22);
            this.minuteNum.TabIndex = 7;
            // 
            // AdditionalInfoBox
            // 
            this.AdditionalInfoBox.Location = new System.Drawing.Point(12, 169);
            this.AdditionalInfoBox.Multiline = true;
            this.AdditionalInfoBox.Name = "AdditionalInfoBox";
            this.AdditionalInfoBox.Size = new System.Drawing.Size(361, 168);
            this.AdditionalInfoBox.TabIndex = 8;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmBtn.Location = new System.Drawing.Point(12, 343);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 9;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(94, 343);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 378);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.AdditionalInfoBox);
            this.Controls.Add(this.minuteNum);
            this.Controls.Add(this.HourNum);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEntryForm";
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.AddEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HourNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DayBox;
        private System.Windows.Forms.NumericUpDown HourNum;
        private System.Windows.Forms.NumericUpDown minuteNum;
        private System.Windows.Forms.TextBox AdditionalInfoBox;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}