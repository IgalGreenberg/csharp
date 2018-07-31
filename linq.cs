using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1 {
    public class Program {
        static void Main () {
            IEnumerable<int> numbers = Enumerable.Range (0, 1000);
            var evens = from num in numbers where num % 2 == 0 select num;
            Console.WriteLine(evens.Sum());
        }
    }
}
