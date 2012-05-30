// -----------------------------------------------------------------------
// <copyright file="Employee.cs" company="Microsoft">
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
    public class Employee:Entity<Employee>
    {
        public Name EmployeeName { get; private set; }
    }
}
