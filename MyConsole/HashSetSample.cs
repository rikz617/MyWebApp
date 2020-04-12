using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyConsole
{
    public class HashSetSample
    {
        public void SampleMethod() {


            var h = new HashSet<int>();
            
            IEnumerable<int> test = new HashSet<int>();
            
            int counter = test.Count();

            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();
            List<int> lists =  oddNumbers.ToList<int>();
            

            HashSet<string> stringSet = new HashSet<string> { "a", "b", "c" };
            // LINQ's ToList extension method
            List<string> stringList1 = stringSet.ToList();
            int[] marks = new int[2];
            evenNumbers.Add(1);
            evenNumbers.Add(2);
            evenNumbers.Add(1);
            

            // duplicates will return false and will not insert
            string s = evenNumbers.Add(1).ToString(); 
            
            for (int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);

                // Populate oddNumbers with just odd numbers.
                oddNumbers.Add((i * 2) + 1);
            }
        }
    }
}
