//HintName: G.Models.DataItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem : global::System.IEquatable<DataItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.StoreEventListResponseDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Represents an ingestion event in a vector store.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StoreIngestionEvent? Ingestion { get; init; }
#else
        public global::G.StoreIngestionEvent? Ingestion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ingestion))]
#endif
        public bool IsIngestion => Ingestion != null;

        /// <summary>
        /// Represents a search event in a vector store.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StoreSearchEvent? Search { get; init; }
#else
        public global::G.StoreSearchEvent? Search { get; }
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
        public static implicit operator DataItem(global::G.StoreIngestionEvent value) => new DataItem((global::G.StoreIngestionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StoreIngestionEvent?(DataItem @this) => @this.Ingestion;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::G.StoreIngestionEvent? value)
        {
            Ingestion = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem(global::G.StoreSearchEvent value) => new DataItem((global::G.StoreSearchEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StoreSearchEvent?(DataItem @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::G.StoreSearchEvent? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem(
            global::G.StoreEventListResponseDataItemDiscriminatorType? type,
            global::G.StoreIngestionEvent? ingestion,
            global::G.StoreSearchEvent? search
            )
        {
            Type = type;

            Ingestion = ingestion;
            Search = search;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Search as object ??
            Ingestion as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Ingestion?.ToString() ??
            Search?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIngestion && !IsSearch || !IsIngestion && IsSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StoreIngestionEvent?, TResult>? ingestion = null,
            global::System.Func<global::G.StoreSearchEvent?, TResult>? search = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestion && ingestion != null)
            {
                return ingestion(Ingestion!);
            }
            else if (IsSearch && search != null)
            {
                return search(Search!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StoreIngestionEvent?>? ingestion = null,
            global::System.Action<global::G.StoreSearchEvent?>? search = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIngestion)
            {
                ingestion?.Invoke(Ingestion!);
            }
            else if (IsSearch)
            {
                search?.Invoke(Search!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ingestion,
                typeof(global::G.StoreIngestionEvent),
                Search,
                typeof(global::G.StoreSearchEvent),
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
        public bool Equals(DataItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StoreIngestionEvent?>.Default.Equals(Ingestion, other.Ingestion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StoreSearchEvent?>.Default.Equals(Search, other.Search) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem obj1, DataItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem obj1, DataItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem o && Equals(o);
        }
    }
}
