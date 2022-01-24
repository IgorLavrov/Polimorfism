using System;
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
                Person[] ob = new Person[10];   //массив ссылок
                int n = 0; string s, s1;
                do
                {
                Console.WriteLine("Сделай свой выбор");
                Console.WriteLine("Студент(s) / Преподаватель(t) / Рабочий(c) / Директор(a) / Врач (k)?");
                    s = Console.ReadLine();
                    if (s == "s") ob[n] = new Student(); // создаем объект класса Студент
                    if (s == "t") ob[n] = new Teach();   // создаем объект класса Преподаватель
                    if (s == "c") ob[n] = new Worker();
                    if (s == "a") ob[n] = new Director();
                    if (s == "k") ob[n] = new Doctor();
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

