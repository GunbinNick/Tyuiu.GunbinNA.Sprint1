using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint1.Task0.V22.Lib;
namespace Tyuiu.GunbinNA.Sprint1.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("*Задание #1.0                                                             *");
            Console.WriteLine("*Вариант #22                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая вычисляет выражение 6*2-(5-3) и печатает     *");
            Console.WriteLine("*результат на экране.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            double a = ds.Calculate();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
