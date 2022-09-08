using Models.Characters;
using Services.API;
using Services.Client;

namespace Services;

public class CharacterService: ICharacterApi
{
    private readonly ICharacterApi characterApi;

    public CharacterService()
    {
        characterApi = RestServiceFactory.CreateService<ICharacterApi>();
    }

    public async Task<GetCharactersResult> Characters(int page = 1)
    {
        var result = await characterApi.Characters(page);
        return result;
    }
}
