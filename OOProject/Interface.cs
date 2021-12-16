using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    public interface IAppliance
    {
        Category Category { get; set; }
        Guid ItemId { get; set; }
        double Price { get; set; }

        Task<bool> CheckIfInStock();

    }

    class Interface
    {

    }
}
