public class Forensics
{
    public void forensics()
    {
    while (true)
        {
            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Forensics Data\n" +
            "2. Solve the Murder!\n" +
            "0. Return to previous menu"
            );
        
        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                //
                break;
            case "2":
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
}