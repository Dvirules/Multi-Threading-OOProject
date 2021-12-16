using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOProject
{
    /// <summary>
    /// Implementation of the KitchenAppliance
    /// </summary>>
    public class KitchenAppliance : Appliance
    {
        public int Size { get; set; }
        public bool IsWaterResistant { get; set; }
        public KitchenAppliance(double price, Category category, int size, bool iswaterresistant) : base(price, category)
        {
            this.Category = category;
            this.Size = size;
            this.IsWaterResistant = iswaterresistant;
            Stock.Add(this);
        }
    }
}
