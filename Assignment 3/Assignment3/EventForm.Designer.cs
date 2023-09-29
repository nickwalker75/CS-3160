
namespace Assignment3
{
    partial class EventForm
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
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.grpStartTime = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStartMin = new System.Windows.Forms.ComboBox();
            this.cboStartHour = new System.Windows.Forms.ComboBox();
            this.grpStopTime1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStopMin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStopHour = new System.Windows.Forms.ComboBox();
            this.lblEventDesc = new System.Windows.Forms.Label();
            this.txtEventDesc = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpStartTime.SuspendLayout();
            this.grpStopTime1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(18, 18);
            this.calender.MinDate = new System.DateTime(2021, 3, 13, 0, 0, 0, 0);
            this.calender.Name = "calender";
            this.calender.TabIndex = 0;
            // 
            // grpStartTime
            // 
            this.grpStartTime.Controls.Add(this.label5);
            this.grpStartTime.Controls.Add(this.label2);
            this.grpStartTime.Controls.Add(this.label1);
            this.grpStartTime.Controls.Add(this.cboStartMin);
            this.grpStartTime.Controls.Add(this.cboStartHour);
            this.grpStartTime.Location = new System.Drawing.Point(300, 18);
            this.grpStartTime.Name = "grpStartTime";
            this.grpStartTime.Size = new System.Drawing.Size(200, 76);
            this.grpStartTime.TabIndex = 1;
            this.grpStartTime.TabStop = false;
            this.grpStartTime.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hour";
            // 
            // cboStartMin
            // 
            this.cboStartMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartMin.FormattingEnabled = true;
            this.cboStartMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cboStartMin.Location = new System.Drawing.Point(112, 45);
            this.cboStartMin.Name = "cboStartMin";
            this.cboStartMin.Size = new System.Drawing.Size(82, 25);
            this.cboStartMin.TabIndex = 1;
            // 
            // cboStartHour
            // 
            this.cboStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartHour.FormattingEnabled = true;
            this.cboStartHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cboStartHour.Location = new System.Drawing.Point(6, 45);
            this.cboStartHour.Name = "cboStartHour";
            this.cboStartHour.Size = new System.Drawing.Size(86, 25);
            this.cboStartHour.TabIndex = 0;
            // 
            // grpStopTime1
            // 
            this.grpStopTime1.Controls.Add(this.label6);
            this.grpStopTime1.Controls.Add(this.label3);
            this.grpStopTime1.Controls.Add(this.cboStopMin);
            this.grpStopTime1.Controls.Add(this.label4);
            this.grpStopTime1.Controls.Add(this.cboStopHour);
            this.grpStopTime1.Location = new System.Drawing.Point(300, 104);
            this.grpStopTime1.Name = "grpStopTime1";
            this.grpStopTime1.Size = new System.Drawing.Size(200, 76);
            this.grpStopTime1.TabIndex = 2;
            this.grpStopTime1.TabStop = false;
            this.grpStopTime1.Text = "Stop Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minute";
            // 
            // cboStopMin
            // 
            this.cboStopMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopMin.FormattingEnabled = true;
            this.cboStopMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cboStopMin.Location = new System.Drawing.Point(112, 45);
            this.cboStopMin.Name = "cboStopMin";
            this.cboStopMin.Size = new System.Drawing.Size(82, 25);
            this.cboStopMin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hour";
            // 
            // cboStopHour
            // 
            this.cboStopHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStopHour.FormattingEnabled = true;
            this.cboStopHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cboStopHour.Location = new System.Drawing.Point(6, 45);
            this.cboStopHour.Name = "cboStopHour";
            this.cboStopHour.Size = new System.Drawing.Size(86, 25);
            this.cboStopHour.TabIndex = 2;
            // 
            // lblEventDesc
            // 
            this.lblEventDesc.AutoSize = true;
            this.lblEventDesc.Location = new System.Drawing.Point(18, 193);
            this.lblEventDesc.Name = "lblEventDesc";
            this.lblEventDesc.Size = new System.Drawing.Size(144, 17);
            this.lblEventDesc.TabIndex = 3;
            this.lblEventDesc.Text = "Event Description";
            // 
            // txtEventDesc
            // 
            this.txtEventDesc.Location = new System.Drawing.Point(18, 214);
            this.txtEventDesc.Name = "txtEventDesc";
            this.txtEventDesc.Size = new System.Drawing.Size(482, 23);
            this.txtEventDesc.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(18, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(398, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EventForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(516, 297);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEventDesc);
            this.Controls.Add(this.lblEventDesc);
            this.Controls.Add(this.grpStopTime1);
            this.Controls.Add(this.grpStartTime);
            this.Controls.Add(this.calender);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.grpStartTime.ResumeLayout(false);
            this.grpStartTime.PerformLayout();
            this.grpStopTime1.ResumeLayout(false);
            this.grpStopTime1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.GroupBox grpStartTime;
        private System.Windows.Forms.GroupBox grpStopTime;
        private System.Windows.Forms.GroupBox grpStopTime1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStartMin;
        private System.Windows.Forms.ComboBox cboStartHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStopMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStopHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEventDesc;
        private System.Windows.Forms.TextBox txtEventDesc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
    }
}