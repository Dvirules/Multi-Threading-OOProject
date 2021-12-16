using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace OOProject
{
    class Program
    {
        const int NumOfThreads = 2;

        /// <summary>
        /// This method receives an hetrogeneous list of appliances and checks whether or not each one of them is in stock. Returns a boolean array.
        /// </summary>>
        public static bool[] ProvideIfInStock(List<Appliance> appliances)
        {
            bool[] Stock = new bool[appliances.Count];
            Parallel.For(0, appliances.Count, new ParallelOptions { MaxDegreeOfParallelism = NumOfThreads }, delegate (int j)
           {
               Stock[j] = appliances[j].CheckIfInStock().Result;
           });
            return Stock;
        }


        /// <summary>
        /// Implementation of the Deserializer method, which creates an appliance from a Json string
        /// </summary>>
        public static Appliance Deserializer(string jsonstring, Category category)
        {
            switch (category)
            {
                case Category.Kitchen:
                    return JsonSerializer.Deserialize<KitchenAppliance>(jsonstring);

                case Category.Bathroom:
                    return JsonSerializer.Deserialize<BathroomAppliance>(jsonstring);

                case Category.Livingroom:
                    return JsonSerializer.Deserialize<LivingroomAppliance>(jsonstring);

                default:
                    throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Tests to verify that everyhting functions well in the main code
        /// </summary>>
        static void Main(string[] args)
        {
            ThreadPool.SetMaxThreads(NumOfThreads, NumOfThreads);
            var a = ApplianceFactory.CreateKitchenAppliance(1000, 100, true);
            var a2 = ApplianceFactory.CreateBathroomAppliance(1500, 60, false);
            var a3 = ApplianceFactory.CreateLivingroomAppliance(1700, 80, 20);
            Console.WriteLine(a);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(Deserializer(@"{""Price"": 7654.5,""Voltage"": 120,""IsElectric"": true}", Category.Bathroom));
            Console.WriteLine(Deserializer(@"{""Price"": 4578,""Size"": 10,""IsWaterResistant"": false}", Category.Kitchen));
            Console.WriteLine(Deserializer(@"{""Price"": 2900,""Weight"": 90,""Height"": 12}", Category.Livingroom));
            Console.WriteLine();


            bool[] b = ProvideIfInStock(new List<Appliance>{ ApplianceFactory.CreateKitchenAppliance(7523.5, 135, true),
            ApplianceFactory.CreateBathroomAppliance(5000, 12, false), ApplianceFactory.CreateLivingroomAppliance(9999, 50, 2),
                ApplianceFactory.CreateKitchenAppliance(27, 1335, false) });
            Console.WriteLine();
            foreach (var v in b)
                Console.WriteLine(v);
        }
    }
}