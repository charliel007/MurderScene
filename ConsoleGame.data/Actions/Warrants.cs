using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Warrants
    {
        SolveMurder solveMurder = new SolveMurder();
        public void WarrantOptions(List<Suspect> suspects)
    {

    Console.Clear();
    
        while (true)
        {
            System.Console.WriteLine($"Suspect 1:  {suspects[0].Name}   {suspects[0].Age}  {suspects[0].Occupation}   {suspects[0].Relationship}\n" +
                                    $"Suspect 2:  {suspects[1].Name}   {suspects[1].Age}  {suspects[1].Occupation}   {suspects[1].Relationship}\n" +
                                    $"Suspect 3:  {suspects[2].Name}   {suspects[2].Age}  {suspects[2].Occupation}   {suspects[2].Relationship}\n");

            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Try to get a Warrant for Suspect 1\n" +
            "2. Try to get a Warrant for Suspect 2\n" +
            "3. Try to get a Warrant for Suspect 3\n" +
            "4. Solve the Murder!\n" +
            "0. Return to previous menu"
            );
        
        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                    if (RandomNumber.Between(0, 1) == 0)
                    {
                        System.Console.WriteLine(suspects[0].WarrantInfo[0]);
                        System.Console.WriteLine(suspects[0].WarrantInfo[1]);
                    }
                    else
                    {
                        Console.WriteLine("You failed to get warrant!");
                    }
                    Program.UserMove();
                    break;
            case "2":
                    if (RandomNumber.Between(0, 1) == 0)
                    {
                        System.Console.WriteLine(suspects[1].WarrantInfo[0]);
                        System.Console.WriteLine(suspects[1].WarrantInfo[1]);
                    }
                    else
                    {
                        Console.WriteLine("You failed to get warrant!");
                    }
                    Program.UserMove();
                    break;
            case "3":
                    if (RandomNumber.Between(0, 1) == 0)
                    {
                        System.Console.WriteLine(suspects[2].WarrantInfo[0]);
                        System.Console.WriteLine(suspects[2].WarrantInfo[1]);
                    }
                    else
                    {
                        Console.WriteLine("You failed to get a warrant!");
                    }
                    Program.UserMove();
                    break;
            case "4":
                    solveMurder.SolveTheMurder();
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
