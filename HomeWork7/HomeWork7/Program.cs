using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class HomeWork7
    {
        static void Main(string[] args)
        {
            #region try
            //    Calculator calc = plus;
            //    calc += minus;
            //    Calculator calcul = th;
            //    calcul += del;

            //    calc.Invoke(10, 3);
            //    calcul(12.3, 0.8);

            //    Console.ReadKey();
            //}

            //static double plus(double x, double y)
            //{
            //    double c = x+y;
            //    Console.WriteLine($"{x}+{y}={c}");
            //    return c;

            //}
            //static double minus(double x, double y)
            //{
            //    double c = x - y;
            //    Console.WriteLine($"{x}-{y}={c}");
            //    return c;
            //}
            //static double th(double x, double y)
            //{
            //    double c = x * y;
            //    Console.WriteLine($"{x}*{y}={c}");
            //    return c;
            //}
            //static double del(double x, double y)
            //{
            //    double c = x / y;
            //    Console.WriteLine($"{x}/{y}={c}");
            //    return c;
            #endregion
            GameProcessor game = new GameProcessor();
            game.PrepareCar();

            game.Start(80);
            game.Resault();

            Console.ReadLine();
         }


    }
}
