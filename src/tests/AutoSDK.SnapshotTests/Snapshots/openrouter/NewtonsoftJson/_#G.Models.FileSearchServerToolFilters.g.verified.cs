//HintName: G.Models.FileSearchServerToolFilters.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FileSearchServerToolFilters : global::System.IEquatable<FileSearchServerToolFilters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileSearchServerToolFilters0? FileSearchServerToolFilters0 { get; init; }
#else
        public global::G.FileSearchServerToolFilters0? FileSearchServerToolFilters0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFilters0))]
#endif
        public bool IsFileSearchServerToolFilters0 => FileSearchServerToolFilters0 != null;

        /// <summary>
        /// A compound filter that combines multiple comparison or compound filters
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
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FileSearchServerToolFiltersVariant3 { get; init; }
#else
        public object? FileSearchServerToolFiltersVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersVariant3))]
#endif
        public bool IsFileSearchServerToolFiltersVariant3 => FileSearchServerToolFiltersVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFilters(global::G.FileSearchServerToolFilters0 value) => new FileSearchServerToolFilters((global::G.FileSearchServerToolFilters0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchServerToolFilters0?(FileSearchServerToolFilters @this) => @this.FileSearchServerToolFilters0;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFilters(global::G.FileSearchServerToolFilters0? value)
        {
            FileSearchServerToolFilters0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFilters(global::G.CompoundFilter value) => new FileSearchServerToolFilters((global::G.CompoundFilter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompoundFilter?(FileSearchServerToolFilters @this) => @this.CompoundFilter;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFilters(global::G.CompoundFilter? value)
        {
            CompoundFilter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFilters(
            global::G.FileSearchServerToolFilters0? fileSearchServerToolFilters0,
            global::G.CompoundFilter? compoundFilter,
            object? fileSearchServerToolFiltersVariant3
            )
        {
            FileSearchServerToolFilters0 = fileSearchServerToolFilters0;
            CompoundFilter = compoundFilter;
            FileSearchServerToolFiltersVariant3 = fileSearchServerToolFiltersVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileSearchServerToolFiltersVariant3 as object ??
            CompoundFilter as object ??
            FileSearchServerToolFilters0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearchServerToolFilters0?.ToString() ??
            CompoundFilter?.ToString() ??
            FileSearchServerToolFiltersVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearchServerToolFilters0 && !IsCompoundFilter && !IsFileSearchServerToolFiltersVariant3 || !IsFileSearchServerToolFilters0 && IsCompoundFilter && !IsFileSearchServerToolFiltersVariant3 || !IsFileSearchServerToolFilters0 && !IsCompoundFilter && IsFileSearchServerToolFiltersVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileSearchServerToolFilters0?, TResult>? fileSearchServerToolFilters0 = null,
            global::System.Func<global::G.CompoundFilter?, TResult>? compoundFilter = null,
            global::System.Func<object?, TResult>? fileSearchServerToolFiltersVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchServerToolFilters0 && fileSearchServerToolFilters0 != null)
            {
                return fileSearchServerToolFilters0(FileSearchServerToolFilters0!);
            }
            else if (IsCompoundFilter && compoundFilter != null)
            {
                return compoundFilter(CompoundFilter!);
            }
            else if (IsFileSearchServerToolFiltersVariant3 && fileSearchServerToolFiltersVariant3 != null)
            {
                return fileSearchServerToolFiltersVariant3(FileSearchServerToolFiltersVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FileSearchServerToolFilters0?>? fileSearchServerToolFilters0 = null,
            global::System.Action<global::G.CompoundFilter?>? compoundFilter = null,
            global::System.Action<object?>? fileSearchServerToolFiltersVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchServerToolFilters0)
            {
                fileSearchServerToolFilters0?.Invoke(FileSearchServerToolFilters0!);
            }
            else if (IsCompoundFilter)
            {
                compoundFilter?.Invoke(CompoundFilter!);
            }
            else if (IsFileSearchServerToolFiltersVariant3)
            {
                fileSearchServerToolFiltersVariant3?.Invoke(FileSearchServerToolFiltersVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileSearchServerToolFilters0,
                typeof(global::G.FileSearchServerToolFilters0),
                CompoundFilter,
                typeof(global::G.CompoundFilter),
                FileSearchServerToolFiltersVariant3,
                typeof(object),
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
        public bool Equals(FileSearchServerToolFilters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchServerToolFilters0?>.Default.Equals(FileSearchServerToolFilters0, other.FileSearchServerToolFilters0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CompoundFilter?>.Default.Equals(CompoundFilter, other.CompoundFilter) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FileSearchServerToolFiltersVariant3, other.FileSearchServerToolFiltersVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FileSearchServerToolFilters obj1, FileSearchServerToolFilters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileSearchServerToolFilters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FileSearchServerToolFilters obj1, FileSearchServerToolFilters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileSearchServerToolFilters o && Equals(o);
        }
    }
}
