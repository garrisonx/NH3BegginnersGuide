// -----------------------------------------------------------------------
// <copyright file="Order.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace OrderingSystem.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Order:Entity<Order>
    {
        public DateTime OrderDate { get;private set; }
        public Decimal OrderTotal { get; private set; }
        public Customer Customer { get; private set; }
        public Employee Reference { get; private set; }

        public readonly List<LineItem> lineItems;
        public IEnumerable<LineItem> LineItems { get { return lineItems; } }

        public Order(Customer customer)
        {
            lineItems = new List<LineItem>();
            Customer = customer;
            OrderDate = DateTime.Now;
        }

        internal void AddProduct(Domain.Customer customer, Product product, int quantity)
        {
            Customer = customer;
            lineItems.Add(new LineItem(this,quantity,product));

        }
    }
}
