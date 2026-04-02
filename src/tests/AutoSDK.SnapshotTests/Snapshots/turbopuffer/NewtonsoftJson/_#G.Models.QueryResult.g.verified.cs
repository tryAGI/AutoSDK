//HintName: G.Models.QueryResult.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The result of a query.
    /// </summary>
    public readonly partial struct QueryResult : global::System.IEquatable<QueryResult>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SingleQueryResult? Single { get; init; }
#else
        public global::G.SingleQueryResult? Single { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Single))]
#endif
        public bool IsSingle => Single != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.QueryResultVariant2? QueryResultVariant2 { get; init; }
#else
        public global::G.QueryResultVariant2? QueryResultVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryResultVariant2))]
#endif
        public bool IsQueryResultVariant2 => QueryResultVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryResult(global::G.SingleQueryResult value) => new QueryResult((global::G.SingleQueryResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SingleQueryResult?(QueryResult @this) => @this.Single;

        /// <summary>
        /// 
        /// </summary>
        public QueryResult(global::G.SingleQueryResult? value)
        {
            Single = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryResult(global::G.QueryResultVariant2 value) => new QueryResult((global::G.QueryResultVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.QueryResultVariant2?(QueryResult @this) => @this.QueryResultVariant2;

        /// <summary>
        /// 
        /// </summary>
        public QueryResult(global::G.QueryResultVariant2? value)
        {
            QueryResultVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryResult(
            global::G.SingleQueryResult? single,
            global::G.QueryResultVariant2? queryResultVariant2
            )
        {
            Single = single;
            QueryResultVariant2 = queryResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QueryResultVariant2 as object ??
            Single as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Single?.ToString() ??
            QueryResultVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSingle && IsQueryResultVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SingleQueryResult?, TResult>? single = null,
            global::System.Func<global::G.QueryResultVariant2?, TResult>? queryResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingle && single != null)
            {
                return single(Single!);
            }
            else if (IsQueryResultVariant2 && queryResultVariant2 != null)
            {
                return queryResultVariant2(QueryResultVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SingleQueryResult?>? single = null,
            global::System.Action<global::G.QueryResultVariant2?>? queryResultVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSingle)
            {
                single?.Invoke(Single!);
            }
            else if (IsQueryResultVariant2)
            {
                queryResultVariant2?.Invoke(QueryResultVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Single,
                typeof(global::G.SingleQueryResult),
                QueryResultVariant2,
                typeof(global::G.QueryResultVariant2),
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
        public bool Equals(QueryResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SingleQueryResult?>.Default.Equals(Single, other.Single) &&
                global::System.Collections.Generic.EqualityComparer<global::G.QueryResultVariant2?>.Default.Equals(QueryResultVariant2, other.QueryResultVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryResult obj1, QueryResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryResult obj1, QueryResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryResult o && Equals(o);
        }
    }
}
