//HintName: G.Models.GetToolDependentAgentsResponseModelAgentDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolDependentAgentsResponseModelAgentDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter))]
        public global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDependentAgentsResponseModelAgentDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public GetToolDependentAgentsResponseModelAgentDiscriminator(
            global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDependentAgentsResponseModelAgentDiscriminator" /> class.
        /// </summary>
        public GetToolDependentAgentsResponseModelAgentDiscriminator()
        {
        }
    }
}