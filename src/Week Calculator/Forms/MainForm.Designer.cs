namespace WeekCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWeeks = new System.Windows.Forms.Label();
            this.lblWeeksCount = new System.Windows.Forms.Label();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGeneralWeekToHourCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(105, 8);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(231, 20);
            this.dtpStart.TabIndex = 2;
            this.dtpStart.ValueChanged += new System.EventHandler(this.DtpStart_Changed);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(105, 34);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(231, 20);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.DtpEnd_Changed);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 14);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Beginn";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 40);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(32, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Ende";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(261, 136);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblWeeks
            // 
            this.lblWeeks.AutoSize = true;
            this.lblWeeks.Location = new System.Drawing.Point(12, 61);
            this.lblWeeks.Name = "lblWeeks";
            this.lblWeeks.Size = new System.Drawing.Size(48, 13);
            this.lblWeeks.TabIndex = 5;
            this.lblWeeks.Text = "Wochen";
            // 
            // lblWeeksCount
            // 
            this.lblWeeksCount.AutoSize = true;
            this.lblWeeksCount.Location = new System.Drawing.Point(102, 61);
            this.lblWeeksCount.Name = "lblWeeksCount";
            this.lblWeeksCount.Size = new System.Drawing.Size(29, 13);
            this.lblWeeksCount.TabIndex = 6;
            this.lblWeeksCount.Text = "sdsd";
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(12, 82);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(87, 13);
            this.lblHoursPerWeek.TabIndex = 7;
            this.lblHoursPerWeek.Text = "Stunden/Woche";
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(105, 80);
            this.nudHours.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(231, 20);
            this.nudHours.TabIndex = 4;
            this.nudHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHours.ValueChanged += new System.EventHandler(this.NudHours_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gesamt";
            // 
            // lblGeneralWeekToHourCount
            // 
            this.lblGeneralWeekToHourCount.AutoSize = true;
            this.lblGeneralWeekToHourCount.Location = new System.Drawing.Point(102, 108);
            this.lblGeneralWeekToHourCount.Name = "lblGeneralWeekToHourCount";
            this.lblGeneralWeekToHourCount.Size = new System.Drawing.Size(29, 13);
            this.lblGeneralWeekToHourCount.TabIndex = 10;
            this.lblGeneralWeekToHourCount.Text = "sdsd";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 165);
            this.Controls.Add(this.lblGeneralWeekToHourCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.lblHoursPerWeek);
            this.Controls.Add(this.lblWeeksCount);
            this.Controls.Add(this.lblWeeks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stundenrechner";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWeeks;
        private System.Windows.Forms.Label lblWeeksCount;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGeneralWeekToHourCount;
    }
}

