using System;

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
                var output = input[i].ToString();
                //var newOutput = output.ToString();
                Console.WriteLine(output);
            }
        }
    }
}
