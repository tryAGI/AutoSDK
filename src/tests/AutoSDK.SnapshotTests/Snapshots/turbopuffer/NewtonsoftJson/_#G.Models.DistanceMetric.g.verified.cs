//HintName: G.Models.DistanceMetric.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A function used to calculate vector similarity.
    /// </summary>
    public readonly partial struct DistanceMetric : global::System.IEquatable<DistanceMetric>
    {
        /// <summary>
        /// Defined as `1 - cosine_similarity` and ranges from 0 to 2. Lower is better.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DistanceMetricVariant1 { get; init; }
#else
        public string? DistanceMetricVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistanceMetricVariant1))]
#endif
        public bool IsDistanceMetricVariant1 => DistanceMetricVariant1 != null;

        /// <summary>
        /// Defined as `sum((x - y)^2)`. Lower is better.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DistanceMetricVariant2 { get; init; }
#else
        public string? DistanceMetricVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistanceMetricVariant2))]
#endif
        public bool IsDistanceMetricVariant2 => DistanceMetricVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DistanceMetric(string value) => new DistanceMetric((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DistanceMetric @this) => @this.DistanceMetricVariant1;

        /// <summary>
        /// 
        /// </summary>
        public DistanceMetric(string? value)
        {
            DistanceMetricVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DistanceMetric(
            string? distanceMetricVariant1,
            string? distanceMetricVariant2
            )
        {
            DistanceMetricVariant1 = distanceMetricVariant1;
            DistanceMetricVariant2 = distanceMetricVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DistanceMetricVariant2 as object ??
            DistanceMetricVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DistanceMetricVariant1?.ToString() ??
            DistanceMetricVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDistanceMetricVariant1 || IsDistanceMetricVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? distanceMetricVariant1 = null,
            global::System.Func<string?, TResult>? distanceMetricVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDistanceMetricVariant1 && distanceMetricVariant1 != null)
            {
                return distanceMetricVariant1(DistanceMetricVariant1!);
            }
            else if (IsDistanceMetricVariant2 && distanceMetricVariant2 != null)
            {
                return distanceMetricVariant2(DistanceMetricVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? distanceMetricVariant1 = null,
            global::System.Action<string?>? distanceMetricVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDistanceMetricVariant1)
            {
                distanceMetricVariant1?.Invoke(DistanceMetricVariant1!);
            }
            else if (IsDistanceMetricVariant2)
            {
                distanceMetricVariant2?.Invoke(DistanceMetricVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DistanceMetricVariant1,
                typeof(string),
                DistanceMetricVariant2,
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
        public bool Equals(DistanceMetric other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DistanceMetricVariant1, other.DistanceMetricVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DistanceMetricVariant2, other.DistanceMetricVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DistanceMetric obj1, DistanceMetric obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DistanceMetric>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DistanceMetric obj1, DistanceMetric obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DistanceMetric o && Equals(o);
        }
    }
}
