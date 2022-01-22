using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab20_1
{
    class Program
    {
        delegate double myDelegate(double a);
        static void Main(string[] args)
        {
            double L = 0;
            double S = 0;
            double V = 0;
            Console.Write("Введите радиус окружности - ");
            double R = Convert.ToDouble(Console.ReadLine());
            myDelegate DELEGATE = Length;
            if (DELEGATE!=null)
            {
                L = DELEGATE(R);
            }
            Console.WriteLine("Длина окружности = {0}", L);
            DELEGATE += Square;
            if (DELEGATE != null)
            {
                S = DELEGATE(R);
            }
            Console.WriteLine("Площадь окружности = {0}", S);
            DELEGATE += Volume;
            if (DELEGATE != null)
            {
                V = DELEGATE(R);
            }
            Console.WriteLine("Объём шара = {0}", V);
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
        static double Length(double R)
        {
            double L = 2 * Math.PI * R;
            return L;
        }

        static double Square(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            return S;
        }

        static double Volume(double R)
        {
            double V;
            V = (4 * Math.PI * Math.Pow(R, 3))/3;
            return V;
        }
    }
}
