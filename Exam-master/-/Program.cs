using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Первая_работа
{
   

  
        class Program
        {
            static void Main(string[] args)
            {
                var curs = 30;
                var tryparse = false;
                var value = 0;
                while (!tryparse)
                {
                    Console.Write("Сколько у вас долларов: ");
                    var dollar = Console.ReadLine();
                    tryparse = int.TryParse(dollar, out value);

                }
                var rubli = value * curs;
                Console.WriteLine("Курс: 1 доллар = " + curs + " Р");
                if (value < 500)
                {
                    Console.WriteLine("Учитывая коммисию 0,8 p, у вас: " + (rubli - 8) + " p");
                }
                else
                {
                    Console.WriteLine("Учитывая коммисию 3%, у вас: " + (rubli - ((rubli * 0.8) / 100)));
                }
            Console.ReadLine();
            }
        }
    }


