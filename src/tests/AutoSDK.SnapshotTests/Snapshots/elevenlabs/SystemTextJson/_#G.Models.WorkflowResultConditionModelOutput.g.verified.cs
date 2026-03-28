//HintName: G.Models.WorkflowResultConditionModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowResultConditionModelOutput
    {
        /// <summary>
        /// Optional human-readable label for the condition used throughout the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: result
        /// </summary>
        /// <default>"result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "result";

        /// <summary>
        /// Whether all tools in the previously executed tool node were executed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Successful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultConditionModelOutput" /> class.
        /// </summary>
        /// <param name="successful">
        /// Whether all tools in the previously executed tool node were executed successfully.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label for the condition used throughout the UI.
        /// </param>
        /// <param name="type">
        /// Default Value: result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowResultConditionModelOutput(
            bool successful,
            string? label,
            string type = "result")
        {
            this.Label = label;
            this.Type = type;
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultConditionModelOutput" /> class.
        /// </summary>
        public WorkflowResultConditionModelOutput()
        {
        }
    }
}