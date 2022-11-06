using System.Security.Cryptography;


public class Program
{
    public static void Main()
    {
       

        Suspect suspect1 = new Suspect("WifeName",
                                        30,
                                        "Homemaker",
                                        "Wife",
                                        false,
                                        true,
                                        new List<string>{
                                "At home seething, he went out to the bar again! I was home alone, washing the dishes. Someone has to clean up and it certainly wasn’t going to be him.",
                                "He’s a good-for-nothing scoundrel who goes out to the bar too much! There’s no way he’s not cheating on me, gone until all hours of the night.",
                                "Nope, wasn’t there.",
                                "Nope, I wasn’t there...."},
                                        null,
                                        new List<string> {
                                "Text message telling (victim): 'Whatever. I know you won’t be coming home tonight.' Voicemail from pharmacist: 'Your prescription is ready to be picked up. Be careful when you take this!'",
                                "Interesting looking plant with dirty muddler sitting out on the counter and a Love note signed with someone’s name who isn’t (victim)" });
        Suspect suspect2 = new Suspect("CoWorkerName",
                                        30,
                                        "Engineer",
                                        "Co-Worker",
                                        false,
                                        false,
                                        new List<string>{
                                "I was at the bar, sitting a few seats down from (victim) trying to ignore him! I wish there was any other bar to go to in this town where I could go to drown my sorrows… I don’t know why the boss gave (victim) the promotion after that crap he pulled a couple years ago. My buddy met me there after work.",
                                "The boss gave (victim) the promotion I worked so hard for, even after his check fraud incident and coming into work drunk!",
                                "He was wobbly because he’s a stupid drunk! This is the only bar in this town! I couldn’t avoid him!",
                                "I was trying to ignore him. I don’t remember seeing his wife there. There’s no way he would bring her, they can’t stand each other."
                                        },
                                        null,
                                        new List<string> {
                                "Text message to (witness 2): 'I overheard that jerk on the phone with his wife. She sounded even more pissed than I am.'  Notepad: 'I HATE HIM I HATE HIM I HATE HIM! Maybe I’ll find a way to 'make him” quit.'",
                                "(Victim)’s permanent employee record… with his wife crossed out as the emergency contact.  (Victim)’s picture on a dart board with several holes" });

        Suspect suspect3 = new Suspect("Rusty Shackelford",
                                        30,
                                        "Exterminator",
                                        "Town crazy",
                                        true,
                                        false,
                                        new List<string>{
                                "I was trying to get (victim) to buy me another beer. He bought me one last time! The bouncer kicked me out, so I was panhandling outside the bar to see if someone would give me beer money. I was just trying to get (victim) to buy me a beer by any means necessary!",
                                "We kinda got into it a year or so ago when I just wanted another beer the last time he bought me a beer. He could afford it! I saw all that cash in his wallet!",
                                "I didn’t do nothin’",
                                "I’d have remembered seeing a lady in the bar! (Suspect 2) pointed and whispered to the person sitting next to him… we made eye contact when (victim) bought me a beer."
                                        },

                                        new List<Crime>
                                        {
                                new Crime("Assault","Felony: Guilty",new DateTime(2021,10,24),"Town","State"),

                                new Crime("Public Nuisance","Misdemeanor: Guilty",new DateTime(2021,10,04),"Town","State"),

                                new Crime("Assault","Felony: Guilty",new DateTime(2021,02,24),"Town","State"),

                                new Crime("Public Intoxication","Misdemeanor: Guilty",new DateTime(2021,02,04),"Town","State"),
                                        },
                                        new List<string> {
                                "No phone to check because he lost it when he was drunk… try again!",
                                "(Victim)’s business card with woman’s name and phone number on the back.  List of names entitled 'People who have bought me beers' with some names, including (victim)’s, underlined" });

        Witness witness1 = new Witness("Im Witness1", 30, "Bartender", "Served victim",
                                        new List<string>{"Nope, I didn’t see (suspect 1). I used to call her to come get (victim), but at this point, she won’t come get him anymore.",
                                                "I couldn’t help but overhear him talking to (witness 2) about how much he hated his co-worker who got the promotion he was supposed to get, and how the boss said if (victim) quits, he’ll backfill him, but that’s not good enough, blah blah blah.... ",
                                                "I warned him not to buy (suspect 3) a beer… he didn’t listen. (Suspect 3) is crazy.,",
                                                "Actually, yes, now that you mention it. It sure seemed like (victim) had to go to the bathroom a lot. At the time, I didn’t think anything of it because he could’ve pre-gamed for all I know; but in hindsight, maybe he was a bit sickly?"}
                                                        );
        Witness witness2 = new Witness("Im Witness2", 30, "Engineer", "Tried to help victim",
                                        new List<string>{"No, there wasn’t a woman with him, but I couldn’t help but notice he was having a pretty animated phone conversation for a minute there… maybe it was her?",
                                                "I was there with (suspect 2) – we’re friends. (Suspect 2) talked crap about (victim) all night, but didn’t want to go anywhere near him. (Suspect 2) cringed every time (victim) walked past to go to the bathroom.",
                                                "I saw him buy that scruffy guy a beer, and he got mad when (victim) wouldn’t buy him another one and the bouncer ended up kicking him out.",
                                                "A dude literally keeling over and dying was pretty weird. He was my buddy’s arch-nemesis and all, but I couldn’t just not try to help."});
        Witness witness3 = new Witness("Im Witness3", 30, "Bouncer", "Was there",
                                        new List<string>{"I literally have to talk to every single person when they come in; I don’t remember.",
                                                "My back was to them; didn’t see anything.",
                                                "Ugh, that guy… you buy him a beer once, and you’ll never hear the end of it! He was harassing (victim) to buy him another beer. I was afraid he was going to get violent on another patron, so I kicked him out. Unfortunately, I can’t make him stop asking people outside for beer money.",
                                                "What weirdo would tease a guy by buyin’ him a beer, and say no to keepin’ the buzz goin’?! That’s weird I tell ya!"});

        List<Suspect> suspects = new List<Suspect>() { suspect1, suspect2, suspect3 };
        List<Witness> witnesses = new List<Witness>() { witness1, witness2, witness3 };


        SuspectInterview suspectInterview = new SuspectInterview();
        WitnessInterview witnessInterview = new WitnessInterview();
        RunBackgroundCheck runBackgroundCheck = new RunBackgroundCheck();
        Forensics forensics = new Forensics();
        Warrants warrants = new Warrants();
        Unlawful unlawful = new Unlawful();
        SolveMurder solveMurder = new SolveMurder();





        Console.Clear();
        System.Console.WriteLine("----Murder Solve---\n");
        System.Console.WriteLine("You are a small-town detective who’s been assigned to a murder scene: the local bar, ___________ in rural _________, ___. A long-time local resident, ___________, had just finished a beer, when he suddenly fell off of his stool. Fellow patrons rushed to help him back up thinking he’d lost his balance, only to find that he was dead! Detective Player’s job is to find out who did it, and fast! \n\n\n");

        System.Console.WriteLine("Your Challenge!  You only have 7 detective choices that you can make to solve this case.  Each choice can provide information to help in determining from the 3 suspects who did it!  Be careful of using UnLawful tactic choices!");

        PauseAndWaitForKeypress();

        bool continueToRun = true;

        while (continueToRun)
        {
            Console.Clear();
            Console.WriteLine(
            "----Murder Solve---\n" +
            "1. Suspects\n" +
            "2. Witnesses\n" +
            "3. Background Check(s)\n" +
            "4. Try for Warrant(s)\n" +
            "5. Unlawful Tactics\n" +
            "6. Solve the Murder!\n" +
            "0. Exit"
            );

            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    suspectInterview.Suspects(suspects);
                    break;
                case "2":
                    witnessInterview.Witnesses(witnesses);
                    break;
                case "3":
                    runBackgroundCheck.Background(suspects);
                    break;
                case "4":
                    warrants.WarrantOptions(suspects);
                    break;
                case "5":
                    unlawful.UnlawfulTactics(suspects);
                    break;
                case "6":
                    solveMurder.SolveTheMurder(suspects);
                    break;
                case "0":
                    continueToRun = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    PauseAndWaitForKeypress();
                    break;
            }
        }
        Console.WriteLine("Goodbye!");

    }

    public static void PauseAndWaitForKeypress()
    {
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public static int userMoves = 10;

    public static void UserMove()
    {

        if (userMoves > 0)
        {
            Console.WriteLine($"You have {userMoves} left!");
        }
        else if (userMoves == 0)
        {
            //call method to show fernsics for final determination
        }
        else
        {
            Console.WriteLine("You lost the game, better luck next time :(");
        }

        userMoves--;
    }

}