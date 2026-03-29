//HintName: G.Models.QueryStringSubstitutionRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a string query substitution rule for a vector store search.
    /// </summary>
    public sealed partial class QueryStringSubstitutionRule
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
        /// <default>"query_string"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "query_string";

        /// <summary>
        /// The substitution to apply
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("substitution", Required = global::Newtonsoft.Json.Required.Always)]
        public string Substitution { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryStringSubstitutionRule" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to trigger the rule
        /// </param>
        /// <param name="storeId">
        /// The store identifier to apply the rule to
        /// </param>
        /// <param name="substitution">
        /// The substitution to apply
        /// </param>
        /// <param name="type">
        /// The type of substitution
        /// </param>
        public QueryStringSubstitutionRule(
            string query,
            string storeId,
            string substitution,
            string type = "query_string")
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Type = type;
            this.Substitution = substitution ?? throw new global::System.ArgumentNullException(nameof(substitution));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryStringSubstitutionRule" /> class.
        /// </summary>
        public QueryStringSubstitutionRule()
        {
        }
    }
}