using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите cторону прямоугольника А -");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите cторону прямоугольника В -");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите cторону квадрата С -");
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = c;
            int sum1 = c;
            int kol=0,kol1=0;


            while (sum <= a )
            {
                
                sum += c;
                 kol++;
                
            }
            while (sum1 <= b)
            {
                sum1 += c;
                kol1++;
            }
                Console.WriteLine("Количество квадратов со стороной С равно {0}  ", (kol*2)+(kol1*2));
            Console.ReadKey();
        }
        
    }
}
