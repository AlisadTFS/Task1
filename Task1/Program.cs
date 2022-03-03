using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру: ");
            int tmin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную температуру: ");
            int tmax = Convert.ToInt32(Console.ReadLine());
            int middle = (tmax + tmin) / 2;
            Console.WriteLine($"Среднесуточная температура: {middle}");
        }    
    }
}
