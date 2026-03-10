//HintName: G.Models.WorkflowLLMConditionModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowLLMConditionModelInput
    {
        /// <summary>
        /// Optional human-readable label for the condition used throughout the UI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Condition to evaluate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public string Condition { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowLLMConditionModelInput" /> class.
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
        public WorkflowLLMConditionModelInput(
            string condition,
            string? label,
            string? type)
        {
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Label = label;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowLLMConditionModelInput" /> class.
        /// </summary>
        public WorkflowLLMConditionModelInput()
        {
        }
    }
}