//HintName: G.Models.ListAgentEventsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of agent events.
    /// </summary>
    public sealed partial class ListAgentEventsResponse
    {
        /// <summary>
        /// List of agent events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentEvent> Events { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ListMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentEventsResponse" /> class.
        /// </summary>
        /// <param name="events">
        /// List of agent events.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentEventsResponse(
            global::System.Collections.Generic.IList<global::G.AgentEvent> events,
            global::G.ListMetadata metadata)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentEventsResponse" /> class.
        /// </summary>
        public ListAgentEventsResponse()
        {
        }
    }
}