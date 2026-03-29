//HintName: G.Models.AgentResponseDtoVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentResponseDtoVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.AgentResponseDtoVariant2Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Embed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant2" /> class.
        /// </summary>
        /// <param name="embed"></param>
        /// <param name="metadata"></param>
        public AgentResponseDtoVariant2(
            bool embed,
            global::G.AgentResponseDtoVariant2Metadata? metadata)
        {
            this.Metadata = metadata;
            this.Embed = embed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseDtoVariant2" /> class.
        /// </summary>
        public AgentResponseDtoVariant2()
        {
        }
    }
}