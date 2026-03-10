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
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Whether all tools in the previously executed tool node were executed successfully.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successful", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Successful { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultConditionModelInput" /> class.
        /// </summary>
        /// <param name="label">
        /// Optional human-readable label for the condition used throughout the UI.
        /// </param>
        /// <param name="type">
        /// Default Value: result
        /// </param>
        /// <param name="successful">
        /// Whether all tools in the previously executed tool node were executed successfully.
        /// </param>
        public WorkflowResultConditionModelInput(
            bool successful,
            string? label,
            string? type)
        {
            this.Successful = successful;
            this.Label = label;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultConditionModelInput" /> class.
        /// </summary>
        public WorkflowResultConditionModelInput()
        {
        }
    }
}