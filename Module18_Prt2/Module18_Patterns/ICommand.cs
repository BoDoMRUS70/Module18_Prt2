using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_Prt2
{
    interface ICommand
    {
        Task ExecuteAsync();
    }
}