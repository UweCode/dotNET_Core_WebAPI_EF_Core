using System.Threading.Tasks;
using Udemy_NetCore.Dtos.Character;
using Udemy_NetCore.Dtos.Weapon;
using Udemy_NetCore.Models;

namespace Udemy_NetCore.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}