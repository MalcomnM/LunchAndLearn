using Refit;

namespace Models.Characters;

public class Character
{
    [AliasAs("id")]
    public int Id { get; set; }

    [AliasAs("name")]
    public string Name { get; set; }

    [AliasAs("status")]
    public string Status { get; set; }

    [AliasAs("species")]
    public string Species { get; set; }

    [AliasAs("type")]
    public string Type { get; set; }

    [AliasAs("gender")]
    public string Gender { get; set; }

    [AliasAs("origin")]
    public Origin Origin { get; set; }

    [AliasAs("location")]
    public Location Location { get; set; }

    [AliasAs("image")]
    public string Image { get; set; }

    [AliasAs("episode")]
    public List<string> Episode { get; set; }

    [AliasAs("url")]
    public string Url { get; set; }

    [AliasAs("created")]
    public string Created { get; set; }
}

public class Origin
{
    [AliasAs("name")]
    public string Name { get; set; }

    [AliasAs("url")]
    public string Url { get; set; }
}

public class Location
{
    [AliasAs("name")]
    public string Name { get; set; }

    [AliasAs("url")]
    public string Url { get; set; }
}
