﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint1.Task6.V7.Lib;

namespace Tyuiu.GunbinNA.Sprint1.Task6.V7
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
            Console.WriteLine("*Задание #1.6                                                             *");
            Console.WriteLine("*Вариант #7                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу: пользователь вводит текст. Напечатать все слова,     *");
            Console.WriteLine("*удалив из них последнюю букву                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            string h;

            Console.WriteLine("Введите текст:");
            h = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DeleteLastLetter(h));
            Console.ReadKey();
        }
    }
}
