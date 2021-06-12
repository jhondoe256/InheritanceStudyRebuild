using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.POCOs.CharmanderData
{
    //charmander 'is a ' Pokemon....
    public class Charmander : Pokemon
    {
        public bool IsDeClawed { get; set; }

        public Charmander()
        {

        }

        public Charmander(bool isDeClawed)
        {
            IsDeClawed = isDeClawed;
        }

        public Charmander(bool isDeClawed, string Name, int NationalNumber, string Type, string Height, string Weight, List<string> Abilities)
            :base(Name,NationalNumber,Type,Height,Weight,Abilities)
        {
            IsDeClawed = isDeClawed;
        }

        public void Growl() 
        {
            Console.WriteLine($"Charmander, {Name} Attack: Growl!");
        }

        public void FireBlitz() 
        {
            Console.WriteLine($"Charmander, {Name} Attack: FireBlitz!");
        }
    }
}
