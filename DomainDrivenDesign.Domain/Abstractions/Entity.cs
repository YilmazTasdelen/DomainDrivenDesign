using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domain.Abstractions
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Guid Id { get; init; }

        public Entity(Guid id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
                return Id.GetHashCode();
        }

        public bool Equals(Entity? other)
        {
            if (other == null || (other is not Entity entity))
                return false;

            if (Object.ReferenceEquals(this, other))
                return true;

            if (this.GetType() != other.GetType())
                return false;

            return entity.Id == this.Id;
        }
    }
}
