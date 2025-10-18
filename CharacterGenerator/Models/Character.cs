using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator.Models
{
    internal class Character
    {
        //Properties for a character
        public string Name { get; set; } 
        public string Gender { get; set; } 
        public string Race { get; set; }  
        public string Class { get; set; } 

        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
      

        // Override ToString method to display character information
        public override string ToString()
        {
            return $"Namn: {Name}, Ras: {Race}, Kön: {Gender}, Klass: {Class}" +
                   $"Styrka: {Strength}, Smidighet: {Agility}, Intelligens: {Intelligence}";
        }

    }
}
