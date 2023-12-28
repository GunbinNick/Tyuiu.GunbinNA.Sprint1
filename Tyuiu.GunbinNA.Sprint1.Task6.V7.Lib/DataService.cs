using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GunbinNA.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] array = value.Split();
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = array[i].Remove(array[i].Length - 1);
            }
            value = String.Join(" ", array);
            return value;
        }
    }
}
