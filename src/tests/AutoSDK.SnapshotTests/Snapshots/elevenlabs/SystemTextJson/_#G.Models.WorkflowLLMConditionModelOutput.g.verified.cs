//HintName: G.Models.WorkflowLLMConditionModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowLLMConditionModelOutput
    {
        /// <summary>
        /// Optional human-readable label for the condition used throughout the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: llm
        /// </summary>
        /// <default>"llm"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "llm";

        /// <summary>
        /// Condition to evaluate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowLLMConditionModelOutput" /> class.
        /// </summary>
        /// <param name="label">
        /// Optional human-readable label for the condition used throughout the UI.
        /// </param>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
        /// <param name="condition">
        /// Condition to evaluate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowLLMConditionModelOutput(
            string condition,
            string? label,
            string type = "llm")
        {
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Label = label;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowLLMConditionModelOutput" /> class.
        /// </summary>
        public WorkflowLLMConditionModelOutput()
        {
        }
    }
}