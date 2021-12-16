using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOProject
{
    /// <summary>
    /// The Factory class, responsible for calling all appliances constructors. Serves as the Factory DP
    /// </summary>>
    static class ApplianceFactory
    {
        public static KitchenAppliance CreateKitchenAppliance(double Price, int Size, bool IsWaterResistant)
        {
            return new KitchenAppliance(Price, Category.Kitchen, Size, IsWaterResistant);
        }
        public static BathroomAppliance CreateBathroomAppliance(double Price, int Voltage, bool IsElectric)
        {
            return new BathroomAppliance(Price, Category.Bathroom, Voltage, IsElectric);
        }
        public static LivingroomAppliance CreateLivingroomAppliance(double Price, int Weight, int Height)
        {
            return new LivingroomAppliance(Price, Category.Livingroom, Weight, Height);
        }
    }
}
