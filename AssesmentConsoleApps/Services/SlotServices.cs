using AssesmentConsoleApps.Interfaces;
using AssesmentConsoleApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentConsoleApps.Services
{
    public class SlotServices : ISlotService
    {
        private readonly List<Cars> listCar;

        public SlotServices()
        {
            listCar = new List<Cars>();
        }

        public string Add(string carName)
        {
            var checkCar = listCar.Where(x => x.Name == carName).FirstOrDefault();
            if (checkCar != null)
            {
                return "Car is already";
            }

            var icar = listCar.Find(x => x.Name == String.Empty);

            if (icar == null)
            {
                return "No empty slot";
            }

            icar.Name = carName;

            return icar.Name + " in slot " + icar.Slot;

        }

        public string Init(int init)
        {
                        
            var carSlot = new Cars();
            var slot = carSlot.Slot;
            var indexSlot = 1;

            for (int i = 0; i < init; i++)
            {
                slot = indexSlot;
                listCar.Add(new Cars
                {
                    Slot = slot,
                });

                indexSlot++;
                
            }

            return listCar.Count.ToString() + " slot preseved";
        }

        public string Exit(string carName)
        {
            var cars = listCar.Where(x => x.Name == carName).FirstOrDefault();

            cars.Name = String.Empty;

            return carName + " Exit";
        }

        public string List()
        {
            var stringOutput = new List<string>();

            foreach (var item in listCar)
            {
                if (item.Name == null )
                {
                    item.Name = string.Empty;
                }

                stringOutput.Add("Slot " + item.Slot + " for " + (item.Name == "" || item.Name == null ? "empty" : item.Name) + "\n");
            }

            return String.Join("\n", stringOutput);
        }
    }
}
