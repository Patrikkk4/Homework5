using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{"Приложение найдет самые длинные слова в веденном вами предложении.\n", 90}" + 
                $"{"Знаки препинания, пробелы и знаки арифметических действий учитываться не будут.\n", 97}" + 
                $"{"Однако, если в слове будет присутствовать цифра, то она будет учитываться\n", 93}");

            Console.WriteLine("Введите предложение и нажимите Enter.");
            Console.WriteLine();

            string words = Console.ReadLine(); // Переменная, в которую будет записано предложение
            Console.WriteLine();

            char[] cutString = new char[] { '.', ',', '-', ' ', ':', '!', '?', '+' }; // Массив со знаками препинания, которые будут удалены из предложения
                      
            int LengthMax = 0; // Переменная с максимальной длинной слова

            void wordLeight(string word) // Метод выделяющий самые длинные слова в предложении
            {
                string[] wordMas = word.Split(cutString); // Создание массива со словами из введенного предложения и удаление знаков препинания 

                //Array.Resize(ref temp, wordMas.Length); // 
                string[] temp = new string[wordMas.Length];  // Временный массив с самыми длинными словами для вывода слов в консоль

                for (int i = 0; i < wordMas.Length; i++) // Цикл поиска наибольшего количества символов в словах из массива wordMas
                {                  
                    if (wordMas[i].Length > LengthMax) // Условие присвоения переменной LengthMax значения наибольшего количества символов
                    {                     
                        LengthMax = wordMas[i].Length; // присвоение переменной LengthMax значения наибольшего количества символов                     
                    }
                }

                for(int i = 0; i < wordMas.Length; i++) // Цикл заполнения временного массива
                {
                    if(wordMas[i].Length == LengthMax) // Условие заполнения временного массива
                    {
                        temp[i] = wordMas[i];  // Условие заполнения временного массива
                    }
                }

                Console.Write("Самые длинные слова: ");

                for (int i = 0; i < temp.GetLength(0); i++) // Цикл вывода временного массива в консоль
                {
                    if (temp[i] == temp.Last()) // Условие при котором не ствится запятая после слова
                    {
                        Console.Write(temp[i] + "\n"); // Вывод последнего слова в массиве
                    }

                    else if (temp[i] != null && temp[i] != temp.Last()) // Условие при котором ставится запятая после слова если оно не последнее в массиве
                    {  
                        Console.Write(temp[i] + ", "); // Вывод слова в консоль
                    }
                }
            }

            wordLeight(words); // Вызов метода поиска самых длинных слов в предложении

            Console.WriteLine("\nНажмите любую кнопку для выхода.");

            Console.ReadKey();
        }
    }
}
