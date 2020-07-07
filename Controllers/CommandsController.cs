using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.DTOs;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController: ControllerBase
    {
        private readonly ICommanderRepo _mockRepo;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo mockRepo, IMapper mapper)
        {
            _mockRepo = mockRepo;
            _mapper = mapper;
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commands = _mockRepo.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }

        [HttpGet("{Id}")]
        public ActionResult <Command> GetCommandById(int Id)
        {
            var command = _mockRepo.GetCommandById(Id);

            return Ok(_mapper.Map<CommandReadDto>(command));
        }
    }
}