//HintName: G.Models.RunWorkflow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to run a workflow.
    /// </summary>
    public sealed partial class RunWorkflow
    {
        /// <summary>
        /// Specify a workflow label name to run a specific labeled version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_label_name")]
        public string? WorkflowLabelName { get; set; }

        /// <summary>
        /// Specify a workflow version number to run a specific version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_number")]
        public int? WorkflowVersionNumber { get; set; }

        /// <summary>
        /// A dictionary of metadata key-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// A dictionary of input variables required by the workflow.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        public object? InputVariables { get; set; }

        /// <summary>
        /// If set to `true`, all outputs from the workflow execution will be returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_all_outputs")]
        public bool? ReturnAllOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunWorkflow" /> class.
        /// </summary>
        /// <param name="workflowLabelName">
        /// Specify a workflow label name to run a specific labeled version.
        /// </param>
        /// <param name="workflowVersionNumber">
        /// Specify a workflow version number to run a specific version.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of metadata key-value pairs.
        /// </param>
        /// <param name="inputVariables">
        /// A dictionary of input variables required by the workflow.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="returnAllOutputs">
        /// If set to `true`, all outputs from the workflow execution will be returned.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunWorkflow(
            string? workflowLabelName,
            int? workflowVersionNumber,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            object? inputVariables,
            bool? returnAllOutputs)
        {
            this.WorkflowLabelName = workflowLabelName;
            this.WorkflowVersionNumber = workflowVersionNumber;
            this.Metadata = metadata;
            this.InputVariables = inputVariables;
            this.ReturnAllOutputs = returnAllOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunWorkflow" /> class.
        /// </summary>
        public RunWorkflow()
        {
        }
    }
}