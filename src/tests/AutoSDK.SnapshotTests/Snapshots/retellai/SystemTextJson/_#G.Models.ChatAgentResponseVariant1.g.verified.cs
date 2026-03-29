//HintName: G.Models.ChatAgentResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAgentResponseVariant1
    {
        /// <summary>
        /// Unique id of chat agent.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </summary>
        /// <example>oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The version of the chat agent.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Whether the chat agent is published.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_published")]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAgentResponseVariant1" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique id of chat agent.<br/>
        /// Example: oBeDLoLOeuAbiuaMFXRtDOLriTJ5tSxD
        /// </param>
        /// <param name="version">
        /// The version of the chat agent.<br/>
        /// Example: 0
        /// </param>
        /// <param name="isPublished">
        /// Whether the chat agent is published.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAgentResponseVariant1(
            string agentId,
            int? version,
            bool? isPublished)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Version = version;
            this.IsPublished = isPublished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAgentResponseVariant1" /> class.
        /// </summary>
        public ChatAgentResponseVariant1()
        {
        }
    }
}