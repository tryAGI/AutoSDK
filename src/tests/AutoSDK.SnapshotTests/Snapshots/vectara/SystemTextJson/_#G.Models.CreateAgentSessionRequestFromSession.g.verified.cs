//HintName: G.Models.CreateAgentSessionRequestFromSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new session by forking an existing one. Compacts the source history into a summary and copies artifacts.
    /// </summary>
    public sealed partial class CreateAgentSessionRequestFromSession
    {
        /// <summary>
        /// Agent key of the source session (defaults to current agent).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        public string? AgentKey { get; set; }

        /// <summary>
        /// Session key of the source session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionKey { get; set; }

        /// <summary>
        /// Only compact events up to this event ID from the source. If omitted, compacts all events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_up_to_event_id")]
        public string? CompactUpToEventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequestFromSession" /> class.
        /// </summary>
        /// <param name="agentKey">
        /// Agent key of the source session (defaults to current agent).
        /// </param>
        /// <param name="sessionKey">
        /// Session key of the source session.
        /// </param>
        /// <param name="compactUpToEventId">
        /// Only compact events up to this event ID from the source. If omitted, compacts all events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionRequestFromSession(
            string sessionKey,
            string? agentKey,
            string? compactUpToEventId)
        {
            this.SessionKey = sessionKey ?? throw new global::System.ArgumentNullException(nameof(sessionKey));
            this.AgentKey = agentKey;
            this.CompactUpToEventId = compactUpToEventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequestFromSession" /> class.
        /// </summary>
        public CreateAgentSessionRequestFromSession()
        {
        }
    }
}