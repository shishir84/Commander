using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController: ControllerBase
    {
        private readonly MockCommanderRepo _mockRepo = new MockCommanderRepo();
        
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commands = _mockRepo.GetAllCommands();

            return Ok(commands);
        }

        [HttpGet("{Id}")]
        public ActionResult <Command> GetCommandById(int Id)
        {
            var command = _mockRepo.GetCommandById(Id);

            return Ok(command);
        }
    }
}