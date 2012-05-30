// -----------------------------------------------------------------------
// <copyright file="LineItem.cs" company="Microsoft">
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
    public class LineItem:Entity<LineItem>
    {
        public Order Order          { get; private set; }
        public Product Product      { get; private set; }
        public int Quantity         { get; private set; }
        public Decimal UnitPrice    { get; private set; }
        public Decimal Disccount    { get; private set; }

        public LineItem(Order order, int quantity, Product product)
        {
            Order = order;
            quantity = quantity;
            Product = product;
            UnitPrice = product.UnitPrice;

            if (quantity >= 10)
                Disccount = 0.5m;
        }
    }
}
