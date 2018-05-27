using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersReminders
{
    public partial class Form1 : Form
    {
        string file = @"C:\Users\Public\reminders\reminders.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] reminders = File.ReadAllLines(file);

            foreach (string reminder in reminders)
            {
                if(string.IsNullOrWhiteSpace(reminder))
                {

                } else
                {
                    ReminderList.Items.Add(reminder);
                }
            }

            ReminderType.SelectedIndex = 0;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bool loop = false;

            while(!loop)
            {
                if (string.IsNullOrWhiteSpace(ReminderType.Text))
                {
                    MessageBox.Show("You must select an item from the list");
                    return;
                }

                if (string.IsNullOrWhiteSpace(Title.Text))
                {
                    MessageBox.Show("You must give the reminder a title");
                    return;
                }

                if (string.IsNullOrWhiteSpace(ReminderInput.Text))
                {
                    MessageBox.Show("You must give a description of the reminder");
                    return;
                }
                loop = true;
            }

            string reminderType = ReminderType.Text;
            string title = Title.Text;
            string reminder = ReminderInput.Text;
            string dueDate = DatePicker.Text;
            string line = "";
            string path = @"C:\Users\Public\reminders";

            try
            {
                if(Directory.Exists(path))
                {
                } else
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

            } catch (SystemException)
            {
                MessageBox.Show("Something went wrong when creating the directory"); // about as useful as all other windows errors
            }

            if (reminderType == "Reminder")
            {
                var newReminder = new GenericReminder(title, reminder, dueDate);
                line = newReminder.title + ": " + newReminder.reminder + " - " + newReminder.completedBy + Environment.NewLine;
                ReminderList.Items.Add(line);

            }
            else if(reminderType == "Birthday")
            {
                var newReminder = new BirthdayReminder(title, reminder, dueDate);
                line = newReminder.title + ": " + newReminder.reminder + " - " + newReminder.birthday + Environment.NewLine;
                ReminderList.Items.Add(line);
            }

            try
            {
                File.AppendAllText(file, line);
            }
            catch (SystemException)
            {
                MessageBox.Show("Could not write to file");
            }
        }

        private void ClearSelected_Click(object sender, EventArgs e)
        {
            var remindersArr = File.ReadAllLines(file);
            File.Delete(file);

            var reminders = remindersArr.ToList();

            List<string> toRemove = new List<string>();

            foreach(object reminder in ReminderList.Items)
            {
                if(!ReminderList.CheckedItems.Contains(reminder))
                {
                    toRemove.Add(reminder.ToString());
                    File.AppendAllText(file, reminder.ToString() + Environment.NewLine);
                }
            }

            ReminderList.Items.Clear();

            string[] newReminderArr = File.ReadAllLines(file);

            foreach(string reminder in newReminderArr)
            {
                if (string.IsNullOrWhiteSpace(reminder))
                {

                } else
                {
                    ReminderList.Items.Add(reminder);
                }
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            File.Delete(file);
            ReminderList.Items.Clear();
        }

        private void ReminderList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }

    class Reminder
    {
        public string title;
        public string reminder;
    }

    class GenericReminder : Reminder
    {
        public string completedBy;

        public GenericReminder(string _title, string _reminder, string _completedBy)
        {
            this.title = _title;
            this.reminder = _reminder;
            completedBy = _completedBy;
        }
    }

    class BirthdayReminder : Reminder
    {
        public string birthday;

        public BirthdayReminder(string _title, string _reminder, string _birthday)
        {
            this.title = "Birthday: " + _title;
            this.reminder = _reminder;
            birthday = _birthday;
        }
    }
}