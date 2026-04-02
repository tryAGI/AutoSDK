//HintName: G.Models.FileSearchServerToolFiltersOneOf0ValueOneOf3Items.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FileSearchServerToolFiltersOneOf0ValueOneOf3Items : global::System.IEquatable<FileSearchServerToolFiltersOneOf0ValueOneOf3Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 { get; init; }
#else
        public string? FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1))]
#endif
        public bool IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 => FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 { get; init; }
#else
        public double? FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2))]
#endif
        public bool IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 => FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0ValueOneOf3Items(string value) => new FileSearchServerToolFiltersOneOf0ValueOneOf3Items((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FileSearchServerToolFiltersOneOf0ValueOneOf3Items @this) => @this.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0ValueOneOf3Items(string? value)
        {
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0ValueOneOf3Items(double value) => new FileSearchServerToolFiltersOneOf0ValueOneOf3Items((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(FileSearchServerToolFiltersOneOf0ValueOneOf3Items @this) => @this.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0ValueOneOf3Items(double? value)
        {
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0ValueOneOf3Items(
            string? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1,
            double? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2
            )
        {
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 = fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1;
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 = fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 as object ??
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1?.ToString() ??
            FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 && !IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 || !IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 && IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 = null,
            global::System.Func<double?, TResult>? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 && fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 != null)
            {
                return fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 && fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 != null)
            {
                return fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1 = null,
            global::System.Action<double?>? fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1)
            {
                fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1?.Invoke(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2)
            {
                fileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2?.Invoke(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1,
                typeof(string),
                FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2,
                typeof(double),
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
        public bool Equals(FileSearchServerToolFiltersOneOf0ValueOneOf3Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1, other.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2, other.FileSearchServerToolFiltersOneOf0ValueOneOf3ItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FileSearchServerToolFiltersOneOf0ValueOneOf3Items obj1, FileSearchServerToolFiltersOneOf0ValueOneOf3Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileSearchServerToolFiltersOneOf0ValueOneOf3Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FileSearchServerToolFiltersOneOf0ValueOneOf3Items obj1, FileSearchServerToolFiltersOneOf0ValueOneOf3Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileSearchServerToolFiltersOneOf0ValueOneOf3Items o && Equals(o);
        }
    }
}
