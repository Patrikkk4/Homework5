using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{"Введите через пробел последовательность чисел. Приложение проверит вид прогрессии.\n", 100}" +
                $"{"Недопускаются символы между числами и пробел в конце строки.\n", 87}");

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


            bool calculation(int[] masNumber) // Метод определения вида прогрессии
            {
                int ArithmeticProgress = masNumber[2] - masNumber[1]; // расчет разницы арифметической прогрессии
                int GeometricProgress = masNumber[2] / masNumber[1];  // расчет знаменателя геометрической прогрессии

                int ArithmeticProgressTemp = 0; // Временная переменная для проверки арифметической прогрессии
                int GeometricProgressTemp = 0;  // Временная переменная для проверки геометрической прогрессии

                try // Попытка расчета значений временных переменных для проверки вида прогрессии 
                {
                    int tempA = masNumber[3] - masNumber[2]; // Расчет проверки арифметической прогресии
                    int tempG = masNumber[3] / masNumber[2]; // Расчет проверки геометрической прогресии
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
                        if (numbersMas[i] == masNumber[i - 1] + ArithmeticProgress || masNumber[i] == numbersMas[i - 1] * GeometricProgress) // Условие проверки последовательности чисел
                        {
                            continue; // Действие при удайной проверке последовательности чисел
                        }
                        else // Действие при нарушении последовательности чисел
                        {
                            Console.WriteLine("\nПоследовательность нарушена. Нажмите любую клавишу для выхода.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }


                if(ArithmeticProgress == ArithmeticProgressTemp) // Условие возврата значения для определения арифметической прогрессии
                {
                    return true;
                }
                else if(GeometricProgress == GeometricProgressTemp) // Условие возврата значения для определения геометрической прогрессии
                {
                    return false;
                }
                return true; // Тут возникает вопрос: если я не пропишу return в конце кода метода, то Visual studio предупредит меня о том, что не все ветви кода возвращают значение. Как избежать этой команды в данном случае? Ведь, по сути, она бесполезная здесь.  
            }

            calculation(numbersMas); // Вызов метода расчета вида прогрессии

            if(calculation(numbersMas) == true) // Условие, при котором приложение определяет арифметическую прогрессию
            {
                Console.WriteLine("\nЭто арифметическая прогрессия");
            }
            else if (calculation(numbersMas) == false) // Условие, при котором приложение определяет геометрическую прогрессию
            {
                Console.WriteLine("\nЭто геометрическая прогрессия");
            }

            Console.ReadKey();
        }
    }
}
