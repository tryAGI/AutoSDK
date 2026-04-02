//HintName: G.Models.SearchCorporaParameters.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The parameters to search one or more corpora.
    /// </summary>
    public readonly partial struct SearchCorporaParameters : global::System.IEquatable<SearchCorporaParameters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SearchCorporaParametersVariant1? SearchCorporaParametersVariant1 { get; init; }
#else
        public global::G.SearchCorporaParametersVariant1? SearchCorporaParametersVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchCorporaParametersVariant1))]
#endif
        public bool IsSearchCorporaParametersVariant1 => SearchCorporaParametersVariant1 != null;

        /// <summary>
        /// Search parameters to retrieve knowledge for the query.<br/>
        /// Example: {"limit":50}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SearchParameters? SearchParameters { get; init; }
#else
        public global::G.SearchParameters? SearchParameters { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchParameters))]
#endif
        public bool IsSearchParameters => SearchParameters != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchCorporaParameters(global::G.SearchCorporaParametersVariant1 value) => new SearchCorporaParameters((global::G.SearchCorporaParametersVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchCorporaParametersVariant1?(SearchCorporaParameters @this) => @this.SearchCorporaParametersVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(global::G.SearchCorporaParametersVariant1? value)
        {
            SearchCorporaParametersVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchCorporaParameters(global::G.SearchParameters value) => new SearchCorporaParameters((global::G.SearchParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchParameters?(SearchCorporaParameters @this) => @this.SearchParameters;

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(global::G.SearchParameters? value)
        {
            SearchParameters = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(
            global::G.SearchCorporaParametersVariant1? searchCorporaParametersVariant1,
            global::G.SearchParameters? searchParameters
            )
        {
            SearchCorporaParametersVariant1 = searchCorporaParametersVariant1;
            SearchParameters = searchParameters;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SearchParameters as object ??
            SearchCorporaParametersVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchCorporaParametersVariant1?.ToString() ??
            SearchParameters?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchCorporaParametersVariant1 && IsSearchParameters;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SearchCorporaParametersVariant1?, TResult>? searchCorporaParametersVariant1 = null,
            global::System.Func<global::G.SearchParameters?, TResult>? searchParameters = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchCorporaParametersVariant1 && searchCorporaParametersVariant1 != null)
            {
                return searchCorporaParametersVariant1(SearchCorporaParametersVariant1!);
            }
            else if (IsSearchParameters && searchParameters != null)
            {
                return searchParameters(SearchParameters!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SearchCorporaParametersVariant1?>? searchCorporaParametersVariant1 = null,
            global::System.Action<global::G.SearchParameters?>? searchParameters = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchCorporaParametersVariant1)
            {
                searchCorporaParametersVariant1?.Invoke(SearchCorporaParametersVariant1!);
            }
            else if (IsSearchParameters)
            {
                searchParameters?.Invoke(SearchParameters!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchCorporaParametersVariant1,
                typeof(global::G.SearchCorporaParametersVariant1),
                SearchParameters,
                typeof(global::G.SearchParameters),
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
        public bool Equals(SearchCorporaParameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SearchCorporaParametersVariant1?>.Default.Equals(SearchCorporaParametersVariant1, other.SearchCorporaParametersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SearchParameters?>.Default.Equals(SearchParameters, other.SearchParameters) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchCorporaParameters obj1, SearchCorporaParameters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchCorporaParameters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchCorporaParameters obj1, SearchCorporaParameters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchCorporaParameters o && Equals(o);
        }
    }
}
