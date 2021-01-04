using System.Threading.Tasks;
using Udemy_NetCore.Dtos.Character;
using Udemy_NetCore.Dtos.CharacterSkill;
using Udemy_NetCore.Models;

namespace Udemy_NetCore.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
         Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}