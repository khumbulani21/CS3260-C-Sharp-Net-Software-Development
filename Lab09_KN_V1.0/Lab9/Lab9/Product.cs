using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Product
    {
        private int productID;
        private string productName;
        private string category;
        private decimal unitPrice;
        private int unitsInStock;


        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    override
        public string ToString()
        {
            return "ID :"+ProductID + " "  + Category + " " + UnitPrice + " Unit in stock " + UnitsInStock;
        }

    }
}
