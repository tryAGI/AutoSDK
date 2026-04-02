//HintName: G.Models.FullTextSearch.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Whether this attribute can be used as part of a BM25 full-text search. Requires the `string` or `[]string` type, and by default, BM25-enabled attributes are not filterable. You can override this by setting `filterable: true`.
    /// </summary>
    public readonly partial struct FullTextSearch : global::System.IEquatable<FullTextSearch>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? FullTextSearchVariant1 { get; init; }
#else
        public bool? FullTextSearchVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FullTextSearchVariant1))]
#endif
        public bool IsFullTextSearchVariant1 => FullTextSearchVariant1 != null;

        /// <summary>
        /// Configuration options for full-text search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FullTextSearchConfig? Config { get; init; }
#else
        public global::G.FullTextSearchConfig? Config { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Config))]
#endif
        public bool IsConfig => Config != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FullTextSearch(bool value) => new FullTextSearch((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(FullTextSearch @this) => @this.FullTextSearchVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FullTextSearch(bool? value)
        {
            FullTextSearchVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FullTextSearch(global::G.FullTextSearchConfig value) => new FullTextSearch((global::G.FullTextSearchConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FullTextSearchConfig?(FullTextSearch @this) => @this.Config;

        /// <summary>
        /// 
        /// </summary>
        public FullTextSearch(global::G.FullTextSearchConfig? value)
        {
            Config = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FullTextSearch(
            bool? fullTextSearchVariant1,
            global::G.FullTextSearchConfig? config
            )
        {
            FullTextSearchVariant1 = fullTextSearchVariant1;
            Config = config;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Config as object ??
            FullTextSearchVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FullTextSearchVariant1?.ToString().ToLowerInvariant() ??
            Config?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFullTextSearchVariant1 && !IsConfig || !IsFullTextSearchVariant1 && IsConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? fullTextSearchVariant1 = null,
            global::System.Func<global::G.FullTextSearchConfig?, TResult>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFullTextSearchVariant1 && fullTextSearchVariant1 != null)
            {
                return fullTextSearchVariant1(FullTextSearchVariant1!);
            }
            else if (IsConfig && config != null)
            {
                return config(Config!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? fullTextSearchVariant1 = null,
            global::System.Action<global::G.FullTextSearchConfig?>? config = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFullTextSearchVariant1)
            {
                fullTextSearchVariant1?.Invoke(FullTextSearchVariant1!);
            }
            else if (IsConfig)
            {
                config?.Invoke(Config!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FullTextSearchVariant1,
                typeof(bool),
                Config,
                typeof(global::G.FullTextSearchConfig),
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
        public bool Equals(FullTextSearch other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(FullTextSearchVariant1, other.FullTextSearchVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FullTextSearchConfig?>.Default.Equals(Config, other.Config) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FullTextSearch obj1, FullTextSearch obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FullTextSearch>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FullTextSearch obj1, FullTextSearch obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FullTextSearch o && Equals(o);
        }
    }
}
