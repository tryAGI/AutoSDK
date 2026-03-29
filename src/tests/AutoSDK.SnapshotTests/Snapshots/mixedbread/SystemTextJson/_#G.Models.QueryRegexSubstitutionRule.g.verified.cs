//HintName: G.Models.QueryRegexSubstitutionRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a regex query substitution rule for a vector store search.
    /// </summary>
    public sealed partial class QueryRegexSubstitutionRule
    {
        /// <summary>
        /// The query to trigger the rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The store identifier to apply the rule to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// The type of substitution
        /// </summary>
        /// <default>"query_regex"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "query_regex";

        /// <summary>
        /// The regex pattern to match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// The regex flags to use<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public global::System.Collections.Generic.IList<global::G.RegexFlag>? Flags { get; set; }

        /// <summary>
        /// The replacement string (can use regex groups)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Replacement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRegexSubstitutionRule" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to trigger the rule
        /// </param>
        /// <param name="storeId">
        /// The store identifier to apply the rule to
        /// </param>
        /// <param name="pattern">
        /// The regex pattern to match
        /// </param>
        /// <param name="replacement">
        /// The replacement string (can use regex groups)
        /// </param>
        /// <param name="flags">
        /// The regex flags to use<br/>
        /// Default Value: []
        /// </param>
        /// <param name="type">
        /// The type of substitution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRegexSubstitutionRule(
            string query,
            string storeId,
            string pattern,
            string replacement,
            global::System.Collections.Generic.IList<global::G.RegexFlag>? flags,
            string type = "query_regex")
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Type = type;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Flags = flags;
            this.Replacement = replacement ?? throw new global::System.ArgumentNullException(nameof(replacement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRegexSubstitutionRule" /> class.
        /// </summary>
        public QueryRegexSubstitutionRule()
        {
        }
    }
}