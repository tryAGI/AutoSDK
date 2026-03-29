//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for deleting a specific rule from a search rule array.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams
    {
        /// <summary>
        /// The specific rule to delete from the rules array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Rule2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Rule2 Rule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams" /> class.
        /// </summary>
        /// <param name="rule">
        /// The specific rule to delete from the rules array
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams(
            global::G.Rule2 rule)
        {
            this.Rule = rule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams()
        {
        }
    }
}