using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOProject
{
    /// <summary>
    /// Implementation of the LivingroomAppliance
    /// </summary>>
    public class LivingroomAppliance : Appliance
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public LivingroomAppliance(double price, Category category, int weight, int height) : base(price, category)
        {
            this.Category = Category.Livingroom;
            this.Weight = weight;
            this.Height = height;
            Stock.Add(this);
        }
    }
}
