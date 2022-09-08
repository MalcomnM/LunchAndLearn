using Refit;

namespace Models.Characters;

public class GetCharactersResult
{
    [AliasAs("info")]
    public Info Info { get; set; }
    
    [AliasAs("results")]
    public List<Character> Results { get; set; }
}
