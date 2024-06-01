//HintName: AllOf.2.g.cs
using System.Linq;

#nullable enable

namespace System
{
    public readonly struct AllOf<T1, T2> : global::System.IEquatable<AllOf<T1, T2>>
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

        public static implicit operator AllOf<T1, T2>(T1 value) => new AllOf<T1, T2>(value);

        public static implicit operator T1?(AllOf<T1, T2> @this) => @this.Value1;

        public AllOf(T1? value)
        {
            Value1 = value;
        }

#if NET6_0_OR_GREATER
        public T2? Value2 { get; init; }
#else
        public T2? Value2 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        public static implicit operator AllOf<T1, T2>(T2 value) => new AllOf<T1, T2>(value);

        public static implicit operator T2?(AllOf<T1, T2> @this) => @this.Value2;

        public AllOf(T2? value)
        {
            Value2 = value;
        }

        public AllOf(
            T1? value1,

            T2? value2
            )
        {
            Value1 = value1;

            Value2 = value2;
        }

        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(T1),

                Value2,
                typeof(T2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        public bool Equals(AllOf<T1, T2> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) &&

                global::System.Collections.Generic.EqualityComparer<T2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        public static bool operator ==(AllOf<T1, T2> obj1, AllOf<T1, T2> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AllOf<T1, T2>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(AllOf<T1, T2> obj1, AllOf<T1, T2> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is AllOf<T1, T2> o && Equals(o);
        }
    }
}
