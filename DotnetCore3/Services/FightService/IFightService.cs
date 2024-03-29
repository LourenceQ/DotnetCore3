using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetCore3.Dto.Fight;
using DotnetCore3.Models;

namespace DotnetCore3.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight (FightRequestDto request);
        Task<ServiceResponse<List<HighScoreDto>>> GetHighScore();
    }
}