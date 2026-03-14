//HintName: G.Models.HallucinationCorrectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The request to detect and correct hallucinations in generated text.
    /// </summary>
    public sealed partial class HallucinationCorrectionRequest
    {
        /// <summary>
        /// The generated text to be evaluated. The hallucination corrector reviews this text and applies corrections based on the provided source documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string GeneratedText { get; set; } = default!;

        /// <summary>
        /// The source documents that were used to generate the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HcmSourceDocument> Documents { get; set; } = default!;

        /// <summary>
        /// The name of the LLM model to use for hallucination correction.<br/>
        /// Example: vhc-large-1.0
        /// </summary>
        /// <example>vhc-large-1.0</example>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// Optional query that provides context for the expected response format and factual information. When provided, enables query-aware hallucination correction that considers the specific response format and factual context expected for the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrectionRequest" /> class.
        /// </summary>
        /// <param name="generatedText">
        /// The generated text to be evaluated. The hallucination corrector reviews this text and applies corrections based on the provided source documents.
        /// </param>
        /// <param name="documents">
        /// The source documents that were used to generate the text.
        /// </param>
        /// <param name="modelName">
        /// The name of the LLM model to use for hallucination correction.<br/>
        /// Example: vhc-large-1.0
        /// </param>
        /// <param name="query">
        /// Optional query that provides context for the expected response format and factual information. When provided, enables query-aware hallucination correction that considers the specific response format and factual context expected for the query.
        /// </param>
        public HallucinationCorrectionRequest(
            string generatedText,
            global::System.Collections.Generic.IList<global::G.HcmSourceDocument> documents,
            string modelName,
            string? query)
        {
            this.GeneratedText = generatedText ?? throw new global::System.ArgumentNullException(nameof(generatedText));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrectionRequest" /> class.
        /// </summary>
        public HallucinationCorrectionRequest()
        {
        }
    }
}