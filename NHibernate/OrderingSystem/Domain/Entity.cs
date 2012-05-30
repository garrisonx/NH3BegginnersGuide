// -----------------------------------------------------------------------
// <copyright file="Entity.cs" company="Microsoft">
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
    public abstract class Entity<T> where T: Entity<T>
    {
        public Guid ID { get; private set; }
        private int? oldHashCode;

        public override int GetHashCode()
        {
            
            if (oldHashCode.HasValue)
                return oldHashCode.Value;

            var thisIsNew = Equals(ID, Guid.Empty);

            if (thisIsNew) 
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }
            return ID.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as T;
            if (other == null) return false;
            var thisIsNew = Equals(ID, Guid.Empty);
            var otherIsNew = Equals(other.ID, Guid.Empty);

            if (thisIsNew && otherIsNew)
                return ReferenceEquals(this, other);

            return ID.Equals(other.ID);
        }

        public static bool operator ==(Entity<T> lhs, Entity<T> rhs) {
            return Equals(lhs, rhs);
        }
        public static bool operator !=(Entity<T> lhs, Entity<T> rhs)
        {
            return !Equals(lhs, rhs);
        }
    }

    
}
