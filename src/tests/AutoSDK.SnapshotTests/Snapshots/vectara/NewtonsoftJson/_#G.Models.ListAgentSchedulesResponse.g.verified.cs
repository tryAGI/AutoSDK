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
        [global::Newtonsoft.Json.JsonProperty("schedules", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentSchedule> Schedules { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ListAgentSchedulesResponse" /> class.
        /// </summary>
        /// <param name="schedules">
        /// Array of agent schedules.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
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