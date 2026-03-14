//HintName: G.Models.ListAgentScheduleExecutionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a paginated list of schedule execution attempts.
    /// </summary>
    public sealed partial class ListAgentScheduleExecutionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("executions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentScheduleExecution> Executions { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ListAgentScheduleExecutionsResponse" /> class.
        /// </summary>
        /// <param name="executions"></param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
        public ListAgentScheduleExecutionsResponse(
            global::System.Collections.Generic.IList<global::G.AgentScheduleExecution> executions,
            global::G.ListMetadata metadata)
        {
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentScheduleExecutionsResponse" /> class.
        /// </summary>
        public ListAgentScheduleExecutionsResponse()
        {
        }
    }
}