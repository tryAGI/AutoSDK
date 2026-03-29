//HintName: G.Models.GetWorkflowVersionExecutionResultsResponseVariant14.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowVersionExecutionResultsResponseVariant14
    {
        /// <summary>
        /// The status of the node execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The output value of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Error message if the node failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Raw error message if the node failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_error_message")]
        public string? RawErrorMessage { get; set; }

        /// <summary>
        /// Whether this node is an output node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_output_node")]
        public bool? IsOutputNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowVersionExecutionResultsResponseVariant14" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the node execution.
        /// </param>
        /// <param name="value">
        /// The output value of the node.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the node failed.
        /// </param>
        /// <param name="rawErrorMessage">
        /// Raw error message if the node failed.
        /// </param>
        /// <param name="isOutputNode">
        /// Whether this node is an output node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowVersionExecutionResultsResponseVariant14(
            string? status,
            object? value,
            string? errorMessage,
            string? rawErrorMessage,
            bool? isOutputNode)
        {
            this.Status = status;
            this.Value = value;
            this.ErrorMessage = errorMessage;
            this.RawErrorMessage = rawErrorMessage;
            this.IsOutputNode = isOutputNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowVersionExecutionResultsResponseVariant14" /> class.
        /// </summary>
        public GetWorkflowVersionExecutionResultsResponseVariant14()
        {
        }
    }
}