//HintName: G.Models.CollectionWithDetails.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CollectionWithDetails : global::System.IEquatable<CollectionWithDetails>
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
        public global::G.CollectionWithDetailsVariant2? CollectionWithDetailsVariant2 { get; init; }
#else
        public global::G.CollectionWithDetailsVariant2? CollectionWithDetailsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionWithDetailsVariant2))]
#endif
        public bool IsCollectionWithDetailsVariant2 => CollectionWithDetailsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionWithDetails(global::G.Collection value) => new CollectionWithDetails((global::G.Collection?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Collection?(CollectionWithDetails @this) => @this.Collection;

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithDetails(global::G.Collection? value)
        {
            Collection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionWithDetails(global::G.CollectionWithDetailsVariant2 value) => new CollectionWithDetails((global::G.CollectionWithDetailsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CollectionWithDetailsVariant2?(CollectionWithDetails @this) => @this.CollectionWithDetailsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithDetails(global::G.CollectionWithDetailsVariant2? value)
        {
            CollectionWithDetailsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CollectionWithDetails(
            global::G.Collection? collection,
            global::G.CollectionWithDetailsVariant2? collectionWithDetailsVariant2
            )
        {
            Collection = collection;
            CollectionWithDetailsVariant2 = collectionWithDetailsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CollectionWithDetailsVariant2 as object ??
            Collection as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Collection?.ToString() ??
            CollectionWithDetailsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCollection && IsCollectionWithDetailsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Collection?, TResult>? collection = null,
            global::System.Func<global::G.CollectionWithDetailsVariant2?, TResult>? collectionWithDetailsVariant2 = null,
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
            else if (IsCollectionWithDetailsVariant2 && collectionWithDetailsVariant2 != null)
            {
                return collectionWithDetailsVariant2(CollectionWithDetailsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Collection?>? collection = null,
            global::System.Action<global::G.CollectionWithDetailsVariant2?>? collectionWithDetailsVariant2 = null,
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
            else if (IsCollectionWithDetailsVariant2)
            {
                collectionWithDetailsVariant2?.Invoke(CollectionWithDetailsVariant2!);
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
                CollectionWithDetailsVariant2,
                typeof(global::G.CollectionWithDetailsVariant2),
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
        public bool Equals(CollectionWithDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Collection?>.Default.Equals(Collection, other.Collection) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CollectionWithDetailsVariant2?>.Default.Equals(CollectionWithDetailsVariant2, other.CollectionWithDetailsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CollectionWithDetails obj1, CollectionWithDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CollectionWithDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CollectionWithDetails obj1, CollectionWithDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CollectionWithDetails o && Equals(o);
        }
    }
}
