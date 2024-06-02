using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Пользователь вводит предложение с клавиатуры. Вам необходимо перевернуть каждое слово предложения и вывести результат
//на экране.
//Например:
//пользователь ввел: sun cat dogs dogs cup tea;
//после переворота: nus tac sgod puc aet.

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reversedWord = "";

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedWord += word[j];
                }

                result += reversedWord;

                if (i < words.Length - 1)
                {
                    result += " ";
                }
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }

    }
}
