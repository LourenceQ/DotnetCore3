using System.Threading.Tasks;
using DotnetCore3.Dto.Character;
using DotnetCore3.Dto.Weapon;
using DotnetCore3.Models;

namespace DotnetCore3.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}