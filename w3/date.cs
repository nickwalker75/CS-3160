using System;

namespace Date
{
    class MyDate
    {
        // Instance variables
        private int month, day, year;

        // Constructor
        public MyDate(int a, int b, int c)
        {
            this.month = a;
            this.day = b;
            this.year = c;
        }

        // Modifiers
        public int month
        {
            get { return this.month;}
            set { this.month = value;}
        }
        
        public int day
        {
            get { return this.day;}
            set { this.day = value;}
        }

        public int year {get; set;}

        // Methods
        public DisplayDate()
        {
            Console.WriteLine(this);
        }


    }//MyDate
}//namespace