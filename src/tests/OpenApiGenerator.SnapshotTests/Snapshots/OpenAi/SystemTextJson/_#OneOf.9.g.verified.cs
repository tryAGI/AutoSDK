//HintName: OneOf.9.g.cs
using System.Linq;

#nullable enable

namespace System
{
    public readonly struct OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> : global::System.IEquatable<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
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

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T1?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value1;

        public OneOf(T1? value)
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

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T2?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value2;

        public OneOf(T2? value)
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

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T3?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value3;

        public OneOf(T3? value)
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

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T4?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value4;

        public OneOf(T4? value)
        {
            Value4 = value;
        }

#if NET6_0_OR_GREATER
        public T5? Value5 { get; init; }
#else
        public T5? Value5 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T5?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value5;

        public OneOf(T5? value)
        {
            Value5 = value;
        }

#if NET6_0_OR_GREATER
        public T6? Value6 { get; init; }
#else
        public T6? Value6 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T6?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value6;

        public OneOf(T6? value)
        {
            Value6 = value;
        }

#if NET6_0_OR_GREATER
        public T7? Value7 { get; init; }
#else
        public T7? Value7 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T7?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value7;

        public OneOf(T7? value)
        {
            Value7 = value;
        }

#if NET6_0_OR_GREATER
        public T8? Value8 { get; init; }
#else
        public T8? Value8 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T8?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value8;

        public OneOf(T8? value)
        {
            Value8 = value;
        }

#if NET6_0_OR_GREATER
        public T9? Value9 { get; init; }
#else
        public T9? Value9 { get; }
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        public static implicit operator OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value) => new OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);

        public static implicit operator T9?(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> @this) => @this.Value9;

        public OneOf(T9? value)
        {
            Value9 = value;
        }

        public OneOf(
            T1? value1,

            T2? value2,

            T3? value3,

            T4? value4,

            T5? value5,

            T6? value6,

            T7? value7,

            T8? value8,

            T9? value9
            )
        {
            Value1 = value1;

            Value2 = value2;

            Value3 = value3;

            Value4 = value4;

            Value5 = value5;

            Value6 = value6;

            Value7 = value7;

            Value8 = value8;

            Value9 = value9;
        }

        public bool Validate()
        {
            return !IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && !IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && !IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && !IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && !IsValue5 && IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && !IsValue6 && IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && !IsValue7 && IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && !IsValue8 && IsValue9 || IsValue1 && IsValue2 && IsValue3 && IsValue4 && IsValue5 && IsValue6 && IsValue7 && IsValue8 && !IsValue9;
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

                Value5,
                typeof(T5),

                Value6,
                typeof(T6),

                Value7,
                typeof(T7),

                Value8,
                typeof(T8),

                Value9,
                typeof(T9),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        public bool Equals(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<T1?>.Default.Equals(Value1, other.Value1) &&

                global::System.Collections.Generic.EqualityComparer<T2?>.Default.Equals(Value2, other.Value2) &&

                global::System.Collections.Generic.EqualityComparer<T3?>.Default.Equals(Value3, other.Value3) &&

                global::System.Collections.Generic.EqualityComparer<T4?>.Default.Equals(Value4, other.Value4) &&

                global::System.Collections.Generic.EqualityComparer<T5?>.Default.Equals(Value5, other.Value5) &&

                global::System.Collections.Generic.EqualityComparer<T6?>.Default.Equals(Value6, other.Value6) &&

                global::System.Collections.Generic.EqualityComparer<T7?>.Default.Equals(Value7, other.Value7) &&

                global::System.Collections.Generic.EqualityComparer<T8?>.Default.Equals(Value8, other.Value8) &&

                global::System.Collections.Generic.EqualityComparer<T9?>.Default.Equals(Value9, other.Value9) 
                ;
        }

        public static bool operator ==(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> obj1, OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> obj1, OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> o && Equals(o);
        }
    }
}
