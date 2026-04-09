//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter))]
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator(
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator()
        {
        }
    }
}