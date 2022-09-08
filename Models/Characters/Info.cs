using Refit;

namespace Models.Characters;

public class Info
{
    [AliasAs("count")]
    public int Count { get; set; }

    [AliasAs("pages")]
    public int Pages { get; set; }

    [AliasAs("next")]
    public string Next { get; set; }

    [AliasAs("prev")]
    public string Prev { get; set; }
}
