//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter))]
        public global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator(
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminator()
        {
        }
    }
}