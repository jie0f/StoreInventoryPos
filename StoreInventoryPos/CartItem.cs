using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventoryPos
{
    public class CartItem
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double Total => Price * Quantity;
    }
}
