
public class Suspect
{
    public Suspect(string name, int age, string occupation, string relationship, bool criminalHistory, bool isGuilty,
    List<string> suspectResponses, List<Crime> crimes)
    {
        Name = name;
        Age = age;
        Occupation = occupation;
        Relationship = relationship;
        CriminalHistory = criminalHistory;
        IsGuilty = isGuilty;
        SuspectResponses = suspectResponses;
        Crimes = crimes;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public string Relationship { get; set; }
    public bool CriminalHistory { get; set; }
    public bool IsGuilty { get; set; }

    public List<string>SuspectResponses{get; set;} = new List<string>();
    public List<Crime> Crimes { get; set; } = new List<Crime>();
}



// NO CRIMINAL HISTORY

// “ASSAULT \n
// 		FELONY: GUILTY \n 
// 		10/24/2021 \n
// (town, state) \n” + 
// 		“\n” +
// “PUBLIC NUISANCE \n
// 		MISDEMEANOR: GUILTY \n
// 		10/4/2021 \n
// (town, state) \n” + 
// 		“\n” +
// 		“ASSAULT \n
// 		FELONY: GUILTY \n 
// 		2/24/2021 \n
// (town, state) \n” + 
// 		“\n” +
// 		“PUBLIC INTOXICATION \n
// 		MISDEMEANOR: GUILTY \n
// 		2/24/2021 \n
// (town, state) \n” + 
// 		“\n”
