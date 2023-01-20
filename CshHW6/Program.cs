﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            Journal journal1 = new Journal("Игромания");
            journal1.SetCountOfWorkers(10);
            journal1.ShowCountOfWorkers();
            journal1 += 10;
            journal1.ShowCountOfWorkers();
            //Console.ReadKey();

            Journal journal2 = new Journal("Москва");
            journal2.SetCountOfWorkers(54);

            if(journal1 < journal2)
            {
                Console.WriteLine($"Число работников в журнале {journal1.ToString()} меньше чем в {journal2.ToString()}");
            }
            else
            {
                Console.WriteLine($"Число работников в журнале {journal1.ToString()} больше чем в {journal2.ToString()}");
            }

           // Console.ReadKey();

            //task 2

            Shop sh1 = new Shop("Магнит");
            Shop sh2 = new Shop("Пятерочка");

            sh1.SetArea(512.1);
            sh2.SetArea(614.3);
            sh1.ShowArea();
            sh2.ShowArea();
            sh1 += 50;
            sh2 -= 144.3;
            sh1.ShowArea();
            sh2.ShowArea();
            Console.ReadKey();


        }
    }
}
