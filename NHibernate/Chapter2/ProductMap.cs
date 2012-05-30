// -----------------------------------------------------------------------
// <copyright file="ProductMap.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
using FluentNHibernate.Mapping;
namespace Chapter2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            Map(x => x.UnitPrice);
            Map(x => x.ReorderLevel);
            Map(x => x.IsDiscontinued);
            References(x => x.Category);
        }
    }
}
