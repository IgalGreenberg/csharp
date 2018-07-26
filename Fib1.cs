using System;

namespace fib {
    class Program {
        static Int64 Fib (Int64 num) {
            if (num < 2) return num;
            //tail recursion
            return Fib (num - 1) + Fib (num - 2);
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
