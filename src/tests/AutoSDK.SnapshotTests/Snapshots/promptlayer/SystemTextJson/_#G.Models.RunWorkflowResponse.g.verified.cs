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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// A message describing the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Any warnings about missing input variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// The ID of the created workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowVersionExecutionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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