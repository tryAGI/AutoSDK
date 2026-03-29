//HintName: G.Models.RankBy.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RankBy : global::System.IEquatable<RankBy>
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
        public global::G.RankByText? Value3 { get; init; }
#else
        public global::G.RankByText? Value3 { get; }
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
        /// Order by multiple attributes. Results are sorted by the first attribute, then by the second attribute for ties, and so on.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<byte[]>? Value5 { get; init; }
#else
        public global::System.Collections.Generic.IList<byte[]>? Value5 { get; }
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
        public static implicit operator RankBy(byte[] value) => new RankBy((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(RankBy @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RankBy(byte[]? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RankBy(global::G.RankByText value) => new RankBy((global::G.RankByText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RankByText?(RankBy @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RankBy(global::G.RankByText? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RankBy(
            byte[]? value1,
            byte[]? value2,
            global::G.RankByText? value3,
            byte[]? value4,
            global::System.Collections.Generic.IList<byte[]>? value5
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
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? value1 = null,
            global::System.Func<byte[]?, TResult>? value2 = null,
            global::System.Func<global::G.RankByText?, TResult>? value3 = null,
            global::System.Func<byte[]?, TResult>? value4 = null,
            global::System.Func<global::System.Collections.Generic.IList<byte[]>?, TResult>? value5 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? value1 = null,
            global::System.Action<byte[]?>? value2 = null,
            global::System.Action<global::G.RankByText?>? value3 = null,
            global::System.Action<byte[]?>? value4 = null,
            global::System.Action<global::System.Collections.Generic.IList<byte[]>?>? value5 = null,
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
                typeof(global::G.RankByText),
                Value4,
                typeof(byte[]),
                Value5,
                typeof(global::System.Collections.Generic.IList<byte[]>),
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
        public bool Equals(RankBy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RankByText?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<byte[]>?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RankBy obj1, RankBy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RankBy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RankBy obj1, RankBy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RankBy o && Equals(o);
        }
    }
}
