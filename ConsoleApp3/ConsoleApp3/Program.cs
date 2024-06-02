using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//Создайте приложение для подсчета количества вхождений
//подстроки в строку. Пользователь вводит исходную строку и
//слово для поиска. Приложение отображает результат поиска.
//Например:
//пользователь ввел: Why she had to go. I don't know, she
//wouldn't say;
//подстрока для поиска: she;
//результат поиска: 2.

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходную строку: ");
            string sentence = Console.ReadLine().Trim(); 

            Console.WriteLine("Введите подстроку для поиска:");
            string searchWord = Console.ReadLine().Trim(); 

            int count = 0;
            for (int i = 0; i <= sentence.Length - searchWord.Length; i++) 
            {
                bool found = true;
                for (int j = 0; j < searchWord.Length; j++)
                {
                    if (sentence[i + j] != searchWord[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    count++;
                }
            }

            Console.WriteLine($"Результат поиска: {count}.");

            Console.ReadKey();
        }
    }
}
