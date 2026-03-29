//HintName: G.Models.StopwordsInterface.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StopwordsInterface : global::System.IEquatable<StopwordsInterface>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Language? Language { get; init; }
#else
        public global::G.Language? Language { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Language))]
#endif
        public bool IsLanguage => Language != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StopwordsSet? Set { get; init; }
#else
        public global::G.StopwordsSet? Set { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Set))]
#endif
        public bool IsSet => Set != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StopwordsInterface(global::G.Language value) => new StopwordsInterface((global::G.Language?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Language?(StopwordsInterface @this) => @this.Language;

        /// <summary>
        /// 
        /// </summary>
        public StopwordsInterface(global::G.Language? value)
        {
            Language = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StopwordsInterface(global::G.StopwordsSet value) => new StopwordsInterface((global::G.StopwordsSet?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StopwordsSet?(StopwordsInterface @this) => @this.Set;

        /// <summary>
        /// 
        /// </summary>
        public StopwordsInterface(global::G.StopwordsSet? value)
        {
            Set = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StopwordsInterface(
            global::G.Language? language,
            global::G.StopwordsSet? set
            )
        {
            Language = language;
            Set = set;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Set as object ??
            Language as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Language?.ToValueString() ??
            Set?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLanguage || IsSet;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Language?, TResult>? language = null,
            global::System.Func<global::G.StopwordsSet?, TResult>? set = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLanguage && language != null)
            {
                return language(Language!);
            }
            else if (IsSet && set != null)
            {
                return set(Set!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Language?>? language = null,
            global::System.Action<global::G.StopwordsSet?>? set = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLanguage)
            {
                language?.Invoke(Language!);
            }
            else if (IsSet)
            {
                set?.Invoke(Set!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Language,
                typeof(global::G.Language),
                Set,
                typeof(global::G.StopwordsSet),
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
        public bool Equals(StopwordsInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Language?>.Default.Equals(Language, other.Language) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StopwordsSet?>.Default.Equals(Set, other.Set) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StopwordsInterface obj1, StopwordsInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StopwordsInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StopwordsInterface obj1, StopwordsInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StopwordsInterface o && Equals(o);
        }
    }
}
