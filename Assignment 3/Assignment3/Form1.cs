// CS 3160
// Spring 2021
// Nicholas Walker

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            EventForm.EventList = this.lstEvents;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex != -1)
            {
                // remove selected item
                lstEvents.Items.Remove(lstEvents.SelectedItem);

                // clear txt boxes
                txtEventDetail.Text = "";
                txtDate.Text = "";
                txtDay.Text = "";
                txtTime.Text = "";

                btnDelete.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                EventForm newEventForm = new EventForm();

                if (newEventForm.ShowDialog() == DialogResult.OK)
                {
                    // get event from form
                    Event newEvent = newEventForm.NewEvent;

                    // add event to list box
                    lstEvents.Items.Add(newEvent);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex != -1)
            {
                // enable delete button
                btnDelete.Enabled = true;

                // get event from list
                Event selectedEvent = lstEvents.SelectedItem as Event;

                // display event info
                txtEventDetail.Text = selectedEvent.EventTitle;
                txtDay.Text = $"{selectedEvent.StartTime.DayOfWeek}";
                txtDate.Text = $"{selectedEvent.StartTime.ToShortDateString()}";
                txtTime.Text = $"{selectedEvent.StartTime.ToShortTimeString()}:{selectedEvent.EndTime.ToShortTimeString()}";

            }
        }
    }
}
