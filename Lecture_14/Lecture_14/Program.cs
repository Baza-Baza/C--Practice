using System;

namespace Lecture_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello, guys!!!!";
            var nameIndex = s1.IndexOf(',');
            s1 = s1.Remove(nameIndex, 10);
            Console.WriteLine(s1 + "...");
        }

        static void StringBuild() 
        {
            

        }
    }
}
