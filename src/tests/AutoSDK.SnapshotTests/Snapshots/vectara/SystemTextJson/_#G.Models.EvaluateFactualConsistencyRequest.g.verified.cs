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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public global::G.EvaluateFactualConsistencyRequestModelParameters? ModelParameters { get; set; }

        /// <summary>
        /// The generated text (e.g., summary or answer) to evaluate for factual consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedText { get; set; }

        /// <summary>
        /// The source documents or text snippets against which to evaluate factual consistency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_texts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SourceTexts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyRequest" /> class.
        /// </summary>
        /// <param name="modelParameters">
        /// The model parameters for the evaluation.
        /// </param>
        /// <param name="generatedText">
        /// The generated text (e.g., summary or answer) to evaluate for factual consistency.
        /// </param>
        /// <param name="sourceTexts">
        /// The source documents or text snippets against which to evaluate factual consistency.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluateFactualConsistencyRequest(
            string generatedText,
            global::System.Collections.Generic.IList<string> sourceTexts,
            global::G.EvaluateFactualConsistencyRequestModelParameters? modelParameters)
        {
            this.GeneratedText = generatedText ?? throw new global::System.ArgumentNullException(nameof(generatedText));
            this.SourceTexts = sourceTexts ?? throw new global::System.ArgumentNullException(nameof(sourceTexts));
            this.ModelParameters = modelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyRequest" /> class.
        /// </summary>
        public EvaluateFactualConsistencyRequest()
        {
        }
    }
}