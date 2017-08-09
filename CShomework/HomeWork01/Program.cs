using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bulbasaur";
            int nationalNo = 001;
            string specie = "Seed Pokémon";
            string hight = "2′4″ (0.71m)";
            string weight = "15.2 lbs (6.9 kg)";
            string abilities01 = "Overgrow";
            string abilities02 = "Chlorophyll (hidden ability)";
            string local01 = "001 (Red/Blue/Yellow/FireRed/LeafGreen)";
            string local02 = "226 (Gold/Silver/Crystal)";
            string local03 = "231 (HeartGold/SoulSilver)";
            string local04 = "080 (X/Y)";
            string fushigidane = "Fushigidane";

            Console.WriteLine("Pokemo Name = {0}", name);
            Console.WriteLine("National No = {0}", nationalNo);
            Console.WriteLine("Species = {0}", specie);
            Console.WriteLine("Hight = {0}", hight);
            Console.WriteLine("Weight = {0}", weight);
            Console.WriteLine("Abilities = {0}", abilities01);
            Console.WriteLine("          = {0}", abilities02);
            Console.WriteLine("Local No. = {0}", local01);
            Console.WriteLine("          = {0}", local02);
            Console.WriteLine("          = {0}", local03);
            Console.WriteLine("          = {0}", local04);
            Console.WriteLine("Japanese = {0}", fushigidane);
        }
    }
}
