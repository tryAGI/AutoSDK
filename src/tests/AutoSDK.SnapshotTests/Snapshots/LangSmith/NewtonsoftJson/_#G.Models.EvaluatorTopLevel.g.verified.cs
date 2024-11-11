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
        [global::Newtonsoft.Json.JsonProperty("structured", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvaluatorStructuredOutput Structured { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorTopLevel" /> class.
        /// </summary>
        /// <param name="structured">
        /// Evaluator structured output schema.
        /// </param>
        public EvaluatorTopLevel(
            global::G.EvaluatorStructuredOutput structured)
        {
            this.Structured = structured ?? throw new global::System.ArgumentNullException(nameof(structured));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorTopLevel" /> class.
        /// </summary>
        public EvaluatorTopLevel()
        {
        }
    }
}