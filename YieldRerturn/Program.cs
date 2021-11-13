using System;
using System.Collections.Generic;

namespace YieldRerturn
{
    internal class Program
    {
        private static List<int> myList = new List<int>();
        static void FillValues()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
        }
        static void Main(string[] args)
        {
            FillValues();

            foreach (var i in Filter())
            {
                Console.WriteLine(i);
            }


            foreach (var i in YieldFilter())
            {
                Console.WriteLine(i);
            }

            foreach(var i in RunningTotal())
            {
                Console.WriteLine(i);
            }
  
            Console.Read();
        }

        static List<int> Filter()
        {
            var temp = new List<int>();
            foreach (var i in myList)
            {
                if (i > 3)
                {
                    temp.Add(i);
                }
            }
            return temp;
        }
        static IEnumerable<int> YieldFilter()
        {
            foreach (var i in myList)
            {
                if (i > 3)
                {
                    yield return i;
                }
            }
        }
        static IEnumerable<int> RunningTotal()
        {
            int runningtotal = 0;
            foreach (var i in myList)
            {
                runningtotal += i;
                yield return (runningtotal);
            }
        }
    }
}
