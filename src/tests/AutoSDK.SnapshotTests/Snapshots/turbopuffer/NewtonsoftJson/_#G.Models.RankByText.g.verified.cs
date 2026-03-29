//HintName: G.Models.RankByText.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RankByText : global::System.IEquatable<RankByText>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value1 { get; init; }
#else
        public byte[]? Value1 { get; }
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
#if NET6_0_OR_GREATER
        public byte[]? Value2 { get; init; }
#else
        public byte[]? Value2 { get; }
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
#if NET6_0_OR_GREATER
        public byte[]? Value3 { get; init; }
#else
        public byte[]? Value3 { get; }
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
#if NET6_0_OR_GREATER
        public byte[]? Value4 { get; init; }
#else
        public byte[]? Value4 { get; }
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
#if NET6_0_OR_GREATER
        public byte[]? Value5 { get; init; }
#else
        public byte[]? Value5 { get; }
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
#if NET6_0_OR_GREATER
        public byte[]? Value6 { get; init; }
#else
        public byte[]? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value7 { get; init; }
#else
        public byte[]? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value8 { get; init; }
#else
        public byte[]? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Filter? Value9 { get; init; }
#else
        public global::G.Filter? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value10 { get; init; }
#else
        public byte[]? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value11 { get; init; }
#else
        public byte[]? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value12 { get; init; }
#else
        public byte[]? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? Value13 { get; init; }
#else
        public byte[]? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RankByText(byte[] value) => new RankByText((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(RankByText @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RankByText(byte[]? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RankByText(global::G.Filter value) => new RankByText((global::G.Filter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Filter?(RankByText @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RankByText(global::G.Filter? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RankByText(
            byte[]? value1,
            byte[]? value2,
            byte[]? value3,
            byte[]? value4,
            byte[]? value5,
            byte[]? value6,
            byte[]? value7,
            byte[]? value8,
            global::G.Filter? value9,
            byte[]? value10,
            byte[]? value11,
            byte[]? value12,
            byte[]? value13
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
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() ??
            Value11?.ToString() ??
            Value12?.ToString() ??
            Value13?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8 || IsValue9 || IsValue10 || IsValue11 || IsValue12 || IsValue13;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? value1 = null,
            global::System.Func<byte[]?, TResult>? value2 = null,
            global::System.Func<byte[]?, TResult>? value3 = null,
            global::System.Func<byte[]?, TResult>? value4 = null,
            global::System.Func<byte[]?, TResult>? value5 = null,
            global::System.Func<byte[]?, TResult>? value6 = null,
            global::System.Func<byte[]?, TResult>? value7 = null,
            global::System.Func<byte[]?, TResult>? value8 = null,
            global::System.Func<global::G.Filter?, TResult>? value9 = null,
            global::System.Func<byte[]?, TResult>? value10 = null,
            global::System.Func<byte[]?, TResult>? value11 = null,
            global::System.Func<byte[]?, TResult>? value12 = null,
            global::System.Func<byte[]?, TResult>? value13 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? value1 = null,
            global::System.Action<byte[]?>? value2 = null,
            global::System.Action<byte[]?>? value3 = null,
            global::System.Action<byte[]?>? value4 = null,
            global::System.Action<byte[]?>? value5 = null,
            global::System.Action<byte[]?>? value6 = null,
            global::System.Action<byte[]?>? value7 = null,
            global::System.Action<byte[]?>? value8 = null,
            global::System.Action<global::G.Filter?>? value9 = null,
            global::System.Action<byte[]?>? value10 = null,
            global::System.Action<byte[]?>? value11 = null,
            global::System.Action<byte[]?>? value12 = null,
            global::System.Action<byte[]?>? value13 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(byte[]),
                Value2,
                typeof(byte[]),
                Value3,
                typeof(byte[]),
                Value4,
                typeof(byte[]),
                Value5,
                typeof(byte[]),
                Value6,
                typeof(byte[]),
                Value7,
                typeof(byte[]),
                Value8,
                typeof(byte[]),
                Value9,
                typeof(global::G.Filter),
                Value10,
                typeof(byte[]),
                Value11,
                typeof(byte[]),
                Value12,
                typeof(byte[]),
                Value13,
                typeof(byte[]),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RankByText other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Filter?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value13, other.Value13) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RankByText obj1, RankByText obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RankByText>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RankByText obj1, RankByText obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RankByText o && Equals(o);
        }
    }
}
