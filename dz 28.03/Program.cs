using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dz28_03
{
    abstract class CombatUnit
    {
        public string name { get; set; }
        public string speed { get; set; }
        public string power { get; set; }
        abstract public void Show();
    }

    class LightInfantry : CombatUnit
    {
        public LightInfantry()
        {
            name = "Конницы";
            speed = "30";
            power = "15";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class TransportVehicles : CombatUnit
    {
        public TransportVehicles()
        {
            name = "Бмп";
            speed = "70";
            power = "30";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class HeavyCombat : CombatUnit
    {
        public HeavyCombat()
        {
            name = "Бронетехника";
            speed = "10";
            power = "100";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class LightCombat : CombatUnit
    {
        public LightCombat()
        {
            name = "Пехотка";
            speed = "10";
            power = "10";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class Aircraft : CombatUnit
    {
        public Aircraft()
        {
            name = "Авиация";
            speed = "600";
            power = "100";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }


    class CombatFactory
    {
        List<Tuple<LightInfantry, string>> combats = new List<Tuple<LightInfantry, string>>();

        public CombatFactory(params CombatUnit[] cu)
        {
            foreach (var elem in cu)
            {
                combats.Add(new Tuple<LightInfantry, string>(new LightInfantry(), elem.name));
            }
        }
        public void Show()
        {
            var count = combats.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var c in combats)
            {
                Console.WriteLine(c.Item2);
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
