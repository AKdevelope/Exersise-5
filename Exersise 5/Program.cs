using System;

namespace Exersise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 5, Author: Nathan Trombley, version: 1.0.0");
            Console.WriteLine("This Program will read a file, a .txt text file, of your choice and then display how many words are in it.");
            var userinput = new Userinput();
            userinput.Checkinput(Console.Readline());
            Console.WriteLine(userinput.Checkinput);

        }
    }
}
