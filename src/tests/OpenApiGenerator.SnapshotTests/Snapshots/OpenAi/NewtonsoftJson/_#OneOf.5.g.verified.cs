//HintName: OneOf.5.g.cs
using System.Linq;

#nullable enable

namespace System
{
    /// <summary>
    /// 
    /// </summary>
    public readonly struct OneOf<T1, T2, T3, T4, T5> : global::System.IEquatable<OneOf<T1, T2, T3, T4, T5>>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T1? Value1 { get; init; }
#else
        public T1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5>(T1 value) => new OneOf<T1, T2, T3, T4, T5>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T1?(OneOf<T1, T2, T3, T4, T5> @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T2? Value2 { get; init; }
#else
        public T2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5>(T2 value) => new OneOf<T1, T2, T3, T4, T5>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T2?(OneOf<T1, T2, T3, T4, T5> @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T3? Value3 { get; init; }
#else
        public T3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5>(T3 value) => new OneOf<T1, T2, T3, T4, T5>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T3?(OneOf<T1, T2, T3, T4, T5> @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T4? Value4 { get; init; }
#else
        public T4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5>(T4 value) => new OneOf<T1, T2, T3, T4, T5>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T4?(OneOf<T1, T2, T3, T4, T5> @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public T5? Value5 { get; init; }
#else
        public T5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OneOf<T1, T2, T3, T4, T5>(T5 value) => new OneOf<T1, T2, T3, T4, T5>(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator T5?(OneOf<T1, T2, T3, T4, T5> @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public OneOf(T5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OneOf(
            T1? value1,
            T2? value2,
            T3? value3,
            T4? value4,
            T5? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
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
                Value5,
                typeof(T5),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OneOf<T1, T2, T3, T4, T5> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<T2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<T3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<T4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<T5?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OneOf<T1, T2, T3, T4, T5> obj1, OneOf<T1, T2, T3, T4, T5> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OneOf<T1, T2, T3, T4, T5>>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OneOf<T1, T2, T3, T4, T5> obj1, OneOf<T1, T2, T3, T4, T5> obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OneOf<T1, T2, T3, T4, T5> o && Equals(o);
        }
    }
}
