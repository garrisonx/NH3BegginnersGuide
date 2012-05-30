// -----------------------------------------------------------------------
// <copyright file="Customer.cs" company="Microsoft">
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
    public class Customer :Entity<Customer>
    {
        public string CustomerIdentifier { get; private set; }
        public Name CustomerName { get; private set; }
        public readonly List<Order> orders;
        public IEnumerable<Order> Orders { get { return orders; } }
        public Address Address { get; private set; }

        public void ChangeCustomerName(string firstName, string middleName, string lastName) {
            CustomerName = new Name(firstName, middleName, lastName);
        }

        public void PlaceOrder(LineInfo[] lineInfos, IDictionary<int,Product> products) 
        {
            var order = new Order(this);
            foreach (var linfinfo in lineInfos)
            {
                var product = products[linfinfo.ProductId];
                order.AddProduct(this, product, linfinfo.Quantity);
            }
            orders.Add(order);
        }
    }
}
