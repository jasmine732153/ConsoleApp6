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
            int x = 0;

            foreach( var word in words){ }
            string currentword = words[0];
            string nextword;
            string longestWord = currentword;
            for (int y = 0;y<words.Length-1;y++)
            {
                currentword = words[y];
                nextword = words[y + 1];
            }
        }
        }
    }
}
