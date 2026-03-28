//HintName: G.Models.WorkflowExpressionConditionModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExpressionConditionModelOutput
    {
        /// <summary>
        /// Optional human-readable label for the condition used throughout the UI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: expression
        /// </summary>
        /// <default>"expression"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "expression";

        /// <summary>
        /// Expression to evaluate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expression", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression2 Expression { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExpressionConditionModelOutput" /> class.
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
        public WorkflowExpressionConditionModelOutput(
            global::G.Expression2 expression,
            string? label,
            string type = "expression")
        {
            this.Label = label;
            this.Type = type;
            this.Expression = expression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExpressionConditionModelOutput" /> class.
        /// </summary>
        public WorkflowExpressionConditionModelOutput()
        {
        }
    }
}