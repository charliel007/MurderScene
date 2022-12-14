
public class SuspectQuestions
{
    public static void AskQuestion(Suspect suspect)
    {
        
        while (true)
        {
            System.Console.WriteLine($"Suspect under investigation: {suspect.Name}");

            System.Console.WriteLine("Make your choice!\n" +
                                "1. Tell me about your alibi for the night of the crime.\n " +
                                "2. Do you have any grudges against (victim)?\n " +
                                "3. Did you notice anything suspicious around the time that (victim) fell off of his stool?\n " +
                                "4. Did you notice any weird interactions (victim) had with the other suspects?\n " +
                                "0. Return to previsou menu");

            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    System.Console.WriteLine(suspect.SuspectResponses[0]);
                    Program.UserMove();
                    break;
                case "2":
                    System.Console.WriteLine(suspect.SuspectResponses[1]);
                    Program.UserMove();
                    break;
                case "3":
                    System.Console.WriteLine(suspect.SuspectResponses[2]);
                    Program.UserMove();
                    break;
                case "4":
                    System.Console.WriteLine(suspect.SuspectResponses[3]);
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


    //System.Console.WriteLine($"________Which question would you like to ask {}?__________");
    // Console.Clear();
    
    //     while (true)
    //     {
    //         Console.WriteLine(
    //         $"________Which question would you like to ask {}?__________\n\n" +
    //         "1. Where were you on the night of the incident?\n" +
    //         "2. Did you hold a grudge against (victim)?\n" +
    //         "3. Did you see anything suspicious around the time that (victim) fell off his stool?\n" +
    //         "4. Did you see any of (victim)'s interactions with other suspects?/n");
        
    //     string selection = Console.ReadLine() ?? "";
    //     switch (selection)
    //     {
    //         case "1":
                
    //             break;
    //         case "2":
    //             //
    //             break;
    //         case "3":
    //             //
    //             break;
    //         case "4":
    //             //
    //             break;
    //         case "0":
    //             return;
    //         default:
    //             Console.WriteLine("Please enter a valid selection.");
    //             Program.PauseAndWaitForKeypress();
    //             break;
    //     }
    //     }
    // }   