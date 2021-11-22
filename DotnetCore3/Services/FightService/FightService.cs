using System;
using System.Collections.Generic;
using System.Linq;
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

                int damage = attacker.Weapon.Damage + (new Random().Next(attacker.Strength));
                damage -= new Random().Next(opponent.Defense);
                if(damage > 0)
                    opponent.HitPoints -= damage;
                if(opponent.HitPoints <= 0)
                    response.Message = $"{opponent.Name} has been defeated!";

                _context.Characters.Update(opponent);
                await _context.SaveChangesAsync();

                response.Data = new AttackResultDto
                {
                    Attacker = attacker.Name,
                    AttackerHP = attacker.HitPoints,
                    Opponent = opponent.Name,
                    OpponentHP = opponent.HitPoints,
                    Damage = damage
                };
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request)
        {
            ServiceResponse<AttackResultDto> response = new ServiceResponse<AttackResultDto>();
            try
            {
                Character attacker = await _context.Characters
                    .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                    .FirstOrDefaultAsync(c => c.Id == request.AttackerId);
                Character opponent = await _context.Characters.
                    FirstOrDefaultAsync(c => c.Id == request.OpponentId);

                CharacterSkill characterSkill = 
                    attacker.CharacterSkills.FirstOrDefault(cs => cs.Skill.Id == request.SkillId); 
                if(characterSkill == null)
                {
                    response.Success = false;
                    response.Message = $"{attacker.Name} doesn't know that skill.";
                }  

                int damage = characterSkill.Skill.Damage + (new Random().Next(attacker.Strength));
                damage -= new Random().Next(opponent.Defense);
                if(damage > 0)
                    opponent.HitPoints -= damage;
                if(opponent.HitPoints <= 0)
                    response.Message = $"{opponent.Name} has been defeated!";

                _context.Characters.Update(opponent);
                await _context.SaveChangesAsync();

                response.Data = new AttackResultDto
                {
                    Attacker = attacker.Name,
                    AttackerHP = attacker.HitPoints,
                    Opponent = opponent.Name,
                    OpponentHP = opponent.HitPoints,
                    Damage = damage
                };
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request)
        {
            ServiceResponse<FightResultDto> response = new ServiceResponse<FightResultDto>
            {
                Data = new FightResultDto()
            };
            try
            {
                 List<Character> character = await _context.Characters
                    .Include(c => c.Weapon)
                    .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                    .Where(c => request.CharacterIds.Contains(c.Id)).ToListAsync();

                bool defeated = false;
                while(!defeated)
                {
                    foreach(Character attacker in character)
                    {
                        List<Character> opponents = character.Where(c => c.Id != attacker.Id).ToList();
                        Character opponent = opponents[new Random().Next(opponents.Count)];

                        int damage = 0;
                        string attackeUsed = string.Empty;

                        bool useWeapon = new Random().Next(2) == 0;
                        if(useWeapon)
                        { }
                        else{ }
                    }
                }
            }
            catch (Exception ex)
            {                
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}