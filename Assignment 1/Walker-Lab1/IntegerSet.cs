using System;

namespace SetNS
{
    public class IntegerSet
    {
        // Instance variables
        private bool[] intSet = new bool[51];

        // Constructors
        public IntegerSet() {EmptySet();}

        public IntegerSet(int[] arr)
        {
            foreach (int ele in arr)
            {
                // if input is in range set value in intSet to true
                if (ele < 0 || ele > 50) {Console.WriteLine($"ERROR: {ele} is out of range");}
                // else write error message
                else {intSet[ele] = true;}
            }
        }

        // Override
        public override bool Equals(object obj)
        {
            IntegerSet tempIntSet;
            bool isArrayEqual = false;

            // id obj is null or not IntegerSet class !=
            if((obj == null) || !(obj is IntegerSet))
                return false;

            // cast obj in IntegerSet
            tempIntSet = (IntegerSet)obj;
            
            // if 1 elem in arr != to other then !=
            if (this.intSet[0] == tempIntSet.intSet[0])
            {
			    for (int i = 0; i < 50; i++)
                {
				    if (this.intSet[i] != tempIntSet.intSet[i]) {isArrayEqual = false;}
			    }
		    } 
            else {isArrayEqual = false;}

            return isArrayEqual;
        }

        public override int GetHashCode() {return 0;}

        public override string ToString()
        {
            string temp = "{";
            int cnt = 0;
            
            // for each ele check if T/F
            for (int ele=0; ele<50 ;ele++)
            {
                // if true add num to temp 
                if (intSet[ele] == true) {temp = temp + " " + ele.ToString();}
                // if false increment counter
                else{cnt += 1;}
            }
            temp = temp + " }";

            if (cnt == 50) {return "{ <empty> }";}
            else {return temp;}
        }

        // Methods
        public int EmptySet()
        {
            for (int ele=0; ele<50 ;ele++) {intSet[ele] = false;}
            return 0;
        }

        public int InsertFromArray(int[] arr)
        {
            foreach (int ele in arr)
            {
                // if input is in range set value in intSet to true
                if (ele >= 0 || ele <= 50) {intSet[ele] = true;}
                // else write error message
                else {Console.WriteLine($"ERROR: {arr[ele]} is out of range");}
            }
            return 0;
        }

        public int InsertElement(int input)
        {
            // if input is in range set value in intSet to true
            if (input >= 0 || input <= 50) {intSet[input] = true;}
            // else write error message
            else {Console.WriteLine($"ERROR: {input} is out of range");}
            return 0;
        }

        public int DeleteElement(int input)
        {
            // if input is in range set value in intSet to true
            if ((input >= 0 || input <= 50) && intSet[input] == true) {intSet[input] = false;}
            // else write error message
            else {Console.WriteLine($"ERROR: {input} is out of range");}
            return 0;
        }

        public int InputSet()
        {
            string input = "";

            do
            {
                // Get user input
                Console.Write("Enter an Element (Enter to end): ");
                input = Console.ReadLine();

                // if input is in range add to intSet
                if (Convert.ToInt32(input) >= 0 || Convert.ToInt32(input) <= 50) {intSet[Convert.ToInt32(input)] = true;}
                // else write error message
                else {Console.WriteLine("ERROR: "+ input + " is out of range");}
            } while (!(String.IsNullOrEmpty(input)));
            return 0;
        }

        // public int Union(){}

        // public int Intersection(){}


    }
}