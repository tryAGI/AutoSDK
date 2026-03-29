//HintName: G.Models.AgentResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentResponseVariant1
    {
        /// <summary>
        /// Unique id of agent.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Version of the agent.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Whether the agent is published.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseVariant1" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique id of agent.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="version">
        /// Version of the agent.<br/>
        /// Example: 0
        /// </param>
        /// <param name="isPublished">
        /// Whether the agent is published.<br/>
        /// Example: false
        /// </param>
        public AgentResponseVariant1(
            string agentId,
            int version,
            bool? isPublished)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Version = version;
            this.IsPublished = isPublished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentResponseVariant1" /> class.
        /// </summary>
        public AgentResponseVariant1()
        {
        }
    }
}