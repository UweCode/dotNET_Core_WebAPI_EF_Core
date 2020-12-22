using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy_NetCore.Dtos.Character;
using Udemy_NetCore.Models;

namespace Udemy_NetCore.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}