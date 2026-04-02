//HintName: G.Models.CollectionTelemetryEnum.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CollectionTelemetryEnum : global::System.IEquatable<CollectionTelemetryEnum>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CollectionTelemetry? CollectionTelemetry { get; init; }
#else
        public global::G.CollectionTelemetry? CollectionTelemetry { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionTelemetry))]
#endif
        public bool IsCollectionTelemetry => CollectionTelemetry != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CollectionsAggregatedTelemetry? CollectionsAggregated { get; init; }
#else
        public global::G.CollectionsAggregatedTelemetry? CollectionsAggregated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionsAggregated))]
#endif
        public bool IsCollectionsAggregated => CollectionsAggregated != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionTelemetryEnum(global::G.CollectionTelemetry value) => new CollectionTelemetryEnum((global::G.CollectionTelemetry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CollectionTelemetry?(CollectionTelemetryEnum @this) => @this.CollectionTelemetry;

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(global::G.CollectionTelemetry? value)
        {
            CollectionTelemetry = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionTelemetryEnum(global::G.CollectionsAggregatedTelemetry value) => new CollectionTelemetryEnum((global::G.CollectionsAggregatedTelemetry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CollectionsAggregatedTelemetry?(CollectionTelemetryEnum @this) => @this.CollectionsAggregated;

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(global::G.CollectionsAggregatedTelemetry? value)
        {
            CollectionsAggregated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(
            global::G.CollectionTelemetry? collectionTelemetry,
            global::G.CollectionsAggregatedTelemetry? collectionsAggregated
            )
        {
            CollectionTelemetry = collectionTelemetry;
            CollectionsAggregated = collectionsAggregated;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CollectionsAggregated as object ??
            CollectionTelemetry as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CollectionTelemetry?.ToString() ??
            CollectionsAggregated?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCollectionTelemetry || IsCollectionsAggregated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CollectionTelemetry?, TResult>? collectionTelemetry = null,
            global::System.Func<global::G.CollectionsAggregatedTelemetry?, TResult>? collectionsAggregated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollectionTelemetry && collectionTelemetry != null)
            {
                return collectionTelemetry(CollectionTelemetry!);
            }
            else if (IsCollectionsAggregated && collectionsAggregated != null)
            {
                return collectionsAggregated(CollectionsAggregated!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CollectionTelemetry?>? collectionTelemetry = null,
            global::System.Action<global::G.CollectionsAggregatedTelemetry?>? collectionsAggregated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollectionTelemetry)
            {
                collectionTelemetry?.Invoke(CollectionTelemetry!);
            }
            else if (IsCollectionsAggregated)
            {
                collectionsAggregated?.Invoke(CollectionsAggregated!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CollectionTelemetry,
                typeof(global::G.CollectionTelemetry),
                CollectionsAggregated,
                typeof(global::G.CollectionsAggregatedTelemetry),
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
        public bool Equals(CollectionTelemetryEnum other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CollectionTelemetry?>.Default.Equals(CollectionTelemetry, other.CollectionTelemetry) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CollectionsAggregatedTelemetry?>.Default.Equals(CollectionsAggregated, other.CollectionsAggregated) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CollectionTelemetryEnum obj1, CollectionTelemetryEnum obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CollectionTelemetryEnum>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CollectionTelemetryEnum obj1, CollectionTelemetryEnum obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CollectionTelemetryEnum o && Equals(o);
        }
    }
}
