using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
         IEnumerable<Command> GetAllCommands();

         Command GetCommandById(int Id);
    }
}