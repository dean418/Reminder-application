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
        // variableto store the path f the file that the reminders will be stored in
        string file = @"C:\Users\Public\reminders\reminders.txt";
        // variable to store the value of the edit text box
        string reminderEdit;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // selectt the first item in the drop down 
            ReminderType.SelectedIndex = 0;
            // store each line of tthe reminders file as an index in an array
            string[] reminders = File.ReadAllLines(file);

            // iterate over the array
            foreach (string reminder in reminders)
            {
                if(string.IsNullOrWhiteSpace(reminder))
                {
                    // dont add the reminder if it doesn't contain a value
                } else
                {
                    // add the reminder to the list of reminders
                    ReminderList.Items.Add(reminder);
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //check each input ad ensure that they have a value
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

            //varibles to store the values of the input boxes and dropdown
            string reminderType = ReminderType.Text;
            string title = Title.Text;
            string reminder = ReminderInput.Text;
            string dueDate = DatePicker.Text;
            //variable to store the reminder to add to a file that is out of the scope of where it is written to a file
            string line = "";

            try // try to create the directory where the reminder text file will e stored
            {
                if(Directory.Exists(@"C:\Users\Public\reminders"))
                {
                    // if the directory already exists, move on
                } else
                {
                    //create the directory
                    DirectoryInfo di = Directory.CreateDirectory(@"C:\Users\Public\reminders");
                }

            } catch (SystemException)
            {
                // if there was an error while creating the directory show a message box
                MessageBox.Show("Something went wrong when creating the directory");
            }

            if (reminderType == "Reminder")
            {
                //create an new instance of te class "GenericReminder"
                var newReminder = new GenericReminder(title, reminder, dueDate);
                // create the reminder that will be added to the text file and the list where the reminders will be stored
                line = newReminder.title + ": " + newReminder.reminder + " - " + newReminder.completedBy + Environment.NewLine;
                // add the reminder to the list
                ReminderList.Items.Add(line);

            }else if(reminderType == "Birthday")
            {
                //create an new instance of te class "BirthdayReminder"
                var newReminder = new BirthdayReminder(title, reminder, dueDate);
                // create the reminder that will be added to the text file and the list where the reminders will be stored
                line = newReminder.title + ": " + newReminder.reminder + " - " + newReminder.birthday + Environment.NewLine;
                // add the reminder to the list
                ReminderList.Items.Add(line);
            }

            try
            {
                // try to add the reminder to the text file
                File.AppendAllText(file, line);
            }
            catch (SystemException)
            {
                // if there was an error 
                MessageBox.Show("Could not write to file");
            }

            // reset the input boxes for the title and reminder description
            Title.Text = "";
            ReminderInput.Text = "";
        }

        private void ClearSelected_Click(object sender, EventArgs e)
        {
            // create an array with each line of the reminders file as an array index
            string[] remindersArr = File.ReadAllLines(file);
            // delete the file because remaining reminders will be appended to the file and not overwritten
            File.Delete(file);


            // create a list that will contain reminders to keep
            List<string> toKeep = new List<string>();

            foreach(object reminder in ReminderList.Items)
            {
                // if the reminder in the reminders list isn't checked
                if(!ReminderList.CheckedItems.Contains(reminder))
                {
                    // add it to the list of reminders to keep
                    toKeep.Add(reminder.ToString());
                    // create te file if it doesnt exist and append the reminder to it
                    File.AppendAllText(file, reminder.ToString() + Environment.NewLine);
                }
            }

            //clear all items in the list
            ReminderList.Items.Clear();

            if (toKeep.Count == 0)
            {
                //if there are no reminders to keep, do nothing
                return;
            } else
            {
                // get each line in the reminders file and add it to an index in the array
                string[] newReminderArr = File.ReadAllLines(file);

                foreach (string reminder in newReminderArr)
                {
                    //if the reminder in the array isn't empty add it to the 
                    if (string.IsNullOrWhiteSpace(reminder))
                    {

                    }
                    else
                    {
                        ReminderList.Items.Add(reminder);
                    }
                }
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            // if the reminder list doesnt have any reminders do nothing
            if(ReminderList.Items.Count == 0)
            {
                return;
            }

            //show a dialog box with the options "Yes" and "No"
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all reminders?", "Delete all", MessageBoxButtons.YesNo);

            //if the user clicks the "Yes" option
            if (dialogResult == DialogResult.Yes)
            {
                //delete the file
                File.Delete(file);
                // clear the reminder list
                ReminderList.Items.Clear();
            } else if (dialogResult == DialogResult.No)
            {
                return;
            } 
        }

        private void EditSelected_Click(object sender, EventArgs e)
        {
            // get the total number of checked items and store it as a varibale
            int checkedCounter = ReminderList.CheckedItems.Count;

            //alert the user that they have to select a reminder to edit it
            if (ReminderList.SelectedIndex < 0)
            {
                MessageBox.Show("You must have an item selected before you can edit it");
                return;
            } else if(checkedCounter > 1)
            {
                // alert the user that they can't edit more than 1 reminder at a time
                MessageBox.Show("You can only edit one reminder at a time");
                return;
            }

            // get the selected reminder and store it as a variable
            string currentVal = ReminderList.Items[ReminderList.SelectedIndex].ToString();
            // add the selected reminder to the edit box;
            EditInput.Text = currentVal;
            //set the selected reminder as the "reminderEdit" variable
            reminderEdit = currentVal;
        }

        private void AddEdited_Click(object sender, EventArgs e)
        {
            // check if the edit box is empty
            if (String.IsNullOrWhiteSpace(EditInput.Text))
            {
                // alert the user that the edit box must contain a value
                MessageBox.Show("The edited reminder must contain a value");
                return;
            }

            // remove the selected reminder from the reminder list
            ReminderList.Items.Remove(reminderEdit);
            // add the edited reminder to the reminder list
            ReminderList.Items.Add(EditInput.Text);
            // remove the contents of the edit box
            EditInput.Text = "";
        }
    }

    class Reminder
    {
        // variables that are shared across all types of reminder
        public string title;
        public string reminder;
    }

    // inherit the variables from the base reminder class
    class GenericReminder : Reminder
    {
        // create a variable unique to this class
        public string completedBy;

        public GenericReminder(string _title, string _reminder, string _completedBy)
        {
            //set the values of the variables to the users input
            this.title = _title;
            this.reminder = _reminder;
            completedBy = _completedBy;
        }
    }

    // class that adds "Birthday" to the start of the title as a form of tag for the reminder
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