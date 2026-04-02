//HintName: G.Models.QueryFilter.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct QueryFilter : global::System.IEquatable<QueryFilter>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComparisonOperator? ComparisonOperator { get; init; }
#else
        public global::G.ComparisonOperator? ComparisonOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComparisonOperator))]
#endif
        public bool IsComparisonOperator => ComparisonOperator != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? LogicalOperator { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? LogicalOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LogicalOperator))]
#endif
        public bool IsLogicalOperator => LogicalOperator != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? QueryFilterVariant3 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? QueryFilterVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryFilterVariant3))]
#endif
        public bool IsQueryFilterVariant3 => QueryFilterVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryFilter(global::G.ComparisonOperator value) => new QueryFilter((global::G.ComparisonOperator?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComparisonOperator?(QueryFilter @this) => @this.ComparisonOperator;

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(global::G.ComparisonOperator? value)
        {
            ComparisonOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryFilter(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>> value) => new QueryFilter((global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?(QueryFilter @this) => @this.LogicalOperator;

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? value)
        {
            LogicalOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryFilter(global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator> value) => new QueryFilter((global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?(QueryFilter @this) => @this.QueryFilterVariant3;

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? value)
        {
            QueryFilterVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(
            global::G.ComparisonOperator? comparisonOperator,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? logicalOperator,
            global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? queryFilterVariant3
            )
        {
            ComparisonOperator = comparisonOperator;
            LogicalOperator = logicalOperator;
            QueryFilterVariant3 = queryFilterVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QueryFilterVariant3 as object ??
            LogicalOperator as object ??
            ComparisonOperator as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ComparisonOperator?.ToString() ??
            LogicalOperator?.ToString() ??
            QueryFilterVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComparisonOperator || IsLogicalOperator || IsQueryFilterVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ComparisonOperator?, TResult>? comparisonOperator = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?, TResult>? logicalOperator = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?, TResult>? queryFilterVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonOperator && comparisonOperator != null)
            {
                return comparisonOperator(ComparisonOperator!);
            }
            else if (IsLogicalOperator && logicalOperator != null)
            {
                return logicalOperator(LogicalOperator!);
            }
            else if (IsQueryFilterVariant3 && queryFilterVariant3 != null)
            {
                return queryFilterVariant3(QueryFilterVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ComparisonOperator?>? comparisonOperator = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?>? logicalOperator = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?>? queryFilterVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonOperator)
            {
                comparisonOperator?.Invoke(ComparisonOperator!);
            }
            else if (IsLogicalOperator)
            {
                logicalOperator?.Invoke(LogicalOperator!);
            }
            else if (IsQueryFilterVariant3)
            {
                queryFilterVariant3?.Invoke(QueryFilterVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComparisonOperator,
                typeof(global::G.ComparisonOperator),
                LogicalOperator,
                typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>),
                QueryFilterVariant3,
                typeof(global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>),
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
        public bool Equals(QueryFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ComparisonOperator?>.Default.Equals(ComparisonOperator, other.ComparisonOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?>.Default.Equals(LogicalOperator, other.LogicalOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?>.Default.Equals(QueryFilterVariant3, other.QueryFilterVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryFilter obj1, QueryFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryFilter obj1, QueryFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryFilter o && Equals(o);
        }
    }
}
