﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Program
    {
       
            static void Main(string[] args)
            {
                Person[] ob = new Person[5];   //массив ссылок
                int n = 0; string s, s1;
                do
                {
                    Console.WriteLine("Студент(s) / Преподаватель(t)?");
                    s = Console.ReadLine();
                    if (s == "s") ob[n] = new Student(); // создаем объект класса Студент
                    if (s == "t") ob[n] = new Teach();   // создаем объект класса Преподаватель
                    ob[n].SetData();        // вызов метода соответствующего производного класса
                    n++;
                    Console.WriteLine("y/n?");
                    s1 = Console.ReadLine();
                } while (s1 == "y");
                for (int i = 0; i < n; i++)   // проверка на выдающуюся личность
                {
                    if (ob[i].SetStat()) { Console.WriteLine("  Это выдающаяся личность! "); }
                }
                Console.ReadLine();
            }
        }
    }

