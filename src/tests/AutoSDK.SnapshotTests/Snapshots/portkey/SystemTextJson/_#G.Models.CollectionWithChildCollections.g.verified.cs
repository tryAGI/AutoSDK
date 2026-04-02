//HintName: G.Models.CollectionWithChildCollections.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CollectionWithChildCollections : global::System.IEquatable<CollectionWithChildCollections>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Collection? Collection { get; init; }
#else
        public global::G.Collection? Collection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Collection))]
#endif
        public bool IsCollection => Collection != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CollectionWithChildCollectionsVariant2? CollectionWithChildCollectionsVariant2 { get; init; }
#else
        public global::G.CollectionWithChildCollectionsVariant2? CollectionWithChildCollectionsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionWithChildCollectionsVariant2))]
#endif
        public bool IsCollectionWithChildCollectionsVariant2 => CollectionWithChildCollectionsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionWithChildCollections(global::G.Collection value) => new CollectionWithChildCollections((global::G.Collection?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Collection?(CollectionWithChildCollections @this) => @this.Collection;

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithChildCollections(global::G.Collection? value)
        {
            Collection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionWithChildCollections(global::G.CollectionWithChildCollectionsVariant2 value) => new CollectionWithChildCollections((global::G.CollectionWithChildCollectionsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CollectionWithChildCollectionsVariant2?(CollectionWithChildCollections @this) => @this.CollectionWithChildCollectionsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithChildCollections(global::G.CollectionWithChildCollectionsVariant2? value)
        {
            CollectionWithChildCollectionsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithChildCollections(
            global::G.Collection? collection,
            global::G.CollectionWithChildCollectionsVariant2? collectionWithChildCollectionsVariant2
            )
        {
            Collection = collection;
            CollectionWithChildCollectionsVariant2 = collectionWithChildCollectionsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CollectionWithChildCollectionsVariant2 as object ??
            Collection as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Collection?.ToString() ??
            CollectionWithChildCollectionsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCollection && IsCollectionWithChildCollectionsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Collection?, TResult>? collection = null,
            global::System.Func<global::G.CollectionWithChildCollectionsVariant2?, TResult>? collectionWithChildCollectionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollection && collection != null)
            {
                return collection(Collection!);
            }
            else if (IsCollectionWithChildCollectionsVariant2 && collectionWithChildCollectionsVariant2 != null)
            {
                return collectionWithChildCollectionsVariant2(CollectionWithChildCollectionsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Collection?>? collection = null,
            global::System.Action<global::G.CollectionWithChildCollectionsVariant2?>? collectionWithChildCollectionsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollection)
            {
                collection?.Invoke(Collection!);
            }
            else if (IsCollectionWithChildCollectionsVariant2)
            {
                collectionWithChildCollectionsVariant2?.Invoke(CollectionWithChildCollectionsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Collection,
                typeof(global::G.Collection),
                CollectionWithChildCollectionsVariant2,
                typeof(global::G.CollectionWithChildCollectionsVariant2),
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
        public bool Equals(CollectionWithChildCollections other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Collection?>.Default.Equals(Collection, other.Collection) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CollectionWithChildCollectionsVariant2?>.Default.Equals(CollectionWithChildCollectionsVariant2, other.CollectionWithChildCollectionsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CollectionWithChildCollections obj1, CollectionWithChildCollections obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CollectionWithChildCollections>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CollectionWithChildCollections obj1, CollectionWithChildCollections obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CollectionWithChildCollections o && Equals(o);
        }
    }
}
