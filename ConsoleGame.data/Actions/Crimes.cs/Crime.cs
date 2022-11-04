
public class Crime
{
    public Crime(string crimeType, string crimeDescription, DateTime crimeDate, string town, string state)
    {
        CrimeType = crimeType;
        CrimeDescription = crimeDescription;
        CrimeDate = crimeDate;
        Town = town;
        State = state;
    }
    public string CrimeType { get; set; }
    public string CrimeDescription { get; set; }
    public DateTime CrimeDate { get; set; }
    public string Town { get; set; }
    public string State { get; set; }
    public override string ToString()
    {
        string str = $"Crime Type: {CrimeType}\n"+$"Crime Description: {CrimeDescription}\n"+
        $"Crime Date: {CrimeDate}\n"+ $"Town: {Town}\n" + $"State: {State}\n"+
        "___________________";
        return str;
    }
}
