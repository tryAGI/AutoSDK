//HintName: G.Models.Ids.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Filter search results to a particular set of object IDs. To specify a list of IDs, include the query param multiple times
    /// </summary>
    public readonly partial struct Ids : global::System.IEquatable<Ids>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Guid? Guid { get; init; }
#else
        public global::System.Guid? Guid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Guid))]
#endif
        public bool IsGuid => Guid != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Guid>? IdsVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Guid>? IdsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IdsVariant2))]
#endif
        public bool IsIdsVariant2 => IdsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Ids(global::System.Guid value) => new Ids((global::System.Guid?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Guid?(Ids @this) => @this.Guid;

        /// <summary>
        /// 
        /// </summary>
        public Ids(global::System.Guid? value)
        {
            Guid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Ids(
            global::System.Guid? guid,
            global::System.Collections.Generic.IList<global::System.Guid>? idsVariant2
            )
        {
            Guid = guid;
            IdsVariant2 = idsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IdsVariant2 as object ??
            Guid as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Guid?.ToString() ??
            IdsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGuid || IsIdsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Guid?, TResult>? guid = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Guid>?, TResult>? idsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGuid && guid != null)
            {
                return guid(Guid!);
            }
            else if (IsIdsVariant2 && idsVariant2 != null)
            {
                return idsVariant2(IdsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Guid?>? guid = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Guid>?>? idsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGuid)
            {
                guid?.Invoke(Guid!);
            }
            else if (IsIdsVariant2)
            {
                idsVariant2?.Invoke(IdsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Guid,
                typeof(global::System.Guid),
                IdsVariant2,
                typeof(global::System.Collections.Generic.IList<global::System.Guid>),
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
        public bool Equals(Ids other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Guid?>.Default.Equals(Guid, other.Guid) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Guid>?>.Default.Equals(IdsVariant2, other.IdsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Ids obj1, Ids obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Ids>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Ids obj1, Ids obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Ids o && Equals(o);
        }
    }
}
