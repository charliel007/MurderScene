using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class WitnessQuestions
{
public static void AskQuestion(Witness witness, List<string> interrogationQuestions)
    {
        System.Console.WriteLine($"Suspect under investigation: {witness.Name}");
        foreach (var question in interrogationQuestions)
        {
            WitnessResponse(question, witness.WitnessResponses);
        }
    }
private static void WitnessResponse(string question, List<string> answers)
    {
        System.Console.WriteLine(question);
        System.Console.WriteLine("Make your choice!\n" +
                                "1. Did you happen to see (suspect1) interacting with (victim) at any point?\n" +
                                "1. Did you happen to see (suspect2) interacting with (victim) at any point?\n" +
                                "1. Did you happen to see (suspect3) interacting with (victim) at any point?\n" +
                                "2. Anything you happen to remember that stands out to you? Even something small?\n");


        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                System.Console.WriteLine(answers[0]);
                break;
            case "2":
                System.Console.WriteLine(answers[1]);
                break;
            case "3":
                System.Console.WriteLine(answers[2]);
                break;
            case "4":
                System.Console.WriteLine(answers[3]);
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
