//HintName: G.Models.ClusterStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Information about current cluster status and structure
    /// </summary>
    public readonly partial struct ClusterStatus : global::System.IEquatable<ClusterStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClusterStatusVariant1? ClusterStatusVariant1 { get; init; }
#else
        public global::G.ClusterStatusVariant1? ClusterStatusVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClusterStatusVariant1))]
#endif
        public bool IsClusterStatusVariant1 => ClusterStatusVariant1 != null;

        /// <summary>
        /// Description of enabled cluster
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClusterStatusVariant2? ClusterStatusVariant2 { get; init; }
#else
        public global::G.ClusterStatusVariant2? ClusterStatusVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClusterStatusVariant2))]
#endif
        public bool IsClusterStatusVariant2 => ClusterStatusVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterStatus(global::G.ClusterStatusVariant1 value) => new ClusterStatus((global::G.ClusterStatusVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClusterStatusVariant1?(ClusterStatus @this) => @this.ClusterStatusVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ClusterStatus(global::G.ClusterStatusVariant1? value)
        {
            ClusterStatusVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ClusterStatus(global::G.ClusterStatusVariant2 value) => new ClusterStatus((global::G.ClusterStatusVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClusterStatusVariant2?(ClusterStatus @this) => @this.ClusterStatusVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ClusterStatus(global::G.ClusterStatusVariant2? value)
        {
            ClusterStatusVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ClusterStatus(
            global::G.ClusterStatusVariant1? clusterStatusVariant1,
            global::G.ClusterStatusVariant2? clusterStatusVariant2
            )
        {
            ClusterStatusVariant1 = clusterStatusVariant1;
            ClusterStatusVariant2 = clusterStatusVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClusterStatusVariant2 as object ??
            ClusterStatusVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ClusterStatusVariant1?.ToString() ??
            ClusterStatusVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClusterStatusVariant1 && !IsClusterStatusVariant2 || !IsClusterStatusVariant1 && IsClusterStatusVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ClusterStatusVariant1?, TResult>? clusterStatusVariant1 = null,
            global::System.Func<global::G.ClusterStatusVariant2?, TResult>? clusterStatusVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClusterStatusVariant1 && clusterStatusVariant1 != null)
            {
                return clusterStatusVariant1(ClusterStatusVariant1!);
            }
            else if (IsClusterStatusVariant2 && clusterStatusVariant2 != null)
            {
                return clusterStatusVariant2(ClusterStatusVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ClusterStatusVariant1?>? clusterStatusVariant1 = null,
            global::System.Action<global::G.ClusterStatusVariant2?>? clusterStatusVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClusterStatusVariant1)
            {
                clusterStatusVariant1?.Invoke(ClusterStatusVariant1!);
            }
            else if (IsClusterStatusVariant2)
            {
                clusterStatusVariant2?.Invoke(ClusterStatusVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ClusterStatusVariant1,
                typeof(global::G.ClusterStatusVariant1),
                ClusterStatusVariant2,
                typeof(global::G.ClusterStatusVariant2),
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
        public bool Equals(ClusterStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ClusterStatusVariant1?>.Default.Equals(ClusterStatusVariant1, other.ClusterStatusVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClusterStatusVariant2?>.Default.Equals(ClusterStatusVariant2, other.ClusterStatusVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ClusterStatus obj1, ClusterStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClusterStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ClusterStatus obj1, ClusterStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClusterStatus o && Equals(o);
        }
    }
}
