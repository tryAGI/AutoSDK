//HintName: G.Models.Filters2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Filters2 : global::System.IEquatable<Filters2>
    {
        /// <summary>
        /// A filter used to compare a specified attribute key to a given value using a defined comparison operation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ComparisonFilter? ComparisonFilter { get; init; }
#else
        public global::G.ComparisonFilter? ComparisonFilter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComparisonFilter))]
#endif
        public bool IsComparisonFilter => ComparisonFilter != null;

        /// <summary>
        /// Combine multiple filters using `and` or `or`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompoundFilter? CompoundFilter { get; init; }
#else
        public global::G.CompoundFilter? CompoundFilter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompoundFilter))]
#endif
        public bool IsCompoundFilter => CompoundFilter != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Filters2(global::G.ComparisonFilter value) => new Filters2((global::G.ComparisonFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ComparisonFilter?(Filters2 @this) => @this.ComparisonFilter;

        /// <summary>
        /// 
        /// </summary>
        public Filters2(global::G.ComparisonFilter? value)
        {
            ComparisonFilter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Filters2(global::G.CompoundFilter value) => new Filters2((global::G.CompoundFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompoundFilter?(Filters2 @this) => @this.CompoundFilter;

        /// <summary>
        /// 
        /// </summary>
        public Filters2(global::G.CompoundFilter? value)
        {
            CompoundFilter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Filters2(
            global::G.ComparisonFilter? comparisonFilter,
            global::G.CompoundFilter? compoundFilter
            )
        {
            ComparisonFilter = comparisonFilter;
            CompoundFilter = compoundFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompoundFilter as object ??
            ComparisonFilter as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ComparisonFilter?.ToString() ??
            CompoundFilter?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComparisonFilter || IsCompoundFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ComparisonFilter?, TResult>? comparisonFilter = null,
            global::System.Func<global::G.CompoundFilter?, TResult>? compoundFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonFilter && comparisonFilter != null)
            {
                return comparisonFilter(ComparisonFilter!);
            }
            else if (IsCompoundFilter && compoundFilter != null)
            {
                return compoundFilter(CompoundFilter!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ComparisonFilter?>? comparisonFilter = null,
            global::System.Action<global::G.CompoundFilter?>? compoundFilter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComparisonFilter)
            {
                comparisonFilter?.Invoke(ComparisonFilter!);
            }
            else if (IsCompoundFilter)
            {
                compoundFilter?.Invoke(CompoundFilter!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComparisonFilter,
                typeof(global::G.ComparisonFilter),
                CompoundFilter,
                typeof(global::G.CompoundFilter),
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
        public bool Equals(Filters2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ComparisonFilter?>.Default.Equals(ComparisonFilter, other.ComparisonFilter) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CompoundFilter?>.Default.Equals(CompoundFilter, other.CompoundFilter) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Filters2 obj1, Filters2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Filters2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Filters2 obj1, Filters2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Filters2 o && Equals(o);
        }
    }
}
