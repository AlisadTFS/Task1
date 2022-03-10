using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        //enum months
        //{
        //    январь,
        //    февраль,
        //    март,
        //    апрель,
        //    май,
        //    июнь,
        //    июль,
        //    август,
        //    сентябрь,
        //    октябрь,
        //    ноябрь,
        //    декабрь
        //}
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру: ");
            int tmin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную температуру: ");
            int tmax = Convert.ToInt32(Console.ReadLine());
            int tmiddle = (tmax + tmin) / 2;
            Console.WriteLine($"Среднесуточная температура: {tmiddle}");

            Console.Write("Введите порядковый номер месяца: ");           
            byte numbmonth = Convert.ToByte(Console.ReadLine());
            switch (numbmonth)
            {
                case 1: 
                    Console.WriteLine("Январь");
                    if (tmiddle > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 2: 
                    Console.WriteLine("Февраль");
                    if (tmiddle > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case 3: 
                    Console.WriteLine("Март");
                    break;
                case 4: 
                    Console.WriteLine("Апрель");
                    break;
                case 5: 
                    Console.WriteLine("Май");
                    break;
                case 6: 
                    Console.WriteLine("Июнь");
                    break;
                case 7: 
                    Console.WriteLine("Июль");
                    break;
                case 8: 
                    Console.WriteLine("Август");
                    break;
                case 9: 
                    Console.WriteLine("Сентябрь");
                    break;
                case 10: 
                    Console.WriteLine("Октябрь");
                    break;
                case 11: 
                    Console.WriteLine("Ноябрь");
                    break;
                case 12: 
                    Console.WriteLine("Декабрь");
                    if (tmiddle > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                default:
                    Console.WriteLine("Не верно указан номер месяца");
                    break;
            }
        }    
    }
}
