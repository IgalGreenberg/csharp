using System;
using System.Collections.Generic;

namespace fib {
    class Program {
        static Dictionary<Int64, Int64> store = new Dictionary<Int64, Int64>();
        static Int64 Fib (Int64 num) {
            if (num < 2) return num;
            if (store.ContainsKey(num)) return store[num];
            Int64 result = Fib (num - 1) + Fib (num - 2);
            store.Add (num, result);
            return result;
        }
        static void Main (string[] args) {
            Console.WriteLine (Fib (0));
            Console.WriteLine (Fib (1));
            Console.WriteLine (Fib (2));
            Console.WriteLine (Fib (3));
            Console.WriteLine (Fib (4));
            Console.WriteLine (Fib (5));
            Console.WriteLine (Fib (1000));
        }
    }
}
