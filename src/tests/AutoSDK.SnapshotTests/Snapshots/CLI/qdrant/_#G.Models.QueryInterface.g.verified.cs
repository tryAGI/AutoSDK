//HintName: G.Models.QueryInterface.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct QueryInterface : global::System.IEquatable<QueryInterface>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorInput? VectorInput { get; init; }
#else
        public global::G.VectorInput? VectorInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorInput))]
#endif
        public bool IsVectorInput => VectorInput != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Query? Query { get; init; }
#else
        public global::G.Query? Query { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Query))]
#endif
        public bool IsQuery => Query != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryInterface(global::G.VectorInput value) => new QueryInterface((global::G.VectorInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorInput?(QueryInterface @this) => @this.VectorInput;

        /// <summary>
        /// 
        /// </summary>
        public QueryInterface(global::G.VectorInput? value)
        {
            VectorInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryInterface(global::G.Query value) => new QueryInterface((global::G.Query?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Query?(QueryInterface @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public QueryInterface(global::G.Query? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryInterface(
            global::G.VectorInput? vectorInput,
            global::G.Query? query
            )
        {
            VectorInput = vectorInput;
            Query = query;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Query as object ??
            VectorInput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorInput?.ToString() ??
            Query?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorInput || IsQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VectorInput?, TResult>? vectorInput = null,
            global::System.Func<global::G.Query?, TResult>? query = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorInput && vectorInput != null)
            {
                return vectorInput(VectorInput!);
            }
            else if (IsQuery && query != null)
            {
                return query(Query!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VectorInput?>? vectorInput = null,
            global::System.Action<global::G.Query?>? query = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorInput)
            {
                vectorInput?.Invoke(VectorInput!);
            }
            else if (IsQuery)
            {
                query?.Invoke(Query!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorInput,
                typeof(global::G.VectorInput),
                Query,
                typeof(global::G.Query),
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
        public bool Equals(QueryInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.VectorInput?>.Default.Equals(VectorInput, other.VectorInput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Query?>.Default.Equals(Query, other.Query) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryInterface obj1, QueryInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryInterface obj1, QueryInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryInterface o && Equals(o);
        }
    }
}
