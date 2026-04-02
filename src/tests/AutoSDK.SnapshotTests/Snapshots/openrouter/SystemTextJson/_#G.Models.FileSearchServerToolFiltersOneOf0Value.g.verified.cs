//HintName: G.Models.FileSearchServerToolFiltersOneOf0Value.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FileSearchServerToolFiltersOneOf0Value : global::System.IEquatable<FileSearchServerToolFiltersOneOf0Value>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FileSearchServerToolFiltersOneOf0ValueVariant1 { get; init; }
#else
        public string? FileSearchServerToolFiltersOneOf0ValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersOneOf0ValueVariant1))]
#endif
        public bool IsFileSearchServerToolFiltersOneOf0ValueVariant1 => FileSearchServerToolFiltersOneOf0ValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? FileSearchServerToolFiltersOneOf0ValueVariant2 { get; init; }
#else
        public double? FileSearchServerToolFiltersOneOf0ValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersOneOf0ValueVariant2))]
#endif
        public bool IsFileSearchServerToolFiltersOneOf0ValueVariant2 => FileSearchServerToolFiltersOneOf0ValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? FileSearchServerToolFiltersOneOf0ValueVariant3 { get; init; }
#else
        public bool? FileSearchServerToolFiltersOneOf0ValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersOneOf0ValueVariant3))]
#endif
        public bool IsFileSearchServerToolFiltersOneOf0ValueVariant3 => FileSearchServerToolFiltersOneOf0ValueVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? FileSearchServerToolFiltersOneOf0Value3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? FileSearchServerToolFiltersOneOf0Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersOneOf0Value3))]
#endif
        public bool IsFileSearchServerToolFiltersOneOf0Value3 => FileSearchServerToolFiltersOneOf0Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0Value(string value) => new FileSearchServerToolFiltersOneOf0Value((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FileSearchServerToolFiltersOneOf0Value @this) => @this.FileSearchServerToolFiltersOneOf0ValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(string? value)
        {
            FileSearchServerToolFiltersOneOf0ValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0Value(double value) => new FileSearchServerToolFiltersOneOf0Value((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(FileSearchServerToolFiltersOneOf0Value @this) => @this.FileSearchServerToolFiltersOneOf0ValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(double? value)
        {
            FileSearchServerToolFiltersOneOf0ValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0Value(bool value) => new FileSearchServerToolFiltersOneOf0Value((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(FileSearchServerToolFiltersOneOf0Value @this) => @this.FileSearchServerToolFiltersOneOf0ValueVariant3;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(bool? value)
        {
            FileSearchServerToolFiltersOneOf0ValueVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(
            string? fileSearchServerToolFiltersOneOf0ValueVariant1,
            double? fileSearchServerToolFiltersOneOf0ValueVariant2,
            bool? fileSearchServerToolFiltersOneOf0ValueVariant3,
            global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? fileSearchServerToolFiltersOneOf0Value3
            )
        {
            FileSearchServerToolFiltersOneOf0ValueVariant1 = fileSearchServerToolFiltersOneOf0ValueVariant1;
            FileSearchServerToolFiltersOneOf0ValueVariant2 = fileSearchServerToolFiltersOneOf0ValueVariant2;
            FileSearchServerToolFiltersOneOf0ValueVariant3 = fileSearchServerToolFiltersOneOf0ValueVariant3;
            FileSearchServerToolFiltersOneOf0Value3 = fileSearchServerToolFiltersOneOf0Value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileSearchServerToolFiltersOneOf0Value3 as object ??
            FileSearchServerToolFiltersOneOf0ValueVariant3 as object ??
            FileSearchServerToolFiltersOneOf0ValueVariant2 as object ??
            FileSearchServerToolFiltersOneOf0ValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearchServerToolFiltersOneOf0ValueVariant1?.ToString() ??
            FileSearchServerToolFiltersOneOf0ValueVariant2?.ToString() ??
            FileSearchServerToolFiltersOneOf0ValueVariant3?.ToString().ToLowerInvariant() ??
            FileSearchServerToolFiltersOneOf0Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearchServerToolFiltersOneOf0ValueVariant1 && !IsFileSearchServerToolFiltersOneOf0ValueVariant2 && !IsFileSearchServerToolFiltersOneOf0ValueVariant3 && !IsFileSearchServerToolFiltersOneOf0Value3 || !IsFileSearchServerToolFiltersOneOf0ValueVariant1 && IsFileSearchServerToolFiltersOneOf0ValueVariant2 && !IsFileSearchServerToolFiltersOneOf0ValueVariant3 && !IsFileSearchServerToolFiltersOneOf0Value3 || !IsFileSearchServerToolFiltersOneOf0ValueVariant1 && !IsFileSearchServerToolFiltersOneOf0ValueVariant2 && IsFileSearchServerToolFiltersOneOf0ValueVariant3 && !IsFileSearchServerToolFiltersOneOf0Value3 || !IsFileSearchServerToolFiltersOneOf0ValueVariant1 && !IsFileSearchServerToolFiltersOneOf0ValueVariant2 && !IsFileSearchServerToolFiltersOneOf0ValueVariant3 && IsFileSearchServerToolFiltersOneOf0Value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? fileSearchServerToolFiltersOneOf0ValueVariant1 = null,
            global::System.Func<double?, TResult>? fileSearchServerToolFiltersOneOf0ValueVariant2 = null,
            global::System.Func<bool?, TResult>? fileSearchServerToolFiltersOneOf0ValueVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>?, TResult>? fileSearchServerToolFiltersOneOf0Value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchServerToolFiltersOneOf0ValueVariant1 && fileSearchServerToolFiltersOneOf0ValueVariant1 != null)
            {
                return fileSearchServerToolFiltersOneOf0ValueVariant1(FileSearchServerToolFiltersOneOf0ValueVariant1!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0ValueVariant2 && fileSearchServerToolFiltersOneOf0ValueVariant2 != null)
            {
                return fileSearchServerToolFiltersOneOf0ValueVariant2(FileSearchServerToolFiltersOneOf0ValueVariant2!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0ValueVariant3 && fileSearchServerToolFiltersOneOf0ValueVariant3 != null)
            {
                return fileSearchServerToolFiltersOneOf0ValueVariant3(FileSearchServerToolFiltersOneOf0ValueVariant3!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0Value3 && fileSearchServerToolFiltersOneOf0Value3 != null)
            {
                return fileSearchServerToolFiltersOneOf0Value3(FileSearchServerToolFiltersOneOf0Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? fileSearchServerToolFiltersOneOf0ValueVariant1 = null,
            global::System.Action<double?>? fileSearchServerToolFiltersOneOf0ValueVariant2 = null,
            global::System.Action<bool?>? fileSearchServerToolFiltersOneOf0ValueVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>?>? fileSearchServerToolFiltersOneOf0Value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchServerToolFiltersOneOf0ValueVariant1)
            {
                fileSearchServerToolFiltersOneOf0ValueVariant1?.Invoke(FileSearchServerToolFiltersOneOf0ValueVariant1!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0ValueVariant2)
            {
                fileSearchServerToolFiltersOneOf0ValueVariant2?.Invoke(FileSearchServerToolFiltersOneOf0ValueVariant2!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0ValueVariant3)
            {
                fileSearchServerToolFiltersOneOf0ValueVariant3?.Invoke(FileSearchServerToolFiltersOneOf0ValueVariant3!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0Value3)
            {
                fileSearchServerToolFiltersOneOf0Value3?.Invoke(FileSearchServerToolFiltersOneOf0Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileSearchServerToolFiltersOneOf0ValueVariant1,
                typeof(string),
                FileSearchServerToolFiltersOneOf0ValueVariant2,
                typeof(double),
                FileSearchServerToolFiltersOneOf0ValueVariant3,
                typeof(bool),
                FileSearchServerToolFiltersOneOf0Value3,
                typeof(global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>),
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
        public bool Equals(FileSearchServerToolFiltersOneOf0Value other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FileSearchServerToolFiltersOneOf0ValueVariant1, other.FileSearchServerToolFiltersOneOf0ValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(FileSearchServerToolFiltersOneOf0ValueVariant2, other.FileSearchServerToolFiltersOneOf0ValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(FileSearchServerToolFiltersOneOf0ValueVariant3, other.FileSearchServerToolFiltersOneOf0ValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>?>.Default.Equals(FileSearchServerToolFiltersOneOf0Value3, other.FileSearchServerToolFiltersOneOf0Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FileSearchServerToolFiltersOneOf0Value obj1, FileSearchServerToolFiltersOneOf0Value obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileSearchServerToolFiltersOneOf0Value>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FileSearchServerToolFiltersOneOf0Value obj1, FileSearchServerToolFiltersOneOf0Value obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileSearchServerToolFiltersOneOf0Value o && Equals(o);
        }
    }
}
