//HintName: G.Models.FilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FilterNode : global::System.IEquatable<FilterNode>
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PartialTablesAndViews? PartialTablesAndViews { get; init; }
#else
        public global::G.PartialTablesAndViews? PartialTablesAndViews { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PartialTablesAndViews))]
#endif
        public bool IsPartialTablesAndViews => PartialTablesAndViews != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FilterBranch? Branch { get; init; }
#else
        public global::G.FilterBranch? Branch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branch))]
#endif
        public bool IsBranch => Branch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Enum { get; init; }
#else
        public object? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FilterNodeEnum2? Enum2 { get; init; }
#else
        public global::G.FilterNodeEnum2? Enum2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum2))]
#endif
        public bool IsEnum2 => Enum2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FilterNode(global::G.PartialTablesAndViews value) => new FilterNode((global::G.PartialTablesAndViews?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PartialTablesAndViews?(FilterNode @this) => @this.PartialTablesAndViews;

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(global::G.PartialTablesAndViews? value)
        {
            PartialTablesAndViews = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FilterNode(global::G.FilterBranch value) => new FilterNode((global::G.FilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FilterBranch?(FilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(global::G.FilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FilterNode(global::G.FilterNodeEnum2 value) => new FilterNode((global::G.FilterNodeEnum2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FilterNodeEnum2?(FilterNode @this) => @this.Enum2;

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(global::G.FilterNodeEnum2? value)
        {
            Enum2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(
            global::G.PartialTablesAndViews? partialTablesAndViews,
            global::G.FilterBranch? branch,
            object? @enum,
            global::G.FilterNodeEnum2? enum2
            )
        {
            PartialTablesAndViews = partialTablesAndViews;
            Branch = branch;
            Enum = @enum;
            Enum2 = enum2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum2 as object ??
            Enum as object ??
            Branch as object ??
            PartialTablesAndViews as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PartialTablesAndViews?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToString() ??
            Enum2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPartialTablesAndViews || IsBranch || IsEnum || IsEnum2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PartialTablesAndViews?, TResult>? partialTablesAndViews = null,
            global::System.Func<global::G.FilterBranch?, TResult>? branch = null,
            global::System.Func<object?, TResult>? @enum = null,
            global::System.Func<global::G.FilterNodeEnum2?, TResult>? enum2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPartialTablesAndViews && partialTablesAndViews != null)
            {
                return partialTablesAndViews(PartialTablesAndViews!);
            }
            else if (IsBranch && branch != null)
            {
                return branch(Branch!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsEnum2 && enum2 != null)
            {
                return enum2(Enum2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PartialTablesAndViews?>? partialTablesAndViews = null,
            global::System.Action<global::G.FilterBranch?>? branch = null,
            global::System.Action<object?>? @enum = null,
            global::System.Action<global::G.FilterNodeEnum2?>? enum2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPartialTablesAndViews)
            {
                partialTablesAndViews?.Invoke(PartialTablesAndViews!);
            }
            else if (IsBranch)
            {
                branch?.Invoke(Branch!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsEnum2)
            {
                enum2?.Invoke(Enum2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PartialTablesAndViews,
                typeof(global::G.PartialTablesAndViews),
                Branch,
                typeof(global::G.FilterBranch),
                Enum,
                typeof(object),
                Enum2,
                typeof(global::G.FilterNodeEnum2),
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
        public bool Equals(FilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PartialTablesAndViews?>.Default.Equals(PartialTablesAndViews, other.PartialTablesAndViews) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FilterNodeEnum2?>.Default.Equals(Enum2, other.Enum2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FilterNode obj1, FilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FilterNode obj1, FilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FilterNode o && Equals(o);
        }
    }
}
