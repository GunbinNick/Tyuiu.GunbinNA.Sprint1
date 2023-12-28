using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint1.Task3.V1.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гунбин Н. А | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Операторы составного присваивания                                  *");
            Console.WriteLine("*Задание #1.3                                                             *");
            Console.WriteLine("*Вариант #1                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("*выполняет указанные расчеты и печатает результат на экране. Вычислить    *");
            Console.WriteLine("*площадь цилиндра при r = 4 и h = 7. Значение пи принять равным 3,141     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double r, h;

            Console.WriteLine("Введите значение R:");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение H:");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CylinderVolume(r, h));
            Console.ReadKey();
        }
    }
}
