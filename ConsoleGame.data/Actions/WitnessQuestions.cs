using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class WitnessQuestions
{
    public static void AskQuestion(Witness witness)
    {
        while (true)
        {
            System.Console.WriteLine($"Suspect under investigation: {witness.Name}");

            System.Console.WriteLine("Make your choice!\n" +
                                    "1. Did you happen to see (suspect1) interacting with (victim) at any point?\n" +
                                    "2. Did you happen to see (suspect2) interacting with (victim) at any point?\n" +
                                    "3. Did you happen to see (suspect3) interacting with (victim) at any point?\n" +
                                    "4. Anything you happen to remember that stands out to you? Even something small?\n" +
                                    "0. Return to previsou menu");


            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    System.Console.WriteLine(witness.WitnessResponses[0]);
                    Program.UserMove();
                    break;
                case "2":
                    System.Console.WriteLine(witness.WitnessResponses[1]);
                    Program.UserMove();
                    break;
                case "3":
                    System.Console.WriteLine(witness.WitnessResponses[2]);
                    Program.UserMove();
                    break;
                case "4":
                    System.Console.WriteLine(witness.WitnessResponses[3]);
                    Program.UserMove();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    Program.PauseAndWaitForKeypress();
                    break;
            }
        }
    }
}
