using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.POCOs.PikachuData
{
    public class Pikachu : Pokemon
    {
        public int PokeDexID { get; set; }
        public bool OwnerHasThunderstone { get; set; }//This helps pikachu turn into raichu

        public void QuickAttack()
        {
            Console.WriteLine($"{Name} Attack: Quick Attack!");
        }

        //it allows my inherited class to do something else with the same method
        public virtual void Slam() 
        {
            Console.WriteLine($"{Name} Attack: I Slammed You!!!");
        }

        public Pikachu()
        {

        }

        public Pikachu(int pokeDexID, bool ownerHasThunderstone, string Name, int NationalNumber, string Type, string Height, string Weight, List<string> Abilities)
            :base(Name,NationalNumber,Type,Height,Weight,Abilities)
        {
            PokeDexID = pokeDexID;
            OwnerHasThunderstone = ownerHasThunderstone;
        }

        public Pikachu(int pokeDexID, string Name, int NationalNumber, string Type, string Height, string Weight, List<string> Abilities)
           : base(Name, NationalNumber, Type, Height, Weight, Abilities)
        {
            PokeDexID = pokeDexID;
           
        }
    }
}
