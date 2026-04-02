//HintName: G.Models.Indexes.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Vector index configuration
    /// </summary>
    public readonly partial struct Indexes : global::System.IEquatable<Indexes>
    {
        /// <summary>
        /// Do not use any index, scan whole vector collection during search. Guarantee 100% precision, but may be time consuming on large collections.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IndexesVariant1? IndexesVariant1 { get; init; }
#else
        public global::G.IndexesVariant1? IndexesVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesVariant1))]
#endif
        public bool IsIndexesVariant1 => IndexesVariant1 != null;

        /// <summary>
        /// Use filterable HNSW index for approximate search. Is very fast even on a very huge collections, but require additional space to store index and additional time to build it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IndexesVariant2? IndexesVariant2 { get; init; }
#else
        public global::G.IndexesVariant2? IndexesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IndexesVariant2))]
#endif
        public bool IsIndexesVariant2 => IndexesVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Indexes(global::G.IndexesVariant1 value) => new Indexes((global::G.IndexesVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IndexesVariant1?(Indexes @this) => @this.IndexesVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Indexes(global::G.IndexesVariant1? value)
        {
            IndexesVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Indexes(global::G.IndexesVariant2 value) => new Indexes((global::G.IndexesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IndexesVariant2?(Indexes @this) => @this.IndexesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Indexes(global::G.IndexesVariant2? value)
        {
            IndexesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Indexes(
            global::G.IndexesVariant1? indexesVariant1,
            global::G.IndexesVariant2? indexesVariant2
            )
        {
            IndexesVariant1 = indexesVariant1;
            IndexesVariant2 = indexesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IndexesVariant2 as object ??
            IndexesVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IndexesVariant1?.ToString() ??
            IndexesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIndexesVariant1 && !IsIndexesVariant2 || !IsIndexesVariant1 && IsIndexesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.IndexesVariant1?, TResult>? indexesVariant1 = null,
            global::System.Func<global::G.IndexesVariant2?, TResult>? indexesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndexesVariant1 && indexesVariant1 != null)
            {
                return indexesVariant1(IndexesVariant1!);
            }
            else if (IsIndexesVariant2 && indexesVariant2 != null)
            {
                return indexesVariant2(IndexesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.IndexesVariant1?>? indexesVariant1 = null,
            global::System.Action<global::G.IndexesVariant2?>? indexesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIndexesVariant1)
            {
                indexesVariant1?.Invoke(IndexesVariant1!);
            }
            else if (IsIndexesVariant2)
            {
                indexesVariant2?.Invoke(IndexesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IndexesVariant1,
                typeof(global::G.IndexesVariant1),
                IndexesVariant2,
                typeof(global::G.IndexesVariant2),
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
        public bool Equals(Indexes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.IndexesVariant1?>.Default.Equals(IndexesVariant1, other.IndexesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.IndexesVariant2?>.Default.Equals(IndexesVariant2, other.IndexesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Indexes obj1, Indexes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Indexes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Indexes obj1, Indexes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Indexes o && Equals(o);
        }
    }
}
