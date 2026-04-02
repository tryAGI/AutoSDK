//HintName: G.Models.KeyedSearchCorpus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A corpus with its identifying key for use in search operations within a customer account.
    /// </summary>
    public readonly partial struct KeyedSearchCorpus : global::System.IEquatable<KeyedSearchCorpus>
    {
        /// <summary>
        /// Configuration for search parameters specific to a single corpus within a customer account, including filters and semantics.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SearchCorpus? SearchCorpus { get; init; }
#else
        public global::G.SearchCorpus? SearchCorpus { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchCorpus))]
#endif
        public bool IsSearchCorpus => SearchCorpus != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyedSearchCorpusVariant2? KeyedSearchCorpusVariant2 { get; init; }
#else
        public global::G.KeyedSearchCorpusVariant2? KeyedSearchCorpusVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyedSearchCorpusVariant2))]
#endif
        public bool IsKeyedSearchCorpusVariant2 => KeyedSearchCorpusVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeyedSearchCorpus(global::G.SearchCorpus value) => new KeyedSearchCorpus((global::G.SearchCorpus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SearchCorpus?(KeyedSearchCorpus @this) => @this.SearchCorpus;

        /// <summary>
        /// 
        /// </summary>
        public KeyedSearchCorpus(global::G.SearchCorpus? value)
        {
            SearchCorpus = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeyedSearchCorpus(global::G.KeyedSearchCorpusVariant2 value) => new KeyedSearchCorpus((global::G.KeyedSearchCorpusVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyedSearchCorpusVariant2?(KeyedSearchCorpus @this) => @this.KeyedSearchCorpusVariant2;

        /// <summary>
        /// 
        /// </summary>
        public KeyedSearchCorpus(global::G.KeyedSearchCorpusVariant2? value)
        {
            KeyedSearchCorpusVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public KeyedSearchCorpus(
            global::G.SearchCorpus? searchCorpus,
            global::G.KeyedSearchCorpusVariant2? keyedSearchCorpusVariant2
            )
        {
            SearchCorpus = searchCorpus;
            KeyedSearchCorpusVariant2 = keyedSearchCorpusVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KeyedSearchCorpusVariant2 as object ??
            SearchCorpus as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SearchCorpus?.ToString() ??
            KeyedSearchCorpusVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSearchCorpus && IsKeyedSearchCorpusVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SearchCorpus?, TResult>? searchCorpus = null,
            global::System.Func<global::G.KeyedSearchCorpusVariant2?, TResult>? keyedSearchCorpusVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchCorpus && searchCorpus != null)
            {
                return searchCorpus(SearchCorpus!);
            }
            else if (IsKeyedSearchCorpusVariant2 && keyedSearchCorpusVariant2 != null)
            {
                return keyedSearchCorpusVariant2(KeyedSearchCorpusVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SearchCorpus?>? searchCorpus = null,
            global::System.Action<global::G.KeyedSearchCorpusVariant2?>? keyedSearchCorpusVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSearchCorpus)
            {
                searchCorpus?.Invoke(SearchCorpus!);
            }
            else if (IsKeyedSearchCorpusVariant2)
            {
                keyedSearchCorpusVariant2?.Invoke(KeyedSearchCorpusVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SearchCorpus,
                typeof(global::G.SearchCorpus),
                KeyedSearchCorpusVariant2,
                typeof(global::G.KeyedSearchCorpusVariant2),
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
        public bool Equals(KeyedSearchCorpus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SearchCorpus?>.Default.Equals(SearchCorpus, other.SearchCorpus) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyedSearchCorpusVariant2?>.Default.Equals(KeyedSearchCorpusVariant2, other.KeyedSearchCorpusVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KeyedSearchCorpus obj1, KeyedSearchCorpus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KeyedSearchCorpus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KeyedSearchCorpus obj1, KeyedSearchCorpus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KeyedSearchCorpus o && Equals(o);
        }
    }
}
