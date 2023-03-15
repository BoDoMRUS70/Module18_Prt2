using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_Prt2
{
    class Sender
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public async Task Run()
        {
            await _command.ExecuteAsync();
        }
    }
}