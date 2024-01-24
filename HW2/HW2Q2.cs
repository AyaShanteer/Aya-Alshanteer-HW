using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYA202111261HW2Q1
{
    using System;
    using System.Collections.Generic;

    namespace AYA202111261HW2Q1
    {
        // Class representing Customer
        public class Customer
        {
            // Attributes
            public string Name { get; set; }
            public string Address { get; set; }

            // One-to-Many relationship with Order
            public List<Order> Orders { get; set; }
        }

        // Class representing Order
        public class Order
        {
            // Attributes
            public DateTime Date { get; set; }
            public string Status { get; set; }

            // Functions
            public decimal CalcSubTotal() { /* Implementation */ return 0; }
            public decimal CalcTax() { /* Implementation */ return 0; }
            public decimal CalcTotal() { /* Implementation */ return 0; }
            public decimal CalcTotalWeight() { /* Implementation */ return 0; }

            // One-to-Many relationship with OrderDetail
            public List<OrderDetail> OrderDetails { get; set; }

            // Many-to-One relationship with Item
            public Item Item { get; set; }
        }

        // Class representing OrderDetail
        public class OrderDetail
        {
            // Attributes
            public int Quantity { get; set; }
            public string TaxStatus { get; set; }

            // Functions
            public decimal CalcSubTotal() { /* Implementation */ return 0; }
            public decimal CalcTax() { /* Implementation */ return 0; }
            public decimal CalcWeight() { /* Implementation */ return 0; }

            // Many-to-One relationship with Item
            public Item Item { get; set; }
        }

        // Class representing Item
        public class Item
        {
            // Attributes
            public decimal ShippingWeight { get; set; }
            public string Description { get; set; }

            // Functions
            public decimal PriceForQuantity
            {
                get
                { /* Implementation */ return 0; }
            }

            public decimal GetTax() { /* Implementation */ return 0; }
            public bool InStock() { /* Implementation */ return false; }

            // Many-to-One relationship with Order
            public Order Order { get; set; }
        }

        // Class representing Payment
        public class Payment
        {
            // Attributes
            public float Amount { get; set; }

            // Many-to-One relationship with Order
            public Order Order { get; set; }
        }

        // Class representing Cash
        public class Cash
        {
            // Attributes
            public float CashTendered { get; set; }

            // Many-to-One relationship with Payment
            public Payment Payment { get; set; }
        }

        // Class representing Check
        public class Check
        {
            // Attributes
            public string Name { get; set; }
            public string BankID { get; set; }

            // Functions
            public bool Authorized() { /* Implementation */ return false; }

            // Many-to-One relationship with Payment
            public Payment Payment { get; set; }
        }

        // Class representing Credit
        public class Credit
        {
            // Attributes
            public string Name { get; set; }
            public string Type { get; set; }
            public DateTime ExpDate { get; set; }

            // Functions
            public bool Authorized() { /* Implementation */ return false; }

            // Many-to-One relationship with Payment
            public Payment Payment { get; set; }
        }

        // Entry point of the program
        class Program
        {
            static void Main(string[] args)
            {
                // Your code here
            }
        }
    }

}
