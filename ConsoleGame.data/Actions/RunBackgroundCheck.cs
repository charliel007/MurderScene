public class RunBackgroundCheck
{
    public void Background(List<Suspect> suspects)
    {

        Victim victim = new Victim();


        Console.Clear();

        while (true)
        {
            System.Console.WriteLine($"Suspect 1:  {suspects[0].Name}  {suspects[0].Age}  {suspects[0].Occupation}   {suspects[0].Relationship}\n" +
                                     $"Suspect 2:  {suspects[1].Name}   {suspects[1].Age}  {suspects[1].Occupation}   {suspects[1].Relationship}\n" +
                                     $"Suspect 3:  {suspects[2].Name}   {suspects[2].Age}  {suspects[2].Occupation}   {suspects[2].Relationship}\n" +
                                     $"Victim:     {victim.Name}   {victim.Age}  {victim.Occupation}   {victim.CauseOfDeath}\n");
            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Run Background Check on Suspect 1\n" +
            "2. Run Background Check on Suspect 2\n" +
            "3. Run Background Check on Suspect 3\n" +
            "4. Run Background Check on Victim\n" +
            "5. Solve the Murder!\n" +
            "0. Return to previous menu"
            );

            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    ShowCriminalData(suspects[0]);
                    break;
                case "2":
                    ShowCriminalData(suspects[1]);
                    break;
                case "3":
                    ShowCriminalData(suspects[2]);
                    break;
                case "4":
                    Console.WriteLine(victim.Crimes[0]);  //This is as a list if you want to add more.  If so, it would need iteretaed through like the ShowCrimalData method with a foreach loop below.
                    break;
                case "5":
                    //
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
    public void ShowCriminalData(Suspect suspect)
    {
        if (suspect.Crimes == null)
        {
            System.Console.WriteLine("Suspect has no prior crimes.");
        }
        else
        {
            foreach (var crime in suspect.Crimes)
            {
                System.Console.WriteLine(crime);
            }
        }
    }
}