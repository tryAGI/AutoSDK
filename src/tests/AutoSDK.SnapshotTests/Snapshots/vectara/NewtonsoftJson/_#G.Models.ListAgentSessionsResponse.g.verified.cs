//HintName: G.Models.ListAgentSessionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of agent sessions.
    /// </summary>
    public sealed partial class ListAgentSessionsResponse
    {
        /// <summary>
        /// List of agent sessions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentSession> Sessions { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ListAgentSessionsResponse" /> class.
        /// </summary>
        /// <param name="sessions">
        /// List of agent sessions.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
        public ListAgentSessionsResponse(
            global::System.Collections.Generic.IList<global::G.AgentSession> sessions,
            global::G.ListMetadata metadata)
        {
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentSessionsResponse" /> class.
        /// </summary>
        public ListAgentSessionsResponse()
        {
        }
    }
}