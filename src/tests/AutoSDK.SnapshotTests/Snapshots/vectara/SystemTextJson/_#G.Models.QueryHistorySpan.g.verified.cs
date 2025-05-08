//HintName: G.Models.QueryHistorySpan.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Portion of the query history.
    /// </summary>
    public readonly partial struct QueryHistorySpan : global::System.IEquatable<QueryHistorySpan>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.QueryHistorySpanDiscriminatorType? Type { get; }

        /// <summary>
        /// During the query pipeline, the query may be rephrased to better suit the corpus.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RephraseSpan? Rephrase { get; init; }
#else
        public global::G.RephraseSpan? Rephrase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rephrase))]
#endif
        public bool IsRephrase => Rephrase != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::G.RephraseSpan value) => new QueryHistorySpan((global::G.RephraseSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RephraseSpan?(QueryHistorySpan @this) => @this.Rephrase;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::G.RephraseSpan? value)
        {
            Rephrase = value;
        }

        /// <summary>
        /// The search portion of the query pipeline. This occurs before any reranking span.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SearchSpan? Search { get; init; }
#else
        public global::G.SearchSpan? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::G.SearchSpan value) => new QueryHistorySpan((global::G.SearchSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchSpan?(QueryHistorySpan @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::G.SearchSpan? value)
        {
            Search = value;
        }

        /// <summary>
        /// The reranking of the search result.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RerankSpan? Rerank { get; init; }
#else
        public global::G.RerankSpan? Rerank { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rerank))]
#endif
        public bool IsRerank => Rerank != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::G.RerankSpan value) => new QueryHistorySpan((global::G.RerankSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RerankSpan?(QueryHistorySpan @this) => @this.Rerank;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::G.RerankSpan? value)
        {
            Rerank = value;
        }

        /// <summary>
        /// The generation by an LLM.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerationSpan? Generation { get; init; }
#else
        public global::G.GenerationSpan? Generation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generation))]
#endif
        public bool IsGeneration => Generation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::G.GenerationSpan value) => new QueryHistorySpan((global::G.GenerationSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerationSpan?(QueryHistorySpan @this) => @this.Generation;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::G.GenerationSpan? value)
        {
            Generation = value;
        }

        /// <summary>
        /// The factual consistency of the generation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FactualConsistencyScoreSpan? Fcs { get; init; }
#else
        public global::G.FactualConsistencyScoreSpan? Fcs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fcs))]
#endif
        public bool IsFcs => Fcs != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::G.FactualConsistencyScoreSpan value) => new QueryHistorySpan((global::G.FactualConsistencyScoreSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FactualConsistencyScoreSpan?(QueryHistorySpan @this) => @this.Fcs;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::G.FactualConsistencyScoreSpan? value)
        {
            Fcs = value;
        }

        /// <summary>
        /// Provides detailed information about a rewritten query generated for a specific corpus<br/>
        /// when intelligent query rewriting is enabled.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RewrittenQuerySpan? RewrittenQuery { get; init; }
#else
        public global::G.RewrittenQuerySpan? RewrittenQuery { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RewrittenQuery))]
#endif
        public bool IsRewrittenQuery => RewrittenQuery != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator QueryHistorySpan(global::G.RewrittenQuerySpan value) => new QueryHistorySpan((global::G.RewrittenQuerySpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RewrittenQuerySpan?(QueryHistorySpan @this) => @this.RewrittenQuery;

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(global::G.RewrittenQuerySpan? value)
        {
            RewrittenQuery = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryHistorySpan(
            global::G.QueryHistorySpanDiscriminatorType? type,
            global::G.RephraseSpan? rephrase,
            global::G.SearchSpan? search,
            global::G.RerankSpan? rerank,
            global::G.GenerationSpan? generation,
            global::G.FactualConsistencyScoreSpan? fcs,
            global::G.RewrittenQuerySpan? rewrittenQuery
            )
        {
            Type = type;

            Rephrase = rephrase;
            Search = search;
            Rerank = rerank;
            Generation = generation;
            Fcs = fcs;
            RewrittenQuery = rewrittenQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RewrittenQuery as object ??
            Fcs as object ??
            Generation as object ??
            Rerank as object ??
            Search as object ??
            Rephrase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Rephrase?.ToString() ??
            Search?.ToString() ??
            Rerank?.ToString() ??
            Generation?.ToString() ??
            Fcs?.ToString() ??
            RewrittenQuery?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRephrase && !IsSearch && !IsRerank && !IsGeneration && !IsFcs && !IsRewrittenQuery || !IsRephrase && IsSearch && !IsRerank && !IsGeneration && !IsFcs && !IsRewrittenQuery || !IsRephrase && !IsSearch && IsRerank && !IsGeneration && !IsFcs && !IsRewrittenQuery || !IsRephrase && !IsSearch && !IsRerank && IsGeneration && !IsFcs && !IsRewrittenQuery || !IsRephrase && !IsSearch && !IsRerank && !IsGeneration && IsFcs && !IsRewrittenQuery || !IsRephrase && !IsSearch && !IsRerank && !IsGeneration && !IsFcs && IsRewrittenQuery;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RephraseSpan?, TResult>? rephrase = null,
            global::System.Func<global::G.SearchSpan?, TResult>? search = null,
            global::System.Func<global::G.RerankSpan?, TResult>? rerank = null,
            global::System.Func<global::G.GenerationSpan?, TResult>? generation = null,
            global::System.Func<global::G.FactualConsistencyScoreSpan?, TResult>? fcs = null,
            global::System.Func<global::G.RewrittenQuerySpan?, TResult>? rewrittenQuery = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRephrase && rephrase != null)
            {
                return rephrase(Rephrase!);
            }
            else if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsRerank && rerank != null)
            {
                return rerank(Rerank!);
            }
            else if (IsGeneration && generation != null)
            {
                return generation(Generation!);
            }
            else if (IsFcs && fcs != null)
            {
                return fcs(Fcs!);
            }
            else if (IsRewrittenQuery && rewrittenQuery != null)
            {
                return rewrittenQuery(RewrittenQuery!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RephraseSpan?>? rephrase = null,
            global::System.Action<global::G.SearchSpan?>? search = null,
            global::System.Action<global::G.RerankSpan?>? rerank = null,
            global::System.Action<global::G.GenerationSpan?>? generation = null,
            global::System.Action<global::G.FactualConsistencyScoreSpan?>? fcs = null,
            global::System.Action<global::G.RewrittenQuerySpan?>? rewrittenQuery = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRephrase)
            {
                rephrase?.Invoke(Rephrase!);
            }
            else if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsRerank)
            {
                rerank?.Invoke(Rerank!);
            }
            else if (IsGeneration)
            {
                generation?.Invoke(Generation!);
            }
            else if (IsFcs)
            {
                fcs?.Invoke(Fcs!);
            }
            else if (IsRewrittenQuery)
            {
                rewrittenQuery?.Invoke(RewrittenQuery!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Rephrase,
                typeof(global::G.RephraseSpan),
                Search,
                typeof(global::G.SearchSpan),
                Rerank,
                typeof(global::G.RerankSpan),
                Generation,
                typeof(global::G.GenerationSpan),
                Fcs,
                typeof(global::G.FactualConsistencyScoreSpan),
                RewrittenQuery,
                typeof(global::G.RewrittenQuerySpan),
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
        public bool Equals(QueryHistorySpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RephraseSpan?>.Default.Equals(Rephrase, other.Rephrase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SearchSpan?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RerankSpan?>.Default.Equals(Rerank, other.Rerank) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerationSpan?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FactualConsistencyScoreSpan?>.Default.Equals(Fcs, other.Fcs) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RewrittenQuerySpan?>.Default.Equals(RewrittenQuery, other.RewrittenQuery) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryHistorySpan obj1, QueryHistorySpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryHistorySpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryHistorySpan obj1, QueryHistorySpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryHistorySpan o && Equals(o);
        }
    }
}
