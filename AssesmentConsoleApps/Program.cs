using AssesmentConsoleApps;
using AssesmentConsoleApps.Interfaces;
using AssesmentConsoleApps.Services;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            ISlotService slot = new SlotServices();

            CarsRun carRun = new CarsRun(slot);

            int requestInit;
            string requestCar;

            //var argsString = Console.ReadLine();

            //args = argsString.Split();

            //for (int i = 0; i < args.Length; i++)
            //{
            //    if (args[i].ToLower().StartsWith("init"))
            //    {
            //        //plot init 4
            //        var str = args[2];
            //        requestInit = Convert.ToInt32(str);
            //        carRun.Init(requestInit);
            //        break;

            //    }
            //    else if (args[i].ToLower().StartsWith("add"))
            //    {
            //        //plot add redCar
            //        requestCar = args[2];
            //        carRun.Add(requestCar);

            //    }
            //    else if (args[i].ToLower().StartsWith("list"))
            //    {
            //        //plot list
            //        carRun.List();

            //    }
            //    else if (args[i].ToLower().StartsWith("exit"))
            //    {
            //        //plot exit redCar
            //        requestCar = args[2];
            //        carRun.Exit(requestCar);

            //    }
            //    else if (args[i].ToLower().StartsWith("stop"))
            //    {
            //        Environment.Exit(1);
            //    }
            //}

            bool isTrue = true;

            do
            {
                string param = Console.ReadLine();

                var strArray = param.Split();
                var menu = strArray[1];
                var data = "";
                for (int i = 2; i < strArray.Length; i++)
                {
                    if (strArray[i] != null)
                    {
                        data = strArray[i];
                    }
                }
                switch (menu)
                {
                    case "init":
                        if (data == "" || data == null)
                        {
                            break;
                        }
                        requestInit = Convert.ToInt32(data);
                        carRun.Init(requestInit);
                        break;
                    case "add":
                        data = strArray[2];
                        carRun.Add(data);
                        break;
                    case "list":
                        carRun.List();
                        break;
                    case "exit":
                        data = strArray[2];
                        carRun.Exit(data);
                        break;
                    case "stop":
                        isTrue = false;
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            } while (isTrue);


            //var init = 4;
            //var carName = "redCar";
            //var carName2 = "blueCar";
            //var carName3 = "blackCar";

            //carRun.Init(init);
            //carRun.Add(carName);
            //carRun.Add(carName2);
            //carRun.List();
            //carRun.Exit(carName);
            //carRun.Add(carName3);
            //carRun.List();
        }
    }
}
