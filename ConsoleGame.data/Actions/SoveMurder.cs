using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class SolveMurder
    {
        
    public void SolveTheMurder()
    {
        string forensics = "Stomach contents contained (poisonous plant) in numbers so radical that there is no way this could have been an accident. How convenient that (suspect 1) had that very plant in her kitchen.";
        
        while (true)
        {
            System.Console.WriteLine("Make a choice on who you think is guilty!\n" +
                                "1. Suspect 1\n" +
                                "2. Suspect 2\n" +
                                "3. Suspect 3\n " +
                                "4. No one is guilty, he died of natural causes...\n ");

            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    System.Console.WriteLine(forensics);
                    System.Console.WriteLine("You won the game!");
                    System.Environment.Exit(1);
                    break;
                case "2":
                    System.Console.WriteLine(forensics);
                    System.Console.WriteLine("I'm sorry, you lost the game.");
                    System.Environment.Exit(1);
                    break;
                case "3":
                    System.Console.WriteLine(forensics);
                    System.Console.WriteLine("I'm sorry, you lost the game.");
                    System.Environment.Exit(1);
                    break;
                case "4":
                    System.Console.WriteLine(forensics);
                    System.Console.WriteLine("I'm sorry, you lost the game.");
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    Program.PauseAndWaitForKeypress();
                    break;
            }
        }
    }
    }