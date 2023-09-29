// CS 3160
// Spring 2021
// Nicholas Walker

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Event
    {
        private readonly DateTime startTime, endTime;
        private readonly String eventTitle;

        public Event(int m, int d, int y, int sH, int sM, int eH, int eM, String eT)
        {

            startTime = new DateTime(y, m, d, sH, sM, 00);

            // if end time is after start time
            if (sH < eH)
                endTime = new DateTime(y, m, d, eH, eM, 00);
            else if (sH == eH)
            {
                if (sM < eM)
                {
                    endTime = new DateTime(y, m, d, eH, eM, 00);
                }
            }
            else
                throw new ApplicationException("Event Start time cannot be before End time");

            // event title
            if (eT != "")
                eventTitle = eT;
            else
                throw new ApplicationException("Event Title cannot be empty");
        }

        public DateTime StartTime { get { return startTime; } }
        public DateTime EndTime { get { return endTime; } }
        public String EventTitle { get { return eventTitle; } }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Event anotherEvent;

            if ((obj == null) || !(obj is Event))
                return false;

            anotherEvent = (Event) obj;
            return anotherEvent.StartTime == this.StartTime;
        }

        public override string ToString()
        {
            return $"{startTime.Year}-{startTime.Month}-{startTime.Day}      {startTime.Hour}:" + startTime.ToString("%m");
        }

    }
}
