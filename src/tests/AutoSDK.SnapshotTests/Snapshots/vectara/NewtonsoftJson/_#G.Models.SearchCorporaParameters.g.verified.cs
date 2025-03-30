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
        public global::G.SearchCorporaParametersVariant1? Value1 { get; init; }
#else
        public global::G.SearchCorporaParametersVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchCorporaParameters(global::G.SearchCorporaParametersVariant1 value) => new SearchCorporaParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchCorporaParametersVariant1?(SearchCorporaParameters @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(global::G.SearchCorporaParametersVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Search parameters to retrieve knowledge for the query.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SearchParameters? Value2 { get; init; }
#else
        public global::G.SearchParameters? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchCorporaParameters(global::G.SearchParameters value) => new SearchCorporaParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchParameters?(SearchCorporaParameters @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(global::G.SearchParameters? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchCorporaParameters(
            global::G.SearchCorporaParametersVariant1? value1,
            global::G.SearchParameters? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SearchCorporaParametersVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.SearchParameters?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SearchCorporaParametersVariant1?>? value1 = null,
            global::System.Action<global::G.SearchParameters?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.SearchCorporaParametersVariant1),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::G.SearchCorporaParametersVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SearchParameters?>.Default.Equals(Value2, other.Value2) 
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
