//HintName: G.Models.RankByAttributeOrder.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RankByAttributeOrder : global::System.IEquatable<RankByAttributeOrder>
    {
        /// <summary>
        /// Ascending order.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RankByAttributeOrderVariant1 { get; init; }
#else
        public string? RankByAttributeOrderVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RankByAttributeOrderVariant1))]
#endif
        public bool IsRankByAttributeOrderVariant1 => RankByAttributeOrderVariant1 != null;

        /// <summary>
        /// Descending order.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RankByAttributeOrderVariant2 { get; init; }
#else
        public string? RankByAttributeOrderVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RankByAttributeOrderVariant2))]
#endif
        public bool IsRankByAttributeOrderVariant2 => RankByAttributeOrderVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RankByAttributeOrder(string value) => new RankByAttributeOrder((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(RankByAttributeOrder @this) => @this.RankByAttributeOrderVariant1;

        /// <summary>
        /// 
        /// </summary>
        public RankByAttributeOrder(string? value)
        {
            RankByAttributeOrderVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RankByAttributeOrder(
            string? rankByAttributeOrderVariant1,
            string? rankByAttributeOrderVariant2
            )
        {
            RankByAttributeOrderVariant1 = rankByAttributeOrderVariant1;
            RankByAttributeOrderVariant2 = rankByAttributeOrderVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RankByAttributeOrderVariant2 as object ??
            RankByAttributeOrderVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RankByAttributeOrderVariant1?.ToString() ??
            RankByAttributeOrderVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRankByAttributeOrderVariant1 || IsRankByAttributeOrderVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? rankByAttributeOrderVariant1 = null,
            global::System.Func<string?, TResult>? rankByAttributeOrderVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRankByAttributeOrderVariant1 && rankByAttributeOrderVariant1 != null)
            {
                return rankByAttributeOrderVariant1(RankByAttributeOrderVariant1!);
            }
            else if (IsRankByAttributeOrderVariant2 && rankByAttributeOrderVariant2 != null)
            {
                return rankByAttributeOrderVariant2(RankByAttributeOrderVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? rankByAttributeOrderVariant1 = null,
            global::System.Action<string?>? rankByAttributeOrderVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRankByAttributeOrderVariant1)
            {
                rankByAttributeOrderVariant1?.Invoke(RankByAttributeOrderVariant1!);
            }
            else if (IsRankByAttributeOrderVariant2)
            {
                rankByAttributeOrderVariant2?.Invoke(RankByAttributeOrderVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RankByAttributeOrderVariant1,
                typeof(string),
                RankByAttributeOrderVariant2,
                typeof(string),
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
        public bool Equals(RankByAttributeOrder other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RankByAttributeOrderVariant1, other.RankByAttributeOrderVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RankByAttributeOrderVariant2, other.RankByAttributeOrderVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RankByAttributeOrder obj1, RankByAttributeOrder obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RankByAttributeOrder>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RankByAttributeOrder obj1, RankByAttributeOrder obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RankByAttributeOrder o && Equals(o);
        }
    }
}
