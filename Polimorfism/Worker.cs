using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Worker : Person
    {
        int work;          
        public override void SetData()  
        {
            Console.WriteLine(" Рабочий");
            base.SetName();    
            Console.Write("Кол-во работ:");
            string s;
            s = Console.ReadLine();
            work = Convert.ToInt32(s);
        }
        public override bool SetStat()  
        { if (work > 2) { base.GetName(); Console.Write("Количество работ=" + work); return true; } else return false; }
    }
}

