using Models.Characters;
using Refit;

namespace Services.API;

[Headers("Accept: application/json")]
public interface ICharacterApi
{
    [Get("/character/?page={page}")]
    Task<GetCharactersResult> Characters(int page = 1);
}
