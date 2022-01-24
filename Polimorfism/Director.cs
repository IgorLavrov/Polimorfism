using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Director:Person
    {
        int people;
        public override void SetData()
        {
            Console.WriteLine("Директор");
            base.SetName();
            Console.Write("Кол-во работников:");
            string s;
            s = Console.ReadLine();
            people = Convert.ToInt32(s);
        }
        public override bool SetStat()
        { if (people > 30) { base.GetName(); Console.Write("Количество работников=" + people); return true; } else return false; }
    }
}
