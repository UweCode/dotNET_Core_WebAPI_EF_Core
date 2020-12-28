using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using Udemy_NetCore.Dtos.Character;
using Udemy_NetCore.Models;
using System;

namespace Udemy_NetCore.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        // remove static list after accessing newly created database !!
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        private readonly IMapper _mapper;
        // private readonly IMapper _context;

        //public CharacterService(IMapper mapper, DataContext context)
        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
            // _context = context;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            Character character = _mapper.Map<Character>(newCharacter);
            
            // await _context.Characters.AddAsync(character);
            // await _context.SaveChangesAsync();
            // serviceResponse.Data = (_context.Characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            
            character.Id = characters.Max(c => c.Id) + 1;   // remove whole line
            characters.Add(character);                      // remove whole line
            serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();  // remove whole line
            
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
             ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            try
            {
                // Character character = await _context.Characters.FirstAsync(c => c.Id == id);
                // _context.Characters.Remove(character);
                // await _context.SaveChangesAsync();

                Character character = characters.First(c => c.Id == id);
                characters.Remove(character);

                serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();      
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            // List<Character> dbCharacters = await _context.Characters.ToListAsync();
            // serviceResponse.Data = (dbCharacters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();  // remove/replace line
            return serviceResponse;
            ;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();
            // Character dbCharacter = await _context.Characters.FirstOrDefaultAsync(c => c.Id == id));
            // serviceResponse.Data = _mapper.Map<GetCharacterDto>(dbCharacter);
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));  // remove/replace line
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();
            try
            {
            // Character character = await _context.Characters.FirstOrDefaultAsync(c => c.Id == updatedCharacter.Id);

            Character character = characters.FirstOrDefault(c => c.Id == updatedCharacter.Id);  // remove/replace line
            character.Name = updatedCharacter.Name;
            character.Class = updatedCharacter.Class; 
            character.Defense = updatedCharacter.Defense; 
            character.HitPoints = updatedCharacter.HitPoints; 
            character.Intelligence = updatedCharacter.Intelligence; 
            character.Strength = updatedCharacter.Strength;

            // _context.Characters.Update(character);
            // await _context.SaveChangesAsync();

            serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);      
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }

    public class DataContext
    {
    }
}