//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a new search rule.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams
    {
        /// <summary>
        /// The query pattern to match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The rules to apply on query matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RulesItem> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams" /> class.
        /// </summary>
        /// <param name="query">
        /// The query pattern to match
        /// </param>
        /// <param name="rules">
        /// The rules to apply on query matches
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams(
            string query,
            global::System.Collections.Generic.IList<global::G.RulesItem> rules)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParams()
        {
        }
    }
}