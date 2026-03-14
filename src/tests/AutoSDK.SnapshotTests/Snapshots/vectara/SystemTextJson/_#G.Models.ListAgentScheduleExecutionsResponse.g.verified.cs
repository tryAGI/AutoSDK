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
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentScheduleExecution> Executions { get; set; }

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
        /// Initializes a new instance of the <see cref="ListAgentScheduleExecutionsResponse" /> class.
        /// </summary>
        /// <param name="executions"></param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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