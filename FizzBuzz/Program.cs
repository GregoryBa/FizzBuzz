using System;

namespace FizzBuzz {
    class Program {
        private const int MAXLENGTH = 100;

        static void Main(string[] args) {
            string result = "";
            for (int i = 1; i <= MAXLENGTH; i++)
            {
                if (i % 3 == 0) { result += "Fizz"; }
                if (i % 5 == 0) { result += "Buzz"; }
                if (i % 3 != 0 && i % 5 != 0) { result += i.ToString(); }
                result += "\n";
            }
            Console.WriteLine(result);
        }  
    }
}
