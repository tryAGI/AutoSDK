//HintName: G.Models.WorkflowResultConditionModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowResultConditionModelInput
    {
        /// <summary>
        /// Optional human-readable label for the condition used throughout the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowResultConditionModelInput" /> class.
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
        public WorkflowResultConditionModelInput(
            bool successful,
            string? label,
            string? type)
        {
            this.Label = label;
            this.Type = type;
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultConditionModelInput" /> class.
        /// </summary>
        public WorkflowResultConditionModelInput()
        {
        }
    }
}