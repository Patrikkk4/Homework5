using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._4_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{"Введите через пробел последовательность чисел. Приложение проверит вид прогрессии.\n",100}" +
                $"{"Недопускаются символы между числами и пробел в конце строки.\n",87}");

            Console.Write("Ваша последовательность: ");

            string[] numbers = Console.ReadLine().Split(); // Создание массива с числами в типе данных string для ввода всех чисел в одну строку

            int[] numbersMas = new int[numbers.Length]; // Создание массива для конвертации string в int   

            try
            {
                for (int i = 0; i < numbers.Length; i++) // Цикл конвертации string в int
                {
                    numbersMas[i] = int.Parse(numbers[i]); // массив принимает введенные числовые значения
                }
            }
            catch
            {
                Console.WriteLine("\nНедопустимые символы или пробел в конце строки.");
                Console.ReadKey();
                Environment.Exit(0);
            }


            void calculation()
            {
                int ArithmeticProgress = numbersMas[2] - numbersMas[1]; // расчет разницы арифметической прогрессии
                int GeometricProgress = numbersMas[2] / numbersMas[1];  // расчет знаменателя геометрической прогрессии

                int ArithmeticProgressTemp = 0; // Временная переменная для проверки арифметической прогрессии
                int GeometricProgressTemp = 0;  // Временная переменная для проверки геометрической прогрессии

                try // Попытка расчета значений временных переменных для проверки вида прогрессии 
                {
                    int tempA = numbersMas[3] - numbersMas[2]; // Расчет проверки арифметической прогресии
                    int tempG = numbersMas[3] / numbersMas[2]; // Расчет проверки геометрической прогресии
                    ArithmeticProgressTemp = tempA; // Присваивание значения переменной проверки арифметической прогрессии
                    GeometricProgressTemp = tempG;  // Присваивание значения переменной проверки геометрической прогрессии
                }
                catch // Действие при неудачной попытке
                {
                    Console.WriteLine("Вы ввели менее четырех чисел. Нажмите любую клавишу для выхода.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                for (int i = 2; i < numbersMas.Length; i++) // Цикл проверки последовательности прогрессии
                {
                    if (numbersMas[i] == numbersMas[i - 1] + ArithmeticProgress || numbersMas[i] == numbersMas[i - 1] * GeometricProgress) // Условие проверки последовательности чисел
                    {
                        continue; // Действие при удайной проверке последовательности чисел
                    }
                    else // Действие при нарушении последовательности чисел
                    {
                        Console.WriteLine("Последовательность нарушена. Нажмите любую клавишу для выхода.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }


                if (ArithmeticProgress == ArithmeticProgressTemp) // Условие, при котором приложение определяет арифметическую прогрессию
                {
                    Console.WriteLine("\nЭто арифметическая прогрессия");
                }
                else if (GeometricProgress == GeometricProgressTemp) // Условие, при котором приложение определяет геометрическую прогрессию
                {
                    Console.WriteLine("\nЭто геометрическая прогрессия");
                }

            }

            calculation(); // Вызов метода расчета вида прогрессии

            Console.ReadKey();
        }
    }
}
