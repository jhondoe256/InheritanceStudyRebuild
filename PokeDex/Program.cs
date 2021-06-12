using PokeDex.POCOs;
using PokeDex.POCOs.CharmanderData;
using PokeDex.POCOs.PikachuData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex
{
    class Program
    {
        static void Main(string[] args)
        {
            


            var charmander = new Charmander(true, "Char-char", 37, "Fire-Lizzard", "2ft", "50lbs", new List<string> { "Blaze", "Solar Power" });

            //  var charmander = new Charmander(true,
            // "Char-char",
            // 37,
            // "Fire-Lizzard",
            // "2ft",
            // "50lbs",
            //new List<string>
            //  {"Blaze",
            //   "Solar Power (secret move)"
            //  });

            charmander.Growl();
            charmander.FireBlitz();

            Console.WriteLine();

            var pikachu = new Pikachu(1135,"Chewy-chew-chu",1,"Electric-rodent","1ft","25lbs",new List<string> {"Eletric"});
            pikachu.QuickAttack();
            pikachu.Slam();

            Console.WriteLine();

            Raichu raichu = new Raichu(false, 2, "Rai-01", 1135, "Electric-rodent", "2.5ft", "30lbs", new List<string> { "Eletric", "Lighting-Rod" });
            raichu.Slam();
            raichu.QuickAttack();
            raichu.ThunderShock();
            raichu.LightScreen();

            Console.WriteLine();

            Raichu raichu2 = new Raichu(true, 3, "Rai-02", 1135, "Electric-rodent", "2.5ft", "20lbs", new List<string> { "Eletric", "Lighting-Rod" });
            raichu2.Slam();
            raichu2.QuickAttack();
            raichu2.ThunderShock();
            raichu2.LightScreen();

            Console.WriteLine();
            //we can make list of the base class to get all of the children of that type
            List<Pokemon> pokemons= new List<Pokemon>() 
            {
                charmander,
                pikachu,
                raichu,
                raichu2
            };

            //Display the first name of each pokemon
            foreach (Pokemon pokemon in pokemons)
            {
                Console.WriteLine($"{pokemon.Name}\n");
            }
            Console.WriteLine($"We have: {pokemons.Count} pokemons");
            //stop Console from closing
            Console.ReadKey();

        }
    }
}
