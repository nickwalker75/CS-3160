using System;
namespace arrayEx
{
    public class Example1
    {
        static void Main()
        {
            string[] hamlet = {"to be", "or not", "to be"};
            printStrings(hamlet);
        }
        static void printStrings(string[] ary)
        {
            for(int i=0; i<ary.Length; i++)
                Console.WriteLine(ary[i]);
        }
    }//class
}//namespace