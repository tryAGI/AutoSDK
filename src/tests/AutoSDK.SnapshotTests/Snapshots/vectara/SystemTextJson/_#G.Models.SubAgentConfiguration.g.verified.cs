//HintName: G.Models.SubAgentConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User-configurable settings for the sub-agent tool. These parameters are never exposed to the agent.
    /// </summary>
    public sealed partial class SubAgentConfiguration
    {
        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// Controls session behavior for sub-agent invocations:<br/>
        /// - llm_controlled: LLM decides whether to create new or resume existing session<br/>
        /// - persistent: Always reuse the same session (created on first invocation)<br/>
        /// - ephemeral: Always create a new session on each invocation<br/>
        /// Default Value: ephemeral<br/>
        /// Example: ephemeral
        /// </summary>
        /// <example>ephemeral</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubAgentSessionModeJsonConverter))]
        public global::G.SubAgentSessionMode? SessionMode { get; set; }

        /// <summary>
        /// Optional metadata to associate with the sub-agent session. Can contain any key-value pairs.<br/>
        /// Default Value: {}<br/>
        /// Example: {"source":"parent_agent","task_type":"code_review"}
        /// </summary>
        /// <example>{"source":"parent_agent","task_type":"code_review"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_metadata")]
        public object? SessionMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentConfiguration" /> class.
        /// </summary>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionMode">
        /// Controls session behavior for sub-agent invocations:<br/>
        /// - llm_controlled: LLM decides whether to create new or resume existing session<br/>
        /// - persistent: Always reuse the same session (created on first invocation)<br/>
        /// - ephemeral: Always create a new session on each invocation<br/>
        /// Default Value: ephemeral<br/>
        /// Example: ephemeral
        /// </param>
        /// <param name="sessionMetadata">
        /// Optional metadata to associate with the sub-agent session. Can contain any key-value pairs.<br/>
        /// Default Value: {}<br/>
        /// Example: {"source":"parent_agent","task_type":"code_review"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubAgentConfiguration(
            string agentKey,
            global::G.SubAgentSessionMode? sessionMode,
            object? sessionMetadata)
        {
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.SessionMode = sessionMode;
            this.SessionMetadata = sessionMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentConfiguration" /> class.
        /// </summary>
        public SubAgentConfiguration()
        {
        }
    }
}