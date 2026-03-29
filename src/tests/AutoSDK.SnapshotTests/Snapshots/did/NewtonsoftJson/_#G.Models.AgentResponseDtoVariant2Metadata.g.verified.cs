//HintName: G.Models.AgentResponseDtoVariant2Metadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentResponseDtoVariant2Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant2Metadata" /> class.
        /// </summary>
        /// <param name="plan"></param>
        public AgentResponseDtoVariant2Metadata(
            string? plan)
        {
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant2Metadata" /> class.
        /// </summary>
        public AgentResponseDtoVariant2Metadata()
        {
        }
    }
}