//HintName: G.Models.EvaluatorTopLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorTopLevel
    {
        /// <summary>
        /// Evaluator structured output schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvaluatorStructuredOutput Structured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}