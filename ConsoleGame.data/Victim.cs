public class Victim
{
    public Victim()
    {
        
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public string CauseOfDeath { get; set; } = "Poisoned";
    public string Background { get; private set; } //make this defined, but not immediately visible

}