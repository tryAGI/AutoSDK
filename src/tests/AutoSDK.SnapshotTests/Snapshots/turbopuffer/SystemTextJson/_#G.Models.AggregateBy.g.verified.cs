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
        public byte[]? AggregateByVariant1 { get; init; }
#else
        public byte[]? AggregateByVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AggregateByVariant1))]
#endif
        public bool IsAggregateByVariant1 => AggregateByVariant1 != null;

        /// <summary>
        /// Sum the values of the given attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? AggregateByVariant2 { get; init; }
#else
        public byte[]? AggregateByVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AggregateByVariant2))]
#endif
        public bool IsAggregateByVariant2 => AggregateByVariant2 != null;

        /// <summary>
        /// Count documents with a non-null value for the given attribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public byte[]? AggregateByVariant3 { get; init; }
#else
        public byte[]? AggregateByVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AggregateByVariant3))]
#endif
        public bool IsAggregateByVariant3 => AggregateByVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AggregateBy(byte[] value) => new AggregateBy((byte[]?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator byte[]?(AggregateBy @this) => @this.AggregateByVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AggregateBy(byte[]? value)
        {
            AggregateByVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AggregateBy(
            byte[]? aggregateByVariant1,
            byte[]? aggregateByVariant2,
            byte[]? aggregateByVariant3
            )
        {
            AggregateByVariant1 = aggregateByVariant1;
            AggregateByVariant2 = aggregateByVariant2;
            AggregateByVariant3 = aggregateByVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AggregateByVariant3 as object ??
            AggregateByVariant2 as object ??
            AggregateByVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AggregateByVariant1?.ToString() ??
            AggregateByVariant2?.ToString() ??
            AggregateByVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAggregateByVariant1 || IsAggregateByVariant2 || IsAggregateByVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<byte[]?, TResult>? aggregateByVariant1 = null,
            global::System.Func<byte[]?, TResult>? aggregateByVariant2 = null,
            global::System.Func<byte[]?, TResult>? aggregateByVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAggregateByVariant1 && aggregateByVariant1 != null)
            {
                return aggregateByVariant1(AggregateByVariant1!);
            }
            else if (IsAggregateByVariant2 && aggregateByVariant2 != null)
            {
                return aggregateByVariant2(AggregateByVariant2!);
            }
            else if (IsAggregateByVariant3 && aggregateByVariant3 != null)
            {
                return aggregateByVariant3(AggregateByVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<byte[]?>? aggregateByVariant1 = null,
            global::System.Action<byte[]?>? aggregateByVariant2 = null,
            global::System.Action<byte[]?>? aggregateByVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAggregateByVariant1)
            {
                aggregateByVariant1?.Invoke(AggregateByVariant1!);
            }
            else if (IsAggregateByVariant2)
            {
                aggregateByVariant2?.Invoke(AggregateByVariant2!);
            }
            else if (IsAggregateByVariant3)
            {
                aggregateByVariant3?.Invoke(AggregateByVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AggregateByVariant1,
                typeof(byte[]),
                AggregateByVariant2,
                typeof(byte[]),
                AggregateByVariant3,
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
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(AggregateByVariant1, other.AggregateByVariant1) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(AggregateByVariant2, other.AggregateByVariant2) &&
                global::System.Collections.Generic.EqualityComparer<byte[]?>.Default.Equals(AggregateByVariant3, other.AggregateByVariant3) 
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
