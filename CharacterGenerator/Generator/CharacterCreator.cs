using CharacterGenerator.Data;
using CharacterGenerator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator.Generator
{
    internal class CharacterCreator
    {
        private readonly Random _random = new Random();
        //Instance of DataRepository to access data arrays with character and other.
        private readonly DataRepository _dataRepository = new DataRepository();
        //Method to generate a  random character
        public Character GenerateCharacter()
        {
            //Generate a random gender for character
            string gender= GenerateGender();
            //Create a new character with random methods
            var character = new Character
            {
                Name = GenerateName(gender),
                Race = GetRandomFrom(_dataRepository.Races),
                Class = GetRandomFrom(_dataRepository.Classes),
                Strength = RollStat(),
                Agility = RollStat(),
                Intelligence = RollStat(),
                Gender = gender

            };

            return character;
        }

        //Method to generate multiple random characters
        public List<Character> GenerateCharacters(int count)
        {
            List<Character> characters = new List<Character>(count);
            for (int i = 0; i < count; i++)
            {
                characters.Add(GenerateCharacter());
            }
            return characters;
        }
        //Method to generate a random gender
        private string GenerateGender()
        {
            return GetRandomFrom(_dataRepository.Gender);

        }

        //Helper method to get a random item from an array, returns a default message if the array is null or empty
        private string GetRandomFrom(string[] item)
        {
            //Check if the array is null or empty
            if (item == null || item.Length == 0)
            {
                return "";
            }
            return item[_random.Next(item.Length)];

        }
        //Method to generate a random name by combining a random prefix and suffix
        private string GenerateName(string gender)
        {
            if (gender=="Man")
            {
                return GetRandomFrom(_dataRepository.MaleNames);
            }
            else
            {
                return GetRandomFrom(_dataRepository.FemaleNames);
            }
        }
        //Method to roll a stat by rolling three six-sided dice and summing the results
        private int RollStat()
        {
            return RollDie(6) + RollDie(6) + RollDie(6);
        }

        //Method to generate a random number between 1 and the specified number of sides, "sides + 1" needs because otherwise the max value would be 5.
        private int RollDie(int sides)
        {
            return _random.Next(1, sides + 1);
        }

    }
}
