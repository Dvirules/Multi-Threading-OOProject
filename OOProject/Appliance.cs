using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace OOProject
{
    /// <summary>
    /// The possibilities of the categories
    /// </summary>>
    public enum Category
    {
        Kitchen, Bathroom, Livingroom
    }


    /// <summary>
    /// The parent class of all appliances. Serves as a Template Method DP
    /// </summary>>
    public abstract class Appliance : IAppliance
    {

        public static List<Appliance> Stock = new List<Appliance>();          //A singleton DP, a composite DP and a COR DP
        public Guid ItemId { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Appliance(double price, Category category)
        {
            this.ItemId = Guid.NewGuid();
            this.Price = price;
            this.Category = category;
        }
        public async Task<bool> CheckIfInStock()
        {
            await Task.Delay(2000);      //Mocking a long operation for the async task
            Console.WriteLine($"This is a test message to check the async operation. This appliance's price is {this.Price}");
            return Stock.Contains(this);
        }

        public override string ToString()
        {
            return $"This appliance is a {this.Category} appliance, and its ID is {this.ItemId}";
        }
    }
}
