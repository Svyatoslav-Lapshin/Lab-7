using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{

    //Class for validating user input
    internal class InputValidation
    {
        public static int ValidateIntInput(string question)
        {
            Console.WriteLine(question);
            bool check = int.TryParse(Console.ReadLine(), out int result);

            while (!check || result <= 0)
            {
                Console.WriteLine("Ogiltig inmatning. Ange ett giltigt positivt heltal:");
                check = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }


        public static int ValidateIntInRange(string question, int min, int max)
        {
            Console.Write(question);
            bool check = int.TryParse(Console.ReadLine(), out int result);
            while (!check || result < min || result > max)
            {
                Console.WriteLine($"Ogiltig inmatning. Ange ett heltal mellan {min} och {max}:");
                check = int.TryParse(Console.ReadLine(), out result);
            }
            return result;

        }
    }
}
