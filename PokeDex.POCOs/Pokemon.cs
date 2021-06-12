using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.POCOs
{
    //This is our base class...
    public abstract class Pokemon
    {
        public string Name { get; set; }
        public int NationalNumber { get; set; }
        public string Type { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public List<string> Abilities { get; set; }

        public Pokemon()
        {

        }

        public Pokemon(string Name, int NationalNumber, string Type, string Height , string wieght,List<string> Abilities)
        {
            this.Name = Name;
            this.NationalNumber=NationalNumber;
            this.Type = Type;
            this.Height = Height;
            this.Weight = wieght;
            this.Abilities = Abilities;

        }
    }
}
