namespace RogersReminders
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.ReminderType = new System.Windows.Forms.ComboBox();
            this.ClearSelected = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReminderInput = new System.Windows.Forms.RichTextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Title = new System.Windows.Forms.TextBox();
            this.ReminderList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roger\'s Reminders";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Submit.Location = new System.Drawing.Point(37, 693);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 31);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Add";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ReminderType
            // 
            this.ReminderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReminderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ReminderType.FormattingEnabled = true;
            this.ReminderType.Items.AddRange(new object[] {
            "Reminder",
            "Birthday"});
            this.ReminderType.Location = new System.Drawing.Point(44, 217);
            this.ReminderType.Name = "ReminderType";
            this.ReminderType.Size = new System.Drawing.Size(134, 26);
            this.ReminderType.TabIndex = 6;
            // 
            // ClearSelected
            // 
            this.ClearSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ClearSelected.Location = new System.Drawing.Point(474, 652);
            this.ClearSelected.Name = "ClearSelected";
            this.ClearSelected.Size = new System.Drawing.Size(87, 31);
            this.ClearSelected.TabIndex = 7;
            this.ClearSelected.Text = "Clear selected";
            this.ClearSelected.UseVisualStyleBackColor = true;
            this.ClearSelected.Click += new System.EventHandler(this.ClearSelected_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ClearAll.Location = new System.Drawing.Point(474, 693);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(87, 31);
            this.ClearAll.TabIndex = 8;
            this.ClearAll.Text = "Clear all";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(37, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(40, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reminder type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(37, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(37, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Completed by:";
            // 
            // ReminderInput
            // 
            this.ReminderInput.Location = new System.Drawing.Point(37, 310);
            this.ReminderInput.Name = "ReminderInput";
            this.ReminderInput.Size = new System.Drawing.Size(492, 248);
            this.ReminderInput.TabIndex = 19;
            this.ReminderInput.Text = "";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(44, 623);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(215, 20);
            this.DatePicker.TabIndex = 21;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(43, 137);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(134, 20);
            this.Title.TabIndex = 22;
            // 
            // ReminderList
            // 
            this.ReminderList.CheckOnClick = true;
            this.ReminderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReminderList.FormattingEnabled = true;
            this.ReminderList.Location = new System.Drawing.Point(576, 112);
            this.ReminderList.Name = "ReminderList";
            this.ReminderList.Size = new System.Drawing.Size(488, 613);
            this.ReminderList.TabIndex = 23;
            this.ReminderList.SelectedIndexChanged += new System.EventHandler(this.ReminderList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 737);
            this.Controls.Add(this.ReminderList);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ReminderInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.ClearSelected);
            this.Controls.Add(this.ReminderType);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox ReminderType;
        private System.Windows.Forms.Button ClearSelected;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ReminderInput;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.CheckedListBox ReminderList;
    }
}

