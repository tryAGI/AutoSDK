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
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The store identifier to apply the rule to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// The type of substitution
        /// </summary>
        /// <default>"query_regex"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "query_regex";

        /// <summary>
        /// The regex pattern to match
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pattern { get; set; } = default!;

        /// <summary>
        /// The regex flags to use<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flags")]
        public global::System.Collections.Generic.IList<global::G.RegexFlag>? Flags { get; set; }

        /// <summary>
        /// The replacement string (can use regex groups)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replacement", Required = global::Newtonsoft.Json.Required.Always)]
        public string Replacement { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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