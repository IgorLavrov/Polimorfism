using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
   
       public  abstract class Person
        {
            string name;   //Фамилия
            public void SetName()        // Метод запроса фамилии
            { Console.Write("Фамилия :"); name = Console.ReadLine(); }
            public void GetName()      // Метод вывода фамилии 
            { Console.WriteLine(" Господин " + name); }
            //реализация следующих методов будет определена в потомках      
            public abstract void SetData();   // Метод запроса данных
            public abstract bool SetStat();   //  Метод определения выдающейся личности
        }
    }

