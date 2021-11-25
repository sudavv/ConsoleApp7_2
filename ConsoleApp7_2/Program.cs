using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Введите длину ребра куба");
            string lenstr = Console.ReadLine();       
            double len = 0;

            try
            {
                len = Math.Abs(Convert.ToDouble(lenstr));
            }
            catch
            {
                Console.WriteLine("Не число");
            }

            Program p = new Program();
            double volume = p.CalcVolume(len);            
            double square = p.CalcSquare(len);

            Console.WriteLine("Площадь куба со стороной " + len + " - " + square);

            Console.WriteLine("Объём куба со стороной " + len + " - " + volume);
            Console.ReadLine();
            Run();
            Environment.Exit(0);           
        }

        double CalcSquare(double a)
        {
            return 6 * Math.Pow(a, 2);
        }

        double CalcVolume(double a)
        {
            return Math.Pow(a,3);
        }
    }
}