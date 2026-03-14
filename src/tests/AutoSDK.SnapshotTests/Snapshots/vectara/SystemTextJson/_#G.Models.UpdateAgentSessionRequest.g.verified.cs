//HintName: G.Models.UpdateAgentSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for updating an existing agent session.
    /// </summary>
    public sealed partial class UpdateAgentSessionRequest
    {
        /// <summary>
        /// Human-readable name for the session.<br/>
        /// Example: Updated Session Name
        /// </summary>
        /// <example>Updated Session Name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional description of the session purpose or context.<br/>
        /// Example: Updated session description
        /// </summary>
        /// <example>Updated session description</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the session.<br/>
        /// Example: {"customer_id":"12345","priority":"high","status":"escalated"}
        /// </summary>
        /// <example>{"customer_id":"12345","priority":"high","status":"escalated"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the session is enabled.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tti_minutes")]
        public long? TtiMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentSessionRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Updated Session Name
        /// </param>
        /// <param name="description">
        /// Optional description of the session purpose or context.<br/>
        /// Example: Updated session description
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the session.<br/>
        /// Example: {"customer_id":"12345","priority":"high","status":"escalated"}
        /// </param>
        /// <param name="enabled">
        /// Whether the session is enabled.<br/>
        /// Example: false
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Example: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentSessionRequest(
            string? name,
            string? description,
            object? metadata,
            bool? enabled,
            long? ttiMinutes)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.TtiMinutes = ttiMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentSessionRequest" /> class.
        /// </summary>
        public UpdateAgentSessionRequest()
        {
        }
    }
}