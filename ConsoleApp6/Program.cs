using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is:");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the firs algorithm designed for processing by an Analytical Engine "));
        }
        public  MyFunctionA(string input)

        {
            string[] words = input.Split('');

            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];
        }
        }
    }
}
