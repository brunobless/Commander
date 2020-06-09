using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        // Constructor
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>(); // For GET
            CreateMap<CommandCreateDto, Command>(); // For POST
            CreateMap<CommandUpdateDto, Command>(); // For PUT
            CreateMap<Command, CommandUpdateDto>(); // For PATCH
        }
    }
}
