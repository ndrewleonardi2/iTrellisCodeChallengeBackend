using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTrellis_CodeChallenge.Models
{
    public class Product
    {
        public Product(int productID, String productName, int inventoryQuantity, Boolean shipOnWeekends, int maxBusinessDaysToShip)
        {
            this.productID = productID;
            this.productName = productName;
            this.inventoryQuantity = inventoryQuantity;
            this.shipOnWeekends = shipOnWeekends;
            this.maxBusinessDaysToShip = maxBusinessDaysToShip;
        }
        public int productID { get; set; }
        public String productName { get; set; }
        public int inventoryQuantity { get; set; }
        public Boolean shipOnWeekends { get; set; }
        public int maxBusinessDaysToShip { get; set; }
    }
}
