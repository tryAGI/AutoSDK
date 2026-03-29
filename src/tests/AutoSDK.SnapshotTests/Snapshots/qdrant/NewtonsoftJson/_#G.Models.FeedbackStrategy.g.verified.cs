//HintName: G.Models.FeedbackStrategy.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FeedbackStrategy : global::System.IEquatable<FeedbackStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NaiveFeedbackStrategy? Naive { get; init; }
#else
        public global::G.NaiveFeedbackStrategy? Naive { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Naive))]
#endif
        public bool IsNaive => Naive != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FeedbackStrategy(global::G.NaiveFeedbackStrategy value) => new FeedbackStrategy((global::G.NaiveFeedbackStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NaiveFeedbackStrategy?(FeedbackStrategy @this) => @this.Naive;

        /// <summary>
        /// 
        /// </summary>
        public FeedbackStrategy(global::G.NaiveFeedbackStrategy? value)
        {
            Naive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Naive as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Naive?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNaive;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NaiveFeedbackStrategy?, TResult>? naive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNaive && naive != null)
            {
                return naive(Naive!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NaiveFeedbackStrategy?>? naive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNaive)
            {
                naive?.Invoke(Naive!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Naive,
                typeof(global::G.NaiveFeedbackStrategy),
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
        public bool Equals(FeedbackStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NaiveFeedbackStrategy?>.Default.Equals(Naive, other.Naive) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FeedbackStrategy obj1, FeedbackStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FeedbackStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FeedbackStrategy obj1, FeedbackStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FeedbackStrategy o && Equals(o);
        }
    }
}
