using AssesmentConsoleApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentConsoleApps.Interfaces
{
    public interface ISlotService
    {
        string Init(int init);
        string Add(string carName);
        string Exit(string carName);
        string List();
    }
}
