using System;
using System.Threading.Tasks;
using DotnetCore3.Data;
using DotnetCore3.Dto.Fight;
using DotnetCore3.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore3.Services.FightService
{
    public class FightService : IFightService
    {
        private readonly DataContext _context;
        public FightService(DataContext context)
        {
            _context = context;

        }

        public async Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request)
        {
            ServiceResponse<AttackResultDto> response = new ServiceResponse<AttackResultDto>();
            try
            {
                Character attacker = await _context.Characters
                    .Include(c => c.Weapon)
                    .FirstOrDefaultAsync(c => c.Id == request.AttackerId);
                Character opponent = await _context.Characters.
                    FirstOrDefaultAsync(c => c.Id == request.OpponentId);
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}