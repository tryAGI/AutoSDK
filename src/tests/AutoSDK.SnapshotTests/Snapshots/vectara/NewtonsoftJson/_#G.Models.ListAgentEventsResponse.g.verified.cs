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
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentEvent> Events { get; set; } = default!;

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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