//HintName: AnyOf.1.g.cs
using System.Linq;

#nullable enable

namespace System
{
    public readonly struct AnyOf<T1> : global::System.IEquatable<AnyOf<T1>>
    {
#if NET6_0_OR_GREATER
        public T1? Value1 { get; init; }
#else
        public T1? Value1 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        public static implicit operator AnyOf<T1>(T1 value) => new AnyOf<T1>(value);

        public static implicit operator T1?(AnyOf<T1> @this) => @this.Value1;

        public AnyOf(T1? value)
        {
            Value1 = value;
        }

        public bool Validate()
        {
            return IsValue1;
        }

        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(T1),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        public bool Equals(AnyOf<T1> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) 
                ;
        }

        public static bool operator ==(AnyOf<T1> obj1, AnyOf<T1> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnyOf<T1>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(AnyOf<T1> obj1, AnyOf<T1> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is AnyOf<T1> o && Equals(o);
        }
    }
}
