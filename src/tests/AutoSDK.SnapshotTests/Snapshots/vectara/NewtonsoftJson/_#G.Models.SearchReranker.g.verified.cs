//HintName: G.Models.SearchReranker.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Rerank results of the search. Rerankers are very powerful tools to better order search results.<br/>
    /// By default the search will use the most powerful reranker available to the customer's plan.<br/>
    /// To disable reranking set the reranker `type` to `"none"`.
    /// </summary>
    public readonly partial struct SearchReranker : global::System.IEquatable<SearchReranker>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.SearchRerankerDiscriminatorType? Type { get; }

        /// <summary>
        /// Reranker that is specific to the customer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomerSpecificReranker? CustomerReranker { get; init; }
#else
        public global::G.CustomerSpecificReranker? CustomerReranker { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerReranker))]
#endif
        public bool IsCustomerReranker => CustomerReranker != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::G.CustomerSpecificReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomerSpecificReranker?(SearchReranker @this) => @this.CustomerReranker;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::G.CustomerSpecificReranker? value)
        {
            CustomerReranker = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UserFunctionReranker? Userfn { get; init; }
#else
        public global::G.UserFunctionReranker? Userfn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Userfn))]
#endif
        public bool IsUserfn => Userfn != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::G.UserFunctionReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UserFunctionReranker?(SearchReranker @this) => @this.Userfn;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::G.UserFunctionReranker? value)
        {
            Userfn = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MMRReranker? Mmr { get; init; }
#else
        public global::G.MMRReranker? Mmr { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mmr))]
#endif
        public bool IsMmr => Mmr != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::G.MMRReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MMRReranker?(SearchReranker @this) => @this.Mmr;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::G.MMRReranker? value)
        {
            Mmr = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChainReranker? Chain { get; init; }
#else
        public global::G.ChainReranker? Chain { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chain))]
#endif
        public bool IsChain => Chain != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::G.ChainReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChainReranker?(SearchReranker @this) => @this.Chain;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::G.ChainReranker? value)
        {
            Chain = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NoneReranker? None { get; init; }
#else
        public global::G.NoneReranker? None { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchReranker(global::G.NoneReranker value) => new SearchReranker(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NoneReranker?(SearchReranker @this) => @this.None;

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(global::G.NoneReranker? value)
        {
            None = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchReranker(
            global::G.SearchRerankerDiscriminatorType? type,
            global::G.CustomerSpecificReranker? customerReranker,
            global::G.UserFunctionReranker? userfn,
            global::G.MMRReranker? mmr,
            global::G.ChainReranker? chain,
            global::G.NoneReranker? none
            )
        {
            Type = type;

            CustomerReranker = customerReranker;
            Userfn = userfn;
            Mmr = mmr;
            Chain = chain;
            None = none;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            None as object ??
            Chain as object ??
            Mmr as object ??
            Userfn as object ??
            CustomerReranker as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomerReranker && !IsUserfn && !IsMmr && !IsChain && !IsNone || !IsCustomerReranker && IsUserfn && !IsMmr && !IsChain && !IsNone || !IsCustomerReranker && !IsUserfn && IsMmr && !IsChain && !IsNone || !IsCustomerReranker && !IsUserfn && !IsMmr && IsChain && !IsNone || !IsCustomerReranker && !IsUserfn && !IsMmr && !IsChain && IsNone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CustomerSpecificReranker?, TResult>? customerReranker = null,
            global::System.Func<global::G.UserFunctionReranker?, TResult>? userfn = null,
            global::System.Func<global::G.MMRReranker?, TResult>? mmr = null,
            global::System.Func<global::G.ChainReranker?, TResult>? chain = null,
            global::System.Func<global::G.NoneReranker?, TResult>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerReranker && customerReranker != null)
            {
                return customerReranker(CustomerReranker!);
            }
            else if (IsUserfn && userfn != null)
            {
                return userfn(Userfn!);
            }
            else if (IsMmr && mmr != null)
            {
                return mmr(Mmr!);
            }
            else if (IsChain && chain != null)
            {
                return chain(Chain!);
            }
            else if (IsNone && none != null)
            {
                return none(None!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CustomerSpecificReranker?>? customerReranker = null,
            global::System.Action<global::G.UserFunctionReranker?>? userfn = null,
            global::System.Action<global::G.MMRReranker?>? mmr = null,
            global::System.Action<global::G.ChainReranker?>? chain = null,
            global::System.Action<global::G.NoneReranker?>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerReranker)
            {
                customerReranker?.Invoke(CustomerReranker!);
            }
            else if (IsUserfn)
            {
                userfn?.Invoke(Userfn!);
            }
            else if (IsMmr)
            {
                mmr?.Invoke(Mmr!);
            }
            else if (IsChain)
            {
                chain?.Invoke(Chain!);
            }
            else if (IsNone)
            {
                none?.Invoke(None!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomerReranker,
                typeof(global::G.CustomerSpecificReranker),
                Userfn,
                typeof(global::G.UserFunctionReranker),
                Mmr,
                typeof(global::G.MMRReranker),
                Chain,
                typeof(global::G.ChainReranker),
                None,
                typeof(global::G.NoneReranker),
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
        public bool Equals(SearchReranker other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CustomerSpecificReranker?>.Default.Equals(CustomerReranker, other.CustomerReranker) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UserFunctionReranker?>.Default.Equals(Userfn, other.Userfn) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MMRReranker?>.Default.Equals(Mmr, other.Mmr) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChainReranker?>.Default.Equals(Chain, other.Chain) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NoneReranker?>.Default.Equals(None, other.None) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchReranker obj1, SearchReranker obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchReranker>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchReranker obj1, SearchReranker obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchReranker o && Equals(o);
        }
    }
}
