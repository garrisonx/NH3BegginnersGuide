// -----------------------------------------------------------------------
// <copyright file="Name.cs" company="Microsoft">
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
    public class Name
    {        
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public Name()
        {

        }
        public Name(string firstName, string middleName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("FirstName must be defined");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("FirstName must be defined");

            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public override int GetHashCode()
        {
            unchecked {
                var result = FirstName.GetHashCode();
                result = (result * 397 ) ^ (MiddleName!=null?MiddleName.GetHashCode():0);
                result = (result * 397 ) ^ LastName.GetHashCode();
                return result;
            }
            //return base.GetHashCode();
        }

        public bool Equals(Name other) 
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.FirstName, FirstName) && Equals(other.MiddleName, MiddleName) && Equals(other.LastName, LastName);
        }

        
    }
}
