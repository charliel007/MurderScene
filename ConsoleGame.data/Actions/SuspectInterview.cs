
public class SuspectInterview
{
SuspectQuestions questions = new SuspectQuestions();


public void Suspects(List<Suspect> suspects)
    {
    Console.Clear();
        
        while (true)
        {
            System.Console.WriteLine($"Suspect 1:  {suspects[0].Name}  {suspects[0].Age}  {suspects[0].Occupation}   {suspects[0].Relationship}\n" +
                                     $"Suspect 2:  {suspects[1].Name}   {suspects[1].Age}  {suspects[1].Occupation}   {suspects[1].Relationship}\n" +
                                     $"Suspect 3:  {suspects[2].Name}   {suspects[2].Age}  {suspects[2].Occupation}   {suspects[2].Relationship}\n");
            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Interview Suspect 1\n" +
            "2. Interview Suspect 2\n" +
            "3. Interview Suspect 3\n" +
            "4. Solve the Murder!\n" +
            "0. Return to previous menu"
            );

        string selection = Console.ReadLine() ?? "";

        switch (selection)
        {
            case "1":
                SuspectQuestions.AskQuestion(suspects[0]);
                break;
            case "2":
                SuspectQuestions.AskQuestion(suspects[1]);
                break;
            case "3":
                SuspectQuestions.AskQuestion(suspects[2]);
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