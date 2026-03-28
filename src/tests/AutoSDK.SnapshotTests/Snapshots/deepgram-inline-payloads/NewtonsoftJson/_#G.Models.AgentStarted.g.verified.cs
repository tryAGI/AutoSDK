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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "AgentStarted";

        /// <summary>
        /// The agent identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The session identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStarted" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The agent identifier.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier.
        /// </param>
        /// <param name="type"></param>
        public AgentStarted(
            string agentId,
            string? sessionId,
            string type = "AgentStarted")
        {
            this.Type = type;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
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