using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{"Приложение найдет одинаковые символы в веденном вами предложении если они расположены рядом друг с другом.\n",113}" +
                $"{"Числа будут учитываться как текст, однако если одинаковые числа будут находится рядом друг с другом,\n", 110}" + 
                $"{"то приложение удалит повтор. Пробелы учитываются как символ.\n",90}");

            Console.WriteLine("Введите предложение.\n");

            string input = Console.ReadLine(); // Ввод предложения в переменную
            string output = string.Empty; // Создание пустой переменной вывода с результатом

            string FindRepeat(string temp) // Метод поиска одинаковых символов
            {               
                for (int i = 1; i < temp.Length; i++) // Цикл удаления одинаковых символов. Начало цыкла с индекса "1", т.к. первый символ не может быть повтором
                {
                    if (temp[i] != temp[i - 1]) // Условие сравнения предыдущего символа с текущим
                    {
                        output += temp[i]; // Заполнение переменной вывода результата
                    }
                }
                return output; // Возврат заполнения переменной вывода результата
            }

            FindRepeat(input); // Вызов метода поиска одинаковых символов

            Console.WriteLine(input.First() + output); // Вывод первого символа и результата в консоль. Необходимость вызова первого симаола вызвано тем, что цикл начинается с индекса "1"
            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
