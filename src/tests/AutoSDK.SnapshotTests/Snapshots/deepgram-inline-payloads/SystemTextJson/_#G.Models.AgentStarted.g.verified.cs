//HintName: G.Models.AgentStarted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the agent has started.
    /// </summary>
    public sealed partial class AgentStarted
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"AgentStarted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "AgentStarted";

        /// <summary>
        /// The agent identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The session identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStarted" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="agentId">
        /// The agent identifier.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentStarted(
            string agentId,
            string? sessionId,
            string type = "AgentStarted")
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Type = type;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStarted" /> class.
        /// </summary>
        public AgentStarted()
        {
        }
    }
}