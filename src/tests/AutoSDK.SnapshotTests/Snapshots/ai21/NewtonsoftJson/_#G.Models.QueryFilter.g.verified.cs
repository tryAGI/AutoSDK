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
        public global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? Value3 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? Value3 { get; }
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
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?(QueryFilter @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(
            global::G.ComparisonOperator? comparisonOperator,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? logicalOperator,
            global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>? value3
            )
        {
            ComparisonOperator = comparisonOperator;
            LogicalOperator = logicalOperator;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            LogicalOperator as object ??
            ComparisonOperator as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ComparisonOperator?.ToString() ??
            LogicalOperator?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComparisonOperator || IsLogicalOperator || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ComparisonOperator?, TResult>? comparisonOperator = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?, TResult>? logicalOperator = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?, TResult>? value3 = null,
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
            global::System.Action<global::G.ComparisonOperator?>? comparisonOperator = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?>? logicalOperator = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?>? value3 = null,
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
                ComparisonOperator,
                typeof(global::G.ComparisonOperator),
                LogicalOperator,
                typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>),
                Value3,
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
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::G.ComparisonOperator>?>.Default.Equals(Value3, other.Value3) 
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
