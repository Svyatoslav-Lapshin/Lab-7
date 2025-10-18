using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator.Data
{
    internal class DataRepository
    {
        // Arrays containing data for character generation
        public string[] Races =
        {
            "Human", 
            "Elf", 
            "Dwarf", 
            "Orc",
            "Halfling",
            "Goblin"
        };

        public string[] Gender =
        {
            "Man",
            "Kvinna"
        };

        public string[] Classes =
        {
            "Warrior", 
            "Mage", 
            "Rogue", 
            "Hunter", 
            "Cleric", 
            "Paladin", 
            "Bard"
        };

        public string[] MaleNames =
        {
            "Arin", 
            "Borin", 
            "Cedric", 
            "Doran", 
            "Eldric", 
            "Finn", 
            "Galen", 
            "Hector", 
            "Ivar", 
            "Joren"
        };

        public string[] FemaleNames =
        {
        
            "Alina", 
            "Brina", 
            "Celia", 
            "Daria", 
            "Elara", 
            "Fiona", 
            "Gwen", 
            "Helena", 
            "Isolde", 
            "Jaina"
        };


    }
}
