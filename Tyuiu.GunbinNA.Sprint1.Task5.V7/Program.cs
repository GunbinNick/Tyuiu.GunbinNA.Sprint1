using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.GunbinNA.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гунбин Н. А | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Преобразование типов и класс Convert                               *");
            Console.WriteLine("*Задание #1.5                                                             *");
            Console.WriteLine("*Вариант #7                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Определить h -полное кол-во часов прошедшиъ от начала суток до того      *");
            Console.WriteLine("*момента(в первой половине дня),когда часовая стрелка повернулась на      *");
            Console.WriteLine("*f градусов(0<f<360, f - вещественное число)                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double f;

            Console.WriteLine("Введите значение F:");
            f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.AngleToHoursMinutes(f));
            Console.ReadKey();
        }
    }
}
