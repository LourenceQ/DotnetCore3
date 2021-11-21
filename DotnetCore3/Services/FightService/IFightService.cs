using System.Threading.Tasks;
using DotnetCore3.Dto.Fight;
using DotnetCore3.Models;

namespace DotnetCore3.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}