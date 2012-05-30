// -----------------------------------------------------------------------
// <copyright file="Address.cs" company="Microsoft">
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
    public class Address
    {
        public string City      { get; private set; }
        public string Line1     { get; private set; }
        public string Line2     { get; private set; }
        public string State     { get; private set; }
        public string ZipCode   { get; private set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = Line1.GetHashCode();
                result = (result * 397) ^ (Line2 != null ? Line2.GetHashCode() : 0);
                result = (result * 397) ^ ZipCode.GetHashCode();
                result = (result * 397) ^ City.GetHashCode();
                result = (result * 397) ^ State.GetHashCode();

                return result;
            }
            //return base.GetHashCode();
        }

        public bool Equals(Address other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.City, City) &&
                   Equals(other.Line1, Line1) &&
                   Equals(other.Line2, Line2) &&
                   Equals(other.State, State) &&
                   Equals(other.ZipCode, ZipCode);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Address);
        }

    }
}
