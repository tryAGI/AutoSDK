//HintName: G.Models.Query.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Query : global::System.IEquatable<Query>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NearestQuery? Nearest { get; init; }
#else
        public global::G.NearestQuery? Nearest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Nearest))]
#endif
        public bool IsNearest => Nearest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RecommendQuery? Recommend { get; init; }
#else
        public global::G.RecommendQuery? Recommend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Recommend))]
#endif
        public bool IsRecommend => Recommend != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DiscoverQuery? Discover { get; init; }
#else
        public global::G.DiscoverQuery? Discover { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Discover))]
#endif
        public bool IsDiscover => Discover != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContextQuery? Context { get; init; }
#else
        public global::G.ContextQuery? Context { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Context))]
#endif
        public bool IsContext => Context != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OrderByQuery? OrderBy { get; init; }
#else
        public global::G.OrderByQuery? OrderBy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrderBy))]
#endif
        public bool IsOrderBy => OrderBy != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FusionQuery? Fusion { get; init; }
#else
        public global::G.FusionQuery? Fusion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Fusion))]
#endif
        public bool IsFusion => Fusion != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RrfQuery? Rrf { get; init; }
#else
        public global::G.RrfQuery? Rrf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rrf))]
#endif
        public bool IsRrf => Rrf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FormulaQuery? Formula { get; init; }
#else
        public global::G.FormulaQuery? Formula { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Formula))]
#endif
        public bool IsFormula => Formula != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SampleQuery? Sample { get; init; }
#else
        public global::G.SampleQuery? Sample { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sample))]
#endif
        public bool IsSample => Sample != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RelevanceFeedbackQuery? RelevanceFeedback { get; init; }
#else
        public global::G.RelevanceFeedbackQuery? RelevanceFeedback { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RelevanceFeedback))]
#endif
        public bool IsRelevanceFeedback => RelevanceFeedback != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.NearestQuery value) => new Query((global::G.NearestQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NearestQuery?(Query @this) => @this.Nearest;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.NearestQuery? value)
        {
            Nearest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.RecommendQuery value) => new Query((global::G.RecommendQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RecommendQuery?(Query @this) => @this.Recommend;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.RecommendQuery? value)
        {
            Recommend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.DiscoverQuery value) => new Query((global::G.DiscoverQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DiscoverQuery?(Query @this) => @this.Discover;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.DiscoverQuery? value)
        {
            Discover = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.ContextQuery value) => new Query((global::G.ContextQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContextQuery?(Query @this) => @this.Context;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.ContextQuery? value)
        {
            Context = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.OrderByQuery value) => new Query((global::G.OrderByQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OrderByQuery?(Query @this) => @this.OrderBy;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.OrderByQuery? value)
        {
            OrderBy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.FusionQuery value) => new Query((global::G.FusionQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FusionQuery?(Query @this) => @this.Fusion;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.FusionQuery? value)
        {
            Fusion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.RrfQuery value) => new Query((global::G.RrfQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RrfQuery?(Query @this) => @this.Rrf;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.RrfQuery? value)
        {
            Rrf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.FormulaQuery value) => new Query((global::G.FormulaQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FormulaQuery?(Query @this) => @this.Formula;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.FormulaQuery? value)
        {
            Formula = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.SampleQuery value) => new Query((global::G.SampleQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SampleQuery?(Query @this) => @this.Sample;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.SampleQuery? value)
        {
            Sample = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Query(global::G.RelevanceFeedbackQuery value) => new Query((global::G.RelevanceFeedbackQuery?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RelevanceFeedbackQuery?(Query @this) => @this.RelevanceFeedback;

        /// <summary>
        /// 
        /// </summary>
        public Query(global::G.RelevanceFeedbackQuery? value)
        {
            RelevanceFeedback = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Query(
            global::G.NearestQuery? nearest,
            global::G.RecommendQuery? recommend,
            global::G.DiscoverQuery? discover,
            global::G.ContextQuery? context,
            global::G.OrderByQuery? orderBy,
            global::G.FusionQuery? fusion,
            global::G.RrfQuery? rrf,
            global::G.FormulaQuery? formula,
            global::G.SampleQuery? sample,
            global::G.RelevanceFeedbackQuery? relevanceFeedback
            )
        {
            Nearest = nearest;
            Recommend = recommend;
            Discover = discover;
            Context = context;
            OrderBy = orderBy;
            Fusion = fusion;
            Rrf = rrf;
            Formula = formula;
            Sample = sample;
            RelevanceFeedback = relevanceFeedback;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RelevanceFeedback as object ??
            Sample as object ??
            Formula as object ??
            Rrf as object ??
            Fusion as object ??
            OrderBy as object ??
            Context as object ??
            Discover as object ??
            Recommend as object ??
            Nearest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Nearest?.ToString() ??
            Recommend?.ToString() ??
            Discover?.ToString() ??
            Context?.ToString() ??
            OrderBy?.ToString() ??
            Fusion?.ToString() ??
            Rrf?.ToString() ??
            Formula?.ToString() ??
            Sample?.ToString() ??
            RelevanceFeedback?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNearest || IsRecommend || IsDiscover || IsContext || IsOrderBy || IsFusion || IsRrf || IsFormula || IsSample || IsRelevanceFeedback;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NearestQuery?, TResult>? nearest = null,
            global::System.Func<global::G.RecommendQuery?, TResult>? recommend = null,
            global::System.Func<global::G.DiscoverQuery?, TResult>? discover = null,
            global::System.Func<global::G.ContextQuery?, TResult>? context = null,
            global::System.Func<global::G.OrderByQuery?, TResult>? orderBy = null,
            global::System.Func<global::G.FusionQuery?, TResult>? fusion = null,
            global::System.Func<global::G.RrfQuery?, TResult>? rrf = null,
            global::System.Func<global::G.FormulaQuery?, TResult>? formula = null,
            global::System.Func<global::G.SampleQuery?, TResult>? sample = null,
            global::System.Func<global::G.RelevanceFeedbackQuery?, TResult>? relevanceFeedback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNearest && nearest != null)
            {
                return nearest(Nearest!);
            }
            else if (IsRecommend && recommend != null)
            {
                return recommend(Recommend!);
            }
            else if (IsDiscover && discover != null)
            {
                return discover(Discover!);
            }
            else if (IsContext && context != null)
            {
                return context(Context!);
            }
            else if (IsOrderBy && orderBy != null)
            {
                return orderBy(OrderBy!);
            }
            else if (IsFusion && fusion != null)
            {
                return fusion(Fusion!);
            }
            else if (IsRrf && rrf != null)
            {
                return rrf(Rrf!);
            }
            else if (IsFormula && formula != null)
            {
                return formula(Formula!);
            }
            else if (IsSample && sample != null)
            {
                return sample(Sample!);
            }
            else if (IsRelevanceFeedback && relevanceFeedback != null)
            {
                return relevanceFeedback(RelevanceFeedback!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NearestQuery?>? nearest = null,
            global::System.Action<global::G.RecommendQuery?>? recommend = null,
            global::System.Action<global::G.DiscoverQuery?>? discover = null,
            global::System.Action<global::G.ContextQuery?>? context = null,
            global::System.Action<global::G.OrderByQuery?>? orderBy = null,
            global::System.Action<global::G.FusionQuery?>? fusion = null,
            global::System.Action<global::G.RrfQuery?>? rrf = null,
            global::System.Action<global::G.FormulaQuery?>? formula = null,
            global::System.Action<global::G.SampleQuery?>? sample = null,
            global::System.Action<global::G.RelevanceFeedbackQuery?>? relevanceFeedback = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNearest)
            {
                nearest?.Invoke(Nearest!);
            }
            else if (IsRecommend)
            {
                recommend?.Invoke(Recommend!);
            }
            else if (IsDiscover)
            {
                discover?.Invoke(Discover!);
            }
            else if (IsContext)
            {
                context?.Invoke(Context!);
            }
            else if (IsOrderBy)
            {
                orderBy?.Invoke(OrderBy!);
            }
            else if (IsFusion)
            {
                fusion?.Invoke(Fusion!);
            }
            else if (IsRrf)
            {
                rrf?.Invoke(Rrf!);
            }
            else if (IsFormula)
            {
                formula?.Invoke(Formula!);
            }
            else if (IsSample)
            {
                sample?.Invoke(Sample!);
            }
            else if (IsRelevanceFeedback)
            {
                relevanceFeedback?.Invoke(RelevanceFeedback!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Nearest,
                typeof(global::G.NearestQuery),
                Recommend,
                typeof(global::G.RecommendQuery),
                Discover,
                typeof(global::G.DiscoverQuery),
                Context,
                typeof(global::G.ContextQuery),
                OrderBy,
                typeof(global::G.OrderByQuery),
                Fusion,
                typeof(global::G.FusionQuery),
                Rrf,
                typeof(global::G.RrfQuery),
                Formula,
                typeof(global::G.FormulaQuery),
                Sample,
                typeof(global::G.SampleQuery),
                RelevanceFeedback,
                typeof(global::G.RelevanceFeedbackQuery),
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
        public bool Equals(Query other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NearestQuery?>.Default.Equals(Nearest, other.Nearest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RecommendQuery?>.Default.Equals(Recommend, other.Recommend) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DiscoverQuery?>.Default.Equals(Discover, other.Discover) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContextQuery?>.Default.Equals(Context, other.Context) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OrderByQuery?>.Default.Equals(OrderBy, other.OrderBy) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FusionQuery?>.Default.Equals(Fusion, other.Fusion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RrfQuery?>.Default.Equals(Rrf, other.Rrf) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FormulaQuery?>.Default.Equals(Formula, other.Formula) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SampleQuery?>.Default.Equals(Sample, other.Sample) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RelevanceFeedbackQuery?>.Default.Equals(RelevanceFeedback, other.RelevanceFeedback) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Query obj1, Query obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Query>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Query obj1, Query obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Query o && Equals(o);
        }
    }
}
