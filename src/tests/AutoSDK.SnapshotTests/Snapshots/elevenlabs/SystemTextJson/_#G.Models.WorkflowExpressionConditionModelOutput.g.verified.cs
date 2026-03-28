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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: expression
        /// </summary>
        /// <default>"expression"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "expression";

        /// <summary>
        /// Expression to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Expression2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Expression2 Expression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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