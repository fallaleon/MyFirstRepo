using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonMonster pokemonmaster1 = new PokemonMonster();

            Console.Write("請輸入寶可夢身分編號: ");
            try
            {
                pokemonmaster1.MonsterNo = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("沒有這個編號，請重新輸入怪獸編號: ");
                return;
            }
            pokemonmaster1.MasterName = "Bulbasaur";
            Console.WriteLine("您所輸入的編號的怪獸名字是: {0}", pokemonmaster1.MasterName);

            pokemonmaster1.Specie = "Seed Pokémon";
            pokemonmaster1.Hight = 0.7f;
            pokemonmaster1.Weight= 6.9f;
            pokemonmaster1.LocalNo = 226;
            pokemonmaster1.Abilities = "Overgrow";
            pokemonmaster1.Japan = "Fushigidane";
           
            Console.WriteLine("Species = {0}", pokemonmaster1.Specie);
            Console.WriteLine("Hight = {0}", pokemonmaster1.Hight);
            Console.WriteLine("Weight = {0}", pokemonmaster1.Weight);
            Console.WriteLine("Abilities = {0}", pokemonmaster1.Abilities);
            Console.WriteLine("Local No. = {0}", pokemonmaster1.LocalNo);
            Console.WriteLine("Japanese = {0}", pokemonmaster1.Japan);


            MusicInstruments MusicInstruments1 = new MusicInstruments();
            Console.Write("請輸入樂器編號: ");
            try
            {
                MusicInstruments1.NationalNo = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("沒有這個編號，請重新輸入商品編號:");
                return;
            }
            MusicInstruments1.Name = "吉他";
            Console.WriteLine("您所輸入的編號的商品是: {0}", MusicInstruments1.Name);

            MusicInstruments1.price = 55500;
            MusicInstruments1.Categories = "Flamenco";
            MusicInstruments1.Country = "Spain";

            Console.WriteLine("價格 = {0}", MusicInstruments1.price);
            Console.WriteLine("類別 = {0}", MusicInstruments1.Categories);
            Console.WriteLine("製造地 = {0}", MusicInstruments1.Country);

            MusicInstruments MusicInstruments2 = new MusicInstruments();
            Console.Write("請輸入樂器編號: ");
            try
            {
                MusicInstruments2.NationalNo = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("沒有這個編號，請重新輸入商品編號: ");
                return;
            }
            MusicInstruments2.Name = "低音大提琴";
            Console.WriteLine("您所輸入的編號的商品是: {0}", MusicInstruments2.Name);

            MusicInstruments2.price = 333330;
            MusicInstruments2.Categories = "Jazz";
            MusicInstruments2.Country = "Taiwan";

            Console.WriteLine("價格 = {0}", MusicInstruments2.price);
            Console.WriteLine("類別 = {0}", MusicInstruments2.Categories);
            Console.WriteLine("製造地 = {0}", MusicInstruments2.Country);

        }
        
    }
}


