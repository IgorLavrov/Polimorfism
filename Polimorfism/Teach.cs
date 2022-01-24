using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Teach : Person    //производный класс  Преподаватель
    {
        int kol;          // количество публикаций преподавателя
        public override void SetData()   // Метод запроса данных по преподавателю
        {
            Console.WriteLine("Преподаватель");
            base.SetName();     // вызов метода базового класса Person
            Console.Write("Кол-во публикаций:");
            string s;
            s = Console.ReadLine();
            kol = Convert.ToInt32(s);
        }
        public override bool SetStat()  // Метод определения выдающегося преподавателя 
        { if (kol > 10) { base.GetName(); Console.Write("Количество публиаций=" + kol); return true; } else return false; }
    }
}
