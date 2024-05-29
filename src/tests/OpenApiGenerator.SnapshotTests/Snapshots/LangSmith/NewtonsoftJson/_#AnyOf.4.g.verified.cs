//HintName: AnyOf.4.g.cs
using System.Linq;

#nullable enable

namespace System
{
    public readonly struct AnyOf<T1, T2, T3, T4> : global::System.IEquatable<AnyOf<T1, T2, T3, T4>>
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

        public static implicit operator AnyOf<T1, T2, T3, T4>(T1 value) => new AnyOf<T1, T2, T3, T4>(value);

        public static implicit operator T1?(AnyOf<T1, T2, T3, T4> @this) => @this.Value1;

        public AnyOf(T1? value)
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

        public static implicit operator AnyOf<T1, T2, T3, T4>(T2 value) => new AnyOf<T1, T2, T3, T4>(value);

        public static implicit operator T2?(AnyOf<T1, T2, T3, T4> @this) => @this.Value2;

        public AnyOf(T2? value)
        {
            Value2 = value;
        }

#if NET6_0_OR_GREATER
        public T3? Value3 { get; init; }
#else
        public T3? Value3 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4>(T3 value) => new AnyOf<T1, T2, T3, T4>(value);

        public static implicit operator T3?(AnyOf<T1, T2, T3, T4> @this) => @this.Value3;

        public AnyOf(T3? value)
        {
            Value3 = value;
        }

#if NET6_0_OR_GREATER
        public T4? Value4 { get; init; }
#else
        public T4? Value4 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        public static implicit operator AnyOf<T1, T2, T3, T4>(T4 value) => new AnyOf<T1, T2, T3, T4>(value);

        public static implicit operator T4?(AnyOf<T1, T2, T3, T4> @this) => @this.Value4;

        public AnyOf(T4? value)
        {
            Value4 = value;
        }

        public AnyOf(
            T1? value1,

            T2? value2,

            T3? value3,

            T4? value4
            )
        {
            Value1 = value1;

            Value2 = value2;

            Value3 = value3;

            Value4 = value4;
        }

        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4;
        }

        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(T1),

                Value2,
                typeof(T2),

                Value3,
                typeof(T3),

                Value4,
                typeof(T4),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        public bool Equals(AnyOf<T1, T2, T3, T4> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) &&

                global::System.Collections.Generic.EqualityComparer<T2?>.Default.Equals(Value2, other.Value2) &&

                global::System.Collections.Generic.EqualityComparer<T3?>.Default.Equals(Value3, other.Value3) &&

                global::System.Collections.Generic.EqualityComparer<T4?>.Default.Equals(Value4, other.Value4) 
                ;
        }

        public static bool operator ==(AnyOf<T1, T2, T3, T4> obj1, AnyOf<T1, T2, T3, T4> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnyOf<T1, T2, T3, T4>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(AnyOf<T1, T2, T3, T4> obj1, AnyOf<T1, T2, T3, T4> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is AnyOf<T1, T2, T3, T4> o && Equals(o);
        }
    }
}
