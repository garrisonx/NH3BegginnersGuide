// -----------------------------------------------------------------------
// <copyright file="Product.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Chapter2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    


    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Product 
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Category Category { get; set; }
        public virtual Decimal UnitPrice { get; set; }
        public virtual int ReorderLevel { get; set; }
        public virtual bool IsDiscontinued { get; set; }
    }
}
