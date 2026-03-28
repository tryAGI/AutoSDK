//HintName: G.Models.EvaluateFactualConsistencyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to evaluate the factual consistency of a generated text against source documents.
    /// </summary>
    public sealed partial class EvaluateFactualConsistencyRequest
    {
        /// <summary>
        /// The model parameters for the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_parameters")]
        public global::G.EvaluateFactualConsistencyRequestModelParameters? ModelParameters { get; set; }

        /// <summary>
        /// The generated text (e.g., summary or answer) to evaluate for factual consistency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string GeneratedText { get; set; } = default!;

        /// <summary>
        /// The source documents or text snippets against which to evaluate factual consistency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_texts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SourceTexts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyRequest" /> class.
        /// </summary>
        /// <param name="generatedText">
        /// The generated text (e.g., summary or answer) to evaluate for factual consistency.
        /// </param>
        /// <param name="sourceTexts">
        /// The source documents or text snippets against which to evaluate factual consistency.
        /// </param>
        /// <param name="modelParameters">
        /// The model parameters for the evaluation.
        /// </param>
        public EvaluateFactualConsistencyRequest(
            string generatedText,
            global::System.Collections.Generic.IList<string> sourceTexts,
            global::G.EvaluateFactualConsistencyRequestModelParameters? modelParameters)
        {
            this.ModelParameters = modelParameters;
            this.GeneratedText = generatedText ?? throw new global::System.ArgumentNullException(nameof(generatedText));
            this.SourceTexts = sourceTexts ?? throw new global::System.ArgumentNullException(nameof(sourceTexts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyRequest" /> class.
        /// </summary>
        public EvaluateFactualConsistencyRequest()
        {
        }
    }
}