using System;
using System.Text;

namespace LetterLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Letter Loop");
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char output = input[i];
                int inputCounter = -1;
                do
                {
                    Console.WriteLine(output);
                    inputCounter++;
                }
                while (inputCounter < i);
            }
        }
    }
}
