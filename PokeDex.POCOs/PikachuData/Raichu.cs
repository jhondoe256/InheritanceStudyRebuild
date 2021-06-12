using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.POCOs.PikachuData
{
    public class Raichu : Pikachu
    {
        public bool EvolvedWithThunderstoneOutsideAlola { get; set; }

        public bool HasPsychicAbility 
        {
            get 
            {
                //return a terinary expression:
                //return (EvolvedWithThunderstoneOutsideAlola) ?false:true;

                if (EvolvedWithThunderstoneOutsideAlola)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public void ThunderShock() 
        {
            Console.WriteLine($"{Name} Performed: T-H-U-N-D-E-R~~~~~SHOCK!");
        }

        public void LightScreen() 
        {
            if (HasPsychicAbility)
            {
                Console.WriteLine($"{Name} Performed : LightScreen!");
            }
            else
            {
                Console.WriteLine($"{Name}...This Pokemon doesn't have the ability to perform this attack!");
            }
        }

        public override void Slam()
        {
            Console.WriteLine($"{Name}, HAS POWER SLAMED YOU!!!");
        }

        public Raichu()
        {

        }

        public Raichu(bool evolvedWithThunderstoneOutsideAlola, int pokeDexID, string Name, int NationalNumber, string Type, string Height, string Weight, List<string> Abilities)
            :base(pokeDexID,Name,NationalNumber,Type,Height,Weight,Abilities)
        {
            EvolvedWithThunderstoneOutsideAlola = evolvedWithThunderstoneOutsideAlola;
        }

    }
}
