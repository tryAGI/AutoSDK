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
        [global::Newtonsoft.Json.JsonProperty("rule", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Rule2 Rule { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParams" /> class.
        /// </summary>
        /// <param name="rule">
        /// The specific rule to delete from the rules array
        /// </param>
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