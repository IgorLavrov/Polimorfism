using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Doctor : Person
    {

        int patient;          // количество публикаций преподавателя
        public override void SetData()   // Метод запроса данных по преподавателю
        {
            Console.WriteLine("Врач");
            base.SetName();     // вызов метода базового класса Person
            Console.Write("Кол-во пациентов:");
            string s;
            s = Console.ReadLine();
            patient = Convert.ToInt32(s);
        }
        public override bool SetStat()  // Метод определения выдающегося преподавателя 
        { if (patient > 100) { base.GetName(); Console.Write("Количество пациентов=" + patient); return true; } else return false; }
    }
}
