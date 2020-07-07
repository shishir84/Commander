using AutoMapper;
using Commander.DTOs;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandProfile:Profile
    {
        public CommandProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}