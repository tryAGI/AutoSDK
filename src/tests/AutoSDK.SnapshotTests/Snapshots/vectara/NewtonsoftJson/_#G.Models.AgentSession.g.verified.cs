//HintName: G.Models.AgentSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A session for interacting with an agent, allowing conversation context.
    /// </summary>
    public sealed partial class AgentSession
    {
        /// <summary>
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </summary>
        /// <example>customer_support_chat</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::Newtonsoft.Json.JsonProperty("agent_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentKey { get; set; } = default!;

        /// <summary>
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </summary>
        /// <example>Customer Support Session</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description of the session purpose or context.<br/>
        /// Example: Helping customer troubleshoot widget installation issues
        /// </summary>
        /// <example>Helping customer troubleshoot widget installation issues</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the session.<br/>
        /// Example: {"customer_id":"12345","priority":"high","channel":"web_chat"}
        /// </summary>
        /// <example>{"customer_id":"12345","priority":"high","channel":"web_chat"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The step name the session will resume at on the next user message.<br/>
        /// If null, the session starts at the agent's first_step.<br/>
        /// Example: billing
        /// </summary>
        /// <example>billing</example>
        [global::Newtonsoft.Json.JsonProperty("current_step_name")]
        public string? CurrentStepName { get; set; }

        /// <summary>
        /// Whether the session is currently active and can accept new messages.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If not specified, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::Newtonsoft.Json.JsonProperty("tti_minutes")]
        public long? TtiMinutes { get; set; }

        /// <summary>
        /// Timestamp when the session was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Token usage statistics for a session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_context_usage")]
        public global::G.SessionContextUsage? SessionContextUsage { get; set; }

        /// <summary>
        /// Configuration for automatic context compaction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_compaction")]
        public global::G.CompactionConfig? EffectiveCompaction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSession" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// Optional description of the session purpose or context.<br/>
        /// Example: Helping customer troubleshoot widget installation issues
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the session.<br/>
        /// Example: {"customer_id":"12345","priority":"high","channel":"web_chat"}
        /// </param>
        /// <param name="currentStepName">
        /// The step name the session will resume at on the next user message.<br/>
        /// If null, the session starts at the agent's first_step.<br/>
        /// Example: billing
        /// </param>
        /// <param name="enabled">
        /// Whether the session is currently active and can accept new messages.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If not specified, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the session was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="sessionContextUsage">
        /// Token usage statistics for a session.
        /// </param>
        /// <param name="effectiveCompaction">
        /// Configuration for automatic context compaction.
        /// </param>
        public AgentSession(
            string key,
            string agentKey,
            string name,
            bool enabled,
            global::System.DateTime createdAt,
            string? description,
            object? metadata,
            string? currentStepName,
            long? ttiMinutes,
            global::G.SessionContextUsage? sessionContextUsage,
            global::G.CompactionConfig? effectiveCompaction)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Metadata = metadata;
            this.CurrentStepName = currentStepName;
            this.TtiMinutes = ttiMinutes;
            this.SessionContextUsage = sessionContextUsage;
            this.EffectiveCompaction = effectiveCompaction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSession" /> class.
        /// </summary>
        public AgentSession()
        {
        }
    }
}