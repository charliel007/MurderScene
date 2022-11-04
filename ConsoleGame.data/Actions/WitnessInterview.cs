public class WitnessInterview
{


    WitnessQuestions questions = new WitnessQuestions();
    // Witness witness1 = new Witness1();
    // Witness witness2 = new Witness2();
    // Witness witness3 = new Witness3();
    List<string>witnessQuestions = new List<string>
    {
    "1. Did you happen to see (suspect1) interacting with (victim) at any point?\n",
    "2. Did you happen to see (suspect2) interacting with (victim) at any point?\n",
    "3. Did you happen to see (suspect3) interacting with (victim) at any point?\n",
    "4. Anything you happen to remember that stands out to you? Even something small?\n"
    };
    
    public void Witnesses(List<Witness> witnesses)
        {
    Console.Clear();
    
        while (true)
        {   
            System.Console.WriteLine($"{witnesses[0].Name}  {witnesses[0].Age}  {witnesses[0].Occupation}   {witnesses[0].Role}\n\n" +
                                    $"{witnesses[1].Name}   {witnesses[1].Age}  {witnesses[1].Occupation}   {witnesses[1].Role}\n\n" +
                                    $"{witnesses[2].Name}   {witnesses[2].Age}  {witnesses[2].Occupation}   {witnesses[2].Role}\n\n");

            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Interview Witness 1\n" +
            "2. Interview Witness 2\n" +
            "3. Interview Witness 3\n" +
            "4. Solve the Murder!\n" +
            "0. Return to previous menu"
            );
        
        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                WitnessQuestions.AskQuestion(witnesses[0], witnessQuestions);
                break;
            case "2":
                WitnessQuestions.AskQuestion(witnesses[1], witnessQuestions);
                break;
            case "3":
                WitnessQuestions.AskQuestion(witnesses[2], witnessQuestions);
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