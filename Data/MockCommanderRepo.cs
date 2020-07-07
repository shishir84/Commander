using System.Collections.Generic;
using Commander.Data;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var lstCommand = new List<Command>
            {
                new Command{Id=1, HowTo="Boil Egg", Line="Egg", Platform="Gas"},
                new Command{Id=2, HowTo="Boil Potato", Line="Potato", Platform="Coil"},
                new Command{Id=3, HowTo="Boil Tomato", Line="Tomato", Platform="Induction"}
            };

            return lstCommand;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id=1, HowTo="Boil Egg", Line="Egg", Platform="Gas"};
        }
    }
}