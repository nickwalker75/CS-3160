using System;
namespace arrayEx
{
    public class Example1
    {
        static void Main()
        {
            printStrings(hamlet);
        }
        static void makeArray()
        {
            string[] hamlet = {};
        }
        static void printStrings(string[] ary)
        {
            for(int i=0; i<ary.Length; i++)
                Console.WriteLine(ary[i]);
        }
    }//class
}//namespace