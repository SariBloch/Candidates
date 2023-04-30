// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Collections.Generic;

public class Candidate
{
    public string id { get; set; }
    public string name { get; set; }
    public string beginYear { get; set; }
    public string lastUpdateDate { get; set; }
    public List<int> languages { get; set; }
}

public class Language
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Root
{
    public List<Candidate> Candidates { get; set; }
    public List<Language> Languages { get; set; }
}
