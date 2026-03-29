//HintName: G.Models.ResearchOperationDtoClass.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResearchOperationDtoClass : global::System.IEquatable<ResearchOperationDtoClass>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchOperationDtoClassVariant1? Think { get; init; }
#else
        public global::G.ResearchOperationDtoClassVariant1? Think { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Think))]
#endif
        public bool IsThink => Think != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchOperationDtoClassVariant2? Search { get; init; }
#else
        public global::G.ResearchOperationDtoClassVariant2? Search { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Search))]
#endif
        public bool IsSearch => Search != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResearchOperationDtoClassVariant3? Crawl { get; init; }
#else
        public global::G.ResearchOperationDtoClassVariant3? Crawl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Crawl))]
#endif
        public bool IsCrawl => Crawl != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchOperationDtoClass(global::G.ResearchOperationDtoClassVariant1 value) => new ResearchOperationDtoClass((global::G.ResearchOperationDtoClassVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchOperationDtoClassVariant1?(ResearchOperationDtoClass @this) => @this.Think;

        /// <summary>
        /// 
        /// </summary>
        public ResearchOperationDtoClass(global::G.ResearchOperationDtoClassVariant1? value)
        {
            Think = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchOperationDtoClass(global::G.ResearchOperationDtoClassVariant2 value) => new ResearchOperationDtoClass((global::G.ResearchOperationDtoClassVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchOperationDtoClassVariant2?(ResearchOperationDtoClass @this) => @this.Search;

        /// <summary>
        /// 
        /// </summary>
        public ResearchOperationDtoClass(global::G.ResearchOperationDtoClassVariant2? value)
        {
            Search = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResearchOperationDtoClass(global::G.ResearchOperationDtoClassVariant3 value) => new ResearchOperationDtoClass((global::G.ResearchOperationDtoClassVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResearchOperationDtoClassVariant3?(ResearchOperationDtoClass @this) => @this.Crawl;

        /// <summary>
        /// 
        /// </summary>
        public ResearchOperationDtoClass(global::G.ResearchOperationDtoClassVariant3? value)
        {
            Crawl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResearchOperationDtoClass(
            global::G.ResearchOperationDtoClassVariant1? think,
            global::G.ResearchOperationDtoClassVariant2? search,
            global::G.ResearchOperationDtoClassVariant3? crawl
            )
        {
            Think = think;
            Search = search;
            Crawl = crawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Crawl as object ??
            Search as object ??
            Think as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Think?.ToString() ??
            Search?.ToString() ??
            Crawl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThink && !IsSearch && !IsCrawl || !IsThink && IsSearch && !IsCrawl || !IsThink && !IsSearch && IsCrawl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResearchOperationDtoClassVariant1?, TResult>? think = null,
            global::System.Func<global::G.ResearchOperationDtoClassVariant2?, TResult>? search = null,
            global::System.Func<global::G.ResearchOperationDtoClassVariant3?, TResult>? crawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThink && think != null)
            {
                return think(Think!);
            }
            else if (IsSearch && search != null)
            {
                return search(Search!);
            }
            else if (IsCrawl && crawl != null)
            {
                return crawl(Crawl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResearchOperationDtoClassVariant1?>? think = null,
            global::System.Action<global::G.ResearchOperationDtoClassVariant2?>? search = null,
            global::System.Action<global::G.ResearchOperationDtoClassVariant3?>? crawl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThink)
            {
                think?.Invoke(Think!);
            }
            else if (IsSearch)
            {
                search?.Invoke(Search!);
            }
            else if (IsCrawl)
            {
                crawl?.Invoke(Crawl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Think,
                typeof(global::G.ResearchOperationDtoClassVariant1),
                Search,
                typeof(global::G.ResearchOperationDtoClassVariant2),
                Crawl,
                typeof(global::G.ResearchOperationDtoClassVariant3),
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
        public bool Equals(ResearchOperationDtoClass other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchOperationDtoClassVariant1?>.Default.Equals(Think, other.Think) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchOperationDtoClassVariant2?>.Default.Equals(Search, other.Search) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResearchOperationDtoClassVariant3?>.Default.Equals(Crawl, other.Crawl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResearchOperationDtoClass obj1, ResearchOperationDtoClass obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResearchOperationDtoClass>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResearchOperationDtoClass obj1, ResearchOperationDtoClass obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResearchOperationDtoClass o && Equals(o);
        }
    }
}
