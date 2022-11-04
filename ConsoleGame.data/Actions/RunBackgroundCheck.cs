public class RunBackgroundCheck
{
    public void Background(List<Suspect> suspects)
    {

        // Suspect1 suspect1 = new Suspect1();
        // Suspect2 suspect2 = new Suspect2();
        // Suspect3 suspect3 = new Suspect3();
        Victim victim = new Victim();


        Console.Clear();

        while (true)
        {
            System.Console.WriteLine($"{suspects[0].Name}  {suspects[0].Age}  {suspects[0].Occupation}   {suspects[0].Relationship}\n\n" +
                                    $"{suspects[1].Name}   {suspects[1].Age}  {suspects[1].Occupation}   {suspects[1].Relationship}\n\n" +
                                    $"{suspects[2].Name}   {suspects[2].Age}  {suspects[2].Occupation}   {suspects[2].Relationship}\n\n" +
                                    $"{victim.Name}   {victim.Age}  {victim.Occupation}   {victim.CauseOfDeath}\n\n");
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
                    //
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