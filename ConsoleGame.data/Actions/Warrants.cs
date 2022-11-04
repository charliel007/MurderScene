using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Warrants
    {
        public void WarrantOptions(List<Suspect> suspects)
    {

        // Suspect1 suspect1 = new Suspect1();
        // Suspect2 suspect2 = new Suspect2();
        // Suspect3 suspect3 = new Suspect3();


    Console.Clear();
    
        while (true)
        {
            System.Console.WriteLine($"{suspects[0].Name}  {suspects[0].Age}  {suspects[0].Occupation}   {suspects[0].Relationship}\n\n" +
                            $"{suspects[1].Name}   {suspects[1].Age}  {suspects[1].Occupation}   {suspects[1].Relationship}\n\n" +
                            $"{suspects[2].Name}   {suspects[2].Age}  {suspects[2].Occupation}   {suspects[2].Relationship}\n\n");
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
                //
                break;
            case "2":
                //
                break;
            case "3":
                //
                break;
            case "4":
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
