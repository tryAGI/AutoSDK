//HintName: G.Models.UpdateAgentResponseTestRouteResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentResponseTestRouteResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateAgentResponseTestRouteResponseDiscriminatorTypeJsonConverter))]
        public global::G.UpdateAgentResponseTestRouteResponseDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentResponseTestRouteResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public UpdateAgentResponseTestRouteResponseDiscriminator(
            global::G.UpdateAgentResponseTestRouteResponseDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentResponseTestRouteResponseDiscriminator" /> class.
        /// </summary>
        public UpdateAgentResponseTestRouteResponseDiscriminator()
        {
        }
    }
}