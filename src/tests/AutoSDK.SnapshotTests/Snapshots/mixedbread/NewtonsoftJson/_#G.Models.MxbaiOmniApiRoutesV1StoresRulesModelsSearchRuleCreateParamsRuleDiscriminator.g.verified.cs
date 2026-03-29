//HintName: G.Models.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator(
            global::G.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminator()
        {
        }
    }
}