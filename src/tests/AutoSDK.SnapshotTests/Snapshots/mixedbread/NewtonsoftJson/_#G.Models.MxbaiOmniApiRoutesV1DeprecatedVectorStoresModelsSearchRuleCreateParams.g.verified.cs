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
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// The rules to apply on query matches
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rules", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RulesItem> Rules { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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