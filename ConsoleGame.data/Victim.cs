public class Victim
{
    public Victim()
    {
        
    }
    public string Name { get; set; } = "Mr. Victim";
    public int Age { get; set; } = 30;
    public string Occupation { get; set; } = "Works with co-workers";
    public string CauseOfDeath { get; set; } = "Poisoned";
    public List<Crime> Crimes { get; set; } = new List<Crime>
                                             { new Crime("DUI","misdemeanor: Guilty",new DateTime(2021,05,05),"Town","State")};
}