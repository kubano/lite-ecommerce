using System;
using System.Text.Json;

namespace Common
{
    public abstract class Entity<TKey> : ControlFields, IEntity<TKey>, IEquatable<Entity<TKey>>
    {
        public TKey Id { get; set; }
        public string DomainKey { get; set; }

        protected Entity()
        {
            DomainKey = Guid.NewGuid().ToString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Entity<TKey>);
        }

        public virtual bool Equals(Entity<TKey> other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (!IsTransient(this) &&
                !IsTransient(other) &&
                Equals(Id, other.Id))
            {
                var otherType = other.GetUnproxiedType();
                var thisType = GetUnproxiedType();
                return thisType.IsAssignableFrom(otherType) ||
                        otherType.IsAssignableFrom(thisType);
            }

            return false;
        }

        private static bool IsTransient(Entity<TKey> obj)
        {
            return obj != null && Equals(obj.Id, default(TKey));
        }

        private Type GetUnproxiedType()
        {
            return GetType();
        }

        public override string ToString() => JsonSerializer.Serialize(this);

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(Entity<TKey> x, Entity<TKey> y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(Entity<TKey> x, Entity<TKey> y)
        {
            return !(x == y);
        }
    }

}