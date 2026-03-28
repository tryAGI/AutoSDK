//HintName: G.Models.WorkflowExpressionConditionModelInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExpressionConditionModelInput
    {
        /// <summary>
        /// Optional human-readable label for the condition used throughout the UI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: expression
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Expression to evaluate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expression", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Expression { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExpressionConditionModelInput" /> class.
        /// </summary>
        /// <param name="expression">
        /// Expression to evaluate.
        /// </param>
        /// <param name="label">
        /// Optional human-readable label for the condition used throughout the UI.
        /// </param>
        /// <param name="type">
        /// Default Value: expression
        /// </param>
        public WorkflowExpressionConditionModelInput(
            global::G.Expression expression,
            string? label,
            string? type)
        {
            this.Label = label;
            this.Type = type;
            this.Expression = expression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExpressionConditionModelInput" /> class.
        /// </summary>
        public WorkflowExpressionConditionModelInput()
        {
        }
    }
}