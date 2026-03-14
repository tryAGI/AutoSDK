//HintName: G.Models.ListAgentSchedulesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of agent schedules with pagination metadata.
    /// </summary>
    public sealed partial class ListAgentSchedulesResponse
    {
        /// <summary>
        /// Array of agent schedules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentSchedule> Schedules { get; set; }

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
        /// Initializes a new instance of the <see cref="ListAgentSchedulesResponse" /> class.
        /// </summary>
        /// <param name="schedules">
        /// Array of agent schedules.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentSchedulesResponse(
            global::System.Collections.Generic.IList<global::G.AgentSchedule> schedules,
            global::G.ListMetadata metadata)
        {
            this.Schedules = schedules ?? throw new global::System.ArgumentNullException(nameof(schedules));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentSchedulesResponse" /> class.
        /// </summary>
        public ListAgentSchedulesResponse()
        {
        }
    }
}