using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            int output;

            int ak(int n, int m)
            {
                if(n == 0) // Условие при значении первого числа "0" метод возвращает второе число + 1
                {
                    return m + 1; // При значении первой переменной "0", ко второму значению прибавляется "1"
                }
                else if((n > 0) && (m == 0)) // При значении первой переменной больше "0", а значение второй переменной равной "0", метод возвращает разницу первой переменной и "1", вызывая себя заново с новыми значениями
                {                            
                   return ak(n - 1, 1); // Значения принимаемые при выполнении данного условия
                }
                else // Условие, при котором обе переменные больше "0"
                {
                    return ak(n - 1, ak(n, m - 1)); // При выполнении данного условия метод вызывает сам себя до тех пор пока первое значение ak(n - 1, ...) не принимает "0", а значение ak(n, m - 1) не принимает значение целого числа.
                                                    // В результате, при проверке условий метода, отрабатывает первое условие. 
                }
            }
           
            output = ak(a, b);

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
