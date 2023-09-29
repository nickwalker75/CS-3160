// CS 3160
// Spring 2021
// Nicholas Walker

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class EventForm : Form
    {
        static private ListBox eventList;
        private Event newEvent;
        
        static public ListBox EventList
        {
            get { return eventList; }
            set { eventList = value; }
        }

        public Event NewEvent => newEvent;

        public EventForm()
        {
            InitializeComponent();

            // set calender date range
            calender.MinDate = DateTime.Today;
            calender.MaxDate = new DateTime(DateTime.Today.Year, 12, 31).AddYears(1);

            // set default time
            cboStartHour.SelectedIndex = 7;
            cboStartMin.SelectedIndex = 0;

            cboStopHour.SelectedIndex = 16;
            cboStopMin.SelectedIndex = 0;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                newEvent = new Event(
                    calender.SelectionStart.Month, calender.SelectionStart.Day, calender.SelectionStart.Year,
                    Convert.ToInt32(cboStartHour.SelectedItem), Convert.ToInt32(cboStartMin.SelectedItem),
                    Convert.ToInt32(cboStopHour.SelectedItem),  Convert.ToInt32(cboStopMin.SelectedItem), txtEventDesc.Text);

                foreach (Event otherEvent in eventList.Items)
                {
                    if (otherEvent == newEvent)
                        throw new ApplicationException("Confilct with other Event");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newEvent = null;
            this.Close();
        }
    }
}
