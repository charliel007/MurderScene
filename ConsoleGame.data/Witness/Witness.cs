public class Witness
{
    public Witness(string name, int age, string occupation, string role, List<string> witnessResponses)
    {
        Name = name;
        Age = age;
        Occupation = occupation;
        Role = role;
        WitnessResponses = witnessResponses;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public string Role { get; set; }
    public List<string>WitnessResponses{get; set;} = new List<string>();
}