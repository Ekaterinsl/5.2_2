using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_2
{
    internal class Program
    {
        static string DivideWord(string s)
        {
            string[] subs = s.Split(' ');
            string newString = ReversWords(subs);
            return newString;
        }
        static string ReversWords(string[] inputPhrase) // 
        {
            Array.Reverse(inputPhrase);
            string s = string.Join(" ", inputPhrase);
            return s;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите предложение: ");

            string text = Console.ReadLine();

            text = DivideWord(text);


            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
