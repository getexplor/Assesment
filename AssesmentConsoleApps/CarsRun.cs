using AssesmentConsoleApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentConsoleApps
{
    public class CarsRun
    {
        ISlotService _slotService;

        public CarsRun(ISlotService slotService)
        {
            _slotService = slotService;
        }

        public void Init(int slot)
        {
            Console.WriteLine(_slotService.Init(slot));
        }

        public void Add(string carName)
        {
            Console.WriteLine(_slotService.Add(carName));
        }

        public void List()
        {
            Console.WriteLine(_slotService.List());
        }

        public void Exit(string carName)
        {
            Console.WriteLine(_slotService.Exit(carName));
        }

    }
}
