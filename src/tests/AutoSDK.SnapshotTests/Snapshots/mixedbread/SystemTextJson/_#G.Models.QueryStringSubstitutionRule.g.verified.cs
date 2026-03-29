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
        /// <default>"query_string"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "query_string";

        /// <summary>
        /// The substitution to apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substitution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Substitution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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