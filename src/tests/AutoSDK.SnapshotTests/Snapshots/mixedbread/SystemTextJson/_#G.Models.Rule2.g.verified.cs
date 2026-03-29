//HintName: G.Models.Rule2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The specific rule to delete from the rules array
    /// </summary>
    public readonly partial struct Rule2 : global::System.IEquatable<Rule2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType? Type { get; }

        /// <summary>
        /// Represents a string query substitution rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.QueryStringSubstitutionRule? QueryString { get; init; }
#else
        public global::G.QueryStringSubstitutionRule? QueryString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryString))]
#endif
        public bool IsQueryString => QueryString != null;

        /// <summary>
        /// Represents a regex query substitution rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.QueryRegexSubstitutionRule? QueryRegex { get; init; }
#else
        public global::G.QueryRegexSubstitutionRule? QueryRegex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueryRegex))]
#endif
        public bool IsQueryRegex => QueryRegex != null;

        /// <summary>
        /// Represents a chunk search result rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChunkSearchResultRule? ChunkSearchResult { get; init; }
#else
        public global::G.ChunkSearchResultRule? ChunkSearchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChunkSearchResult))]
#endif
        public bool IsChunkSearchResult => ChunkSearchResult != null;

        /// <summary>
        /// Represents a file search result rule for a vector store search.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileSearchResultRule? FileSearchResult { get; init; }
#else
        public global::G.FileSearchResultRule? FileSearchResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchResult))]
#endif
        public bool IsFileSearchResult => FileSearchResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Rule2(global::G.QueryStringSubstitutionRule value) => new Rule2((global::G.QueryStringSubstitutionRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.QueryStringSubstitutionRule?(Rule2 @this) => @this.QueryString;

        /// <summary>
        /// 
        /// </summary>
        public Rule2(global::G.QueryStringSubstitutionRule? value)
        {
            QueryString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Rule2(global::G.QueryRegexSubstitutionRule value) => new Rule2((global::G.QueryRegexSubstitutionRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.QueryRegexSubstitutionRule?(Rule2 @this) => @this.QueryRegex;

        /// <summary>
        /// 
        /// </summary>
        public Rule2(global::G.QueryRegexSubstitutionRule? value)
        {
            QueryRegex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Rule2(global::G.ChunkSearchResultRule value) => new Rule2((global::G.ChunkSearchResultRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChunkSearchResultRule?(Rule2 @this) => @this.ChunkSearchResult;

        /// <summary>
        /// 
        /// </summary>
        public Rule2(global::G.ChunkSearchResultRule? value)
        {
            ChunkSearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Rule2(global::G.FileSearchResultRule value) => new Rule2((global::G.FileSearchResultRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSearchResultRule?(Rule2 @this) => @this.FileSearchResult;

        /// <summary>
        /// 
        /// </summary>
        public Rule2(global::G.FileSearchResultRule? value)
        {
            FileSearchResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Rule2(
            global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType? type,
            global::G.QueryStringSubstitutionRule? queryString,
            global::G.QueryRegexSubstitutionRule? queryRegex,
            global::G.ChunkSearchResultRule? chunkSearchResult,
            global::G.FileSearchResultRule? fileSearchResult
            )
        {
            Type = type;

            QueryString = queryString;
            QueryRegex = queryRegex;
            ChunkSearchResult = chunkSearchResult;
            FileSearchResult = fileSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileSearchResult as object ??
            ChunkSearchResult as object ??
            QueryRegex as object ??
            QueryString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            QueryString?.ToString() ??
            QueryRegex?.ToString() ??
            ChunkSearchResult?.ToString() ??
            FileSearchResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsQueryString && !IsQueryRegex && !IsChunkSearchResult && !IsFileSearchResult || !IsQueryString && IsQueryRegex && !IsChunkSearchResult && !IsFileSearchResult || !IsQueryString && !IsQueryRegex && IsChunkSearchResult && !IsFileSearchResult || !IsQueryString && !IsQueryRegex && !IsChunkSearchResult && IsFileSearchResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.QueryStringSubstitutionRule?, TResult>? queryString = null,
            global::System.Func<global::G.QueryRegexSubstitutionRule?, TResult>? queryRegex = null,
            global::System.Func<global::G.ChunkSearchResultRule?, TResult>? chunkSearchResult = null,
            global::System.Func<global::G.FileSearchResultRule?, TResult>? fileSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQueryString && queryString != null)
            {
                return queryString(QueryString!);
            }
            else if (IsQueryRegex && queryRegex != null)
            {
                return queryRegex(QueryRegex!);
            }
            else if (IsChunkSearchResult && chunkSearchResult != null)
            {
                return chunkSearchResult(ChunkSearchResult!);
            }
            else if (IsFileSearchResult && fileSearchResult != null)
            {
                return fileSearchResult(FileSearchResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.QueryStringSubstitutionRule?>? queryString = null,
            global::System.Action<global::G.QueryRegexSubstitutionRule?>? queryRegex = null,
            global::System.Action<global::G.ChunkSearchResultRule?>? chunkSearchResult = null,
            global::System.Action<global::G.FileSearchResultRule?>? fileSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsQueryString)
            {
                queryString?.Invoke(QueryString!);
            }
            else if (IsQueryRegex)
            {
                queryRegex?.Invoke(QueryRegex!);
            }
            else if (IsChunkSearchResult)
            {
                chunkSearchResult?.Invoke(ChunkSearchResult!);
            }
            else if (IsFileSearchResult)
            {
                fileSearchResult?.Invoke(FileSearchResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                QueryString,
                typeof(global::G.QueryStringSubstitutionRule),
                QueryRegex,
                typeof(global::G.QueryRegexSubstitutionRule),
                ChunkSearchResult,
                typeof(global::G.ChunkSearchResultRule),
                FileSearchResult,
                typeof(global::G.FileSearchResultRule),
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
        public bool Equals(Rule2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.QueryStringSubstitutionRule?>.Default.Equals(QueryString, other.QueryString) &&
                global::System.Collections.Generic.EqualityComparer<global::G.QueryRegexSubstitutionRule?>.Default.Equals(QueryRegex, other.QueryRegex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChunkSearchResultRule?>.Default.Equals(ChunkSearchResult, other.ChunkSearchResult) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FileSearchResultRule?>.Default.Equals(FileSearchResult, other.FileSearchResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Rule2 obj1, Rule2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Rule2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Rule2 obj1, Rule2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Rule2 o && Equals(o);
        }
    }
}
