using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Student : Person   //производный класс  Студент
    {
        double ball;     //средний балл студента
        public override void SetData()     // Метод запроса данных по студенту
        {
            Console.WriteLine("Студент:");
            base.SetName();    // вызов метода базового класса Person
            Console.Write("Средний балл:");
            string s;
            s = Console.ReadLine();
            ball = Convert.ToDouble(s);
        }
        public override bool SetStat()   // Метод определения выдающегося студента 
        { if (ball > 4.8) { base.GetName(); Console.Write("Средний балл=" + ball); return true; } else return false; }
    }
}
