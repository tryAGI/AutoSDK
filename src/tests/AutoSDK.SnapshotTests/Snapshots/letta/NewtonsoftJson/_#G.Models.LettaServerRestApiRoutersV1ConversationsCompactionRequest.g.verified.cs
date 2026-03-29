//HintName: G.Models.LettaServerRestApiRoutersV1ConversationsCompactionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaServerRestApiRoutersV1ConversationsCompactionRequest
    {
        /// <summary>
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Optional compaction settings to use for this summarization request. If not provided, the agent's default settings will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compaction_settings")]
        public global::G.CompactionSettingsInput? CompactionSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1ConversationsCompactionRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </param>
        /// <param name="compactionSettings">
        /// Optional compaction settings to use for this summarization request. If not provided, the agent's default settings will be used.
        /// </param>
        public LettaServerRestApiRoutersV1ConversationsCompactionRequest(
            string? agentId,
            global::G.CompactionSettingsInput? compactionSettings)
        {
            this.AgentId = agentId;
            this.CompactionSettings = compactionSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1ConversationsCompactionRequest" /> class.
        /// </summary>
        public LettaServerRestApiRoutersV1ConversationsCompactionRequest()
        {
        }
    }
}