//HintName: G.Models.CreateAgentSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for creating a new agent session.
    /// </summary>
    public sealed partial class CreateAgentSessionRequest
    {
        /// <summary>
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </summary>
        /// <example>customer_support_chat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </summary>
        /// <example>Customer Support Session</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional description of the session purpose or context.<br/>
        /// Example: Helping customer troubleshoot issues
        /// </summary>
        /// <example>Helping customer troubleshoot issues</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the session.<br/>
        /// Default Value: {}<br/>
        /// Example: {"customer_id":"12345","priority":"medium","channel":"web_chat"}
        /// </summary>
        /// <example>{"customer_id":"12345","priority":"medium","channel":"web_chat"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the session should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tti_minutes")]
        public long? TtiMinutes { get; set; }

        /// <summary>
        /// Create a new session by forking an existing one. Compacts the source history into a summary and copies artifacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_session")]
        public global::G.CreateAgentSessionRequestFromSession? FromSession { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// Optional description of the session purpose or context.<br/>
        /// Example: Helping customer troubleshoot issues
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the session.<br/>
        /// Default Value: {}<br/>
        /// Example: {"customer_id":"12345","priority":"medium","channel":"web_chat"}
        /// </param>
        /// <param name="enabled">
        /// Whether the session should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </param>
        /// <param name="fromSession">
        /// Create a new session by forking an existing one. Compacts the source history into a summary and copies artifacts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionRequest(
            string? key,
            string? name,
            string? description,
            object? metadata,
            bool? enabled,
            long? ttiMinutes,
            global::G.CreateAgentSessionRequestFromSession? fromSession)
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.TtiMinutes = ttiMinutes;
            this.FromSession = fromSession;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequest" /> class.
        /// </summary>
        public CreateAgentSessionRequest()
        {
        }
    }
}