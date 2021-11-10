using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab23
{
    class Program
    {
        
        static void Main(string[] args)
        {
            FactorAsync();
            for (int i = 0; i < 20; i++)
                Console.WriteLine("Счетчик увеличился на {0}", i);
            Console.WriteLine("Метод майн закончил работу");
            Console.ReadKey();

        }
        static int Factor()
        {
            Console.WriteLine("Введите число для поиска факториала");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i=1;i<=n;i++)
            {
                fact *= i;
                Console.WriteLine(fact);
                Thread.Sleep(1);
            }
            return fact;

        }
        static async Task<int> FactorAsync()
        {
            int result = await Task.Run(() => Factor());
            Console.WriteLine("Факториал равен {0}",result);
            return result;
        }
    }
}
