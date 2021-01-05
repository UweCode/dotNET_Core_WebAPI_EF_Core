using System.Threading.Tasks;
using Udemy_NetCore.Dtos.Fight;
using Udemy_NetCore.Models;

namespace Udemy_NetCore.Services.FightService
{
    public interface IFightService
    {
         Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
         Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
         Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
    }
}