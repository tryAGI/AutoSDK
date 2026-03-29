//HintName: G.Models.AggregateBy.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An aggregate function to compute over all documents in the namespace.
    /// </summary>
    public readonly partial struct AggregateBy : global::System.IEquatable<AggregateBy>
    {
        /// <summary>
        /// Count documents.
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
        /// Sum the values of the given attribute.
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
        /// Count documents with a non-null value for the given attribute.
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
        public static implicit operator AggregateBy(byte[] value) => new AggregateBy((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(AggregateBy @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AggregateBy(byte[]? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AggregateBy(
            byte[]? value1,
            byte[]? value2,
            byte[]? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? value1 = null,
            global::System.Func<byte[]?, TResult>? value2 = null,
            global::System.Func<byte[]?, TResult>? value3 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? value1 = null,
            global::System.Action<byte[]?>? value2 = null,
            global::System.Action<byte[]?>? value3 = null,
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
        public bool Equals(AggregateBy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AggregateBy obj1, AggregateBy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AggregateBy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AggregateBy obj1, AggregateBy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AggregateBy o && Equals(o);
        }
    }
}
