//HintName: G.Models.RunWorkflowResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response after initiating a workflow execution.
    /// </summary>
    public sealed partial class RunWorkflowResponse
    {
        /// <summary>
        /// Indicates if the request was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// A message describing the result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Any warnings about missing input variables.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// The ID of the created workflow execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version_execution_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowVersionExecutionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunWorkflowResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates if the request was successful.
        /// </param>
        /// <param name="message">
        /// A message describing the result.
        /// </param>
        /// <param name="workflowVersionExecutionId">
        /// The ID of the created workflow execution.
        /// </param>
        /// <param name="warning">
        /// Any warnings about missing input variables.
        /// </param>
        public RunWorkflowResponse(
            bool success,
            string message,
            int workflowVersionExecutionId,
            string? warning)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Warning = warning;
            this.WorkflowVersionExecutionId = workflowVersionExecutionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunWorkflowResponse" /> class.
        /// </summary>
        public RunWorkflowResponse()
        {
        }
    }
}