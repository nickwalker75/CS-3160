using System;
using SetNS;

namespace MainApp
{
    public class App
    {
        public static void Main(string[] args)
        {
            // Create set A
            Console.WriteLine("// create A by passing an array of integers to overloaded constructor");
            int[] myarr = new int[5];
            for (int i = 0; i < 5; i++)
                myarr[i] = i;
            myarr[0] = 99;
            IntegerSet A = new IntegerSet(myarr);
            Console.WriteLine("A is: " + A);

            // Create set B
            Console.WriteLine("// create B by adding one element at a time");
            IntegerSet B = new IntegerSet();
            B.InsertElement(31);
            B.InsertElement(42);
            B.InsertElement(11);
            B.InsertElement(21);
            B.InsertElement(29);
            Console.WriteLine($"B is: {B}");

            // Intesection of A and B

            // Union of A and B

            // Copy A to B

            // Is A equal to B
            if(A == B) {Console.WriteLine("Set A is equal to set B");}
            else {Console.WriteLine("Set A is not equal to set B");}

            // Insert 35 to A
            Console.WriteLine("Insert 35 into A");
            A.InsertElement(35);
            Console.WriteLine($"Set A is now: {A}");

            // Delete 35 from A
            Console.WriteLine("Delete into set C");
            A.DeleteElement(35);
            Console.WriteLine($"Set A is now: {A}");

            // Couldn't get to run without error
            // Enter Elements into C
            // Console.WriteLine("// Enter elements into set C");
            // IntegerSet C = new IntegerSet();
            // Console.WriteLine("Enter set C:");
            // C.InputSet();
            // Console.WriteLine($"Set C is: {C}");

            // Empty set C
            Console.WriteLine("Emptying set C...");
            C.EmptySet();
            Console.WriteLine($"Set C is now: {C}");
            
        }//Main
    }//App
}//Mainapp