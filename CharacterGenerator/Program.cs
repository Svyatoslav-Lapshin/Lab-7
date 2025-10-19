
using CharacterGenerator.Generator;
//NET25
//Svyatoslav Lapshin
namespace CharacterGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of CharacterGenerator to generate characters
            var creator = new CharacterCreator();
            // Control variable for the main loop
            bool isOnGoing = true;

            while (isOnGoing)
            {
                //We call the menu display method
                DisplayMenu();
                // Get user choice with input validation
                int choice = InputValidation.ValidateIntInRange("Välj ett alternativ (1-3): ", 1, 3);
                Console.Clear();

                switch ((MenuOption)choice)
                {
                    case MenuOption.GenerateSingle:
                        // Generate a single character and display it, with all random attributes
                        var createCharacter = creator.GenerateCharacter();
                        Console.WriteLine("\nEn slumpad karaktär:");
                        Console.WriteLine(createCharacter.ToString());
                        Console.WriteLine();

                        break;

                    case MenuOption.GenerateMultiple:
                        //Generate multiple characters based on user input and display them, here we use a list to store multiple characters,
                        //because with list is dynamic and we can create muiltiple characters based on user input
                        int count = InputValidation.ValidateIntInput("Hur många karaktärer vill du skapa? ");
                        var listofCharacters = creator.GenerateCharacters(count);
                        Console.WriteLine($"\nSlumpade karaktärer ({count} st):");
                        int  index = 0;
                        foreach (var character in listofCharacters)
                        {
                            index++;
                            Console.WriteLine(index+") "+character.ToString());
                        }
                        Console.WriteLine();

                        break;
                    case MenuOption.Exit:
                        // Exit the application
                        Console.WriteLine("================================================");
                        Console.WriteLine("Tack och hej! 👋");
                        isOnGoing = false;
                        break;

                    default:
                        // This case should never be reached due to input validation
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;


                }

            }
            //Just menu to display options to the user
            static void DisplayMenu()
            {

                Console.WriteLine("=== Slumpgenerator för karaktärer ===");
                Console.WriteLine("1) Skapa en karaktär");
                Console.WriteLine("2) Skapa flera karaktärer");
                Console.WriteLine("3) Avsluta");
                Console.WriteLine();
            }
        }


    }
}
