//HintName: G.Models.PointsSelector.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PointsSelector : global::System.IEquatable<PointsSelector>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PointIdsList? PointIdsList { get; init; }
#else
        public global::G.PointIdsList? PointIdsList { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PointIdsList))]
#endif
        public bool IsPointIdsList => PointIdsList != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FilterSelector? Filter { get; init; }
#else
        public global::G.FilterSelector? Filter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Filter))]
#endif
        public bool IsFilter => Filter != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PointsSelector(global::G.PointIdsList value) => new PointsSelector((global::G.PointIdsList?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PointIdsList?(PointsSelector @this) => @this.PointIdsList;

        /// <summary>
        /// 
        /// </summary>
        public PointsSelector(global::G.PointIdsList? value)
        {
            PointIdsList = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PointsSelector(global::G.FilterSelector value) => new PointsSelector((global::G.FilterSelector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FilterSelector?(PointsSelector @this) => @this.Filter;

        /// <summary>
        /// 
        /// </summary>
        public PointsSelector(global::G.FilterSelector? value)
        {
            Filter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PointsSelector(
            global::G.PointIdsList? pointIdsList,
            global::G.FilterSelector? filter
            )
        {
            PointIdsList = pointIdsList;
            Filter = filter;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Filter as object ??
            PointIdsList as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PointIdsList?.ToString() ??
            Filter?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPointIdsList || IsFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PointIdsList?, TResult>? pointIdsList = null,
            global::System.Func<global::G.FilterSelector?, TResult>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPointIdsList && pointIdsList != null)
            {
                return pointIdsList(PointIdsList!);
            }
            else if (IsFilter && filter != null)
            {
                return filter(Filter!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PointIdsList?>? pointIdsList = null,
            global::System.Action<global::G.FilterSelector?>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPointIdsList)
            {
                pointIdsList?.Invoke(PointIdsList!);
            }
            else if (IsFilter)
            {
                filter?.Invoke(Filter!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PointIdsList,
                typeof(global::G.PointIdsList),
                Filter,
                typeof(global::G.FilterSelector),
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
        public bool Equals(PointsSelector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PointIdsList?>.Default.Equals(PointIdsList, other.PointIdsList) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FilterSelector?>.Default.Equals(Filter, other.Filter) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PointsSelector obj1, PointsSelector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PointsSelector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PointsSelector obj1, PointsSelector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PointsSelector o && Equals(o);
        }
    }
}
