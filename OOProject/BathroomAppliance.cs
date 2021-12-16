using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOProject
{
    /// <summary>
    /// Implementation of the BathroomAppliance
    /// </summary>>
    public class BathroomAppliance : Appliance
    {
        public int Voltage { get; set; }
        public bool IsElectric { get; set; }
        public BathroomAppliance(double price, Category category, int voltage, bool iselectric) : base(price, category)
        {
            this.Category = Category.Bathroom;
            this.Voltage = voltage;
            this.IsElectric = iselectric;
            Stock.Add(this);
        }
    }
}
