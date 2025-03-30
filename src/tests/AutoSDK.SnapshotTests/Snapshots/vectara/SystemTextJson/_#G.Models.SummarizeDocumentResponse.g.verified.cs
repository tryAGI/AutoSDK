//HintName: G.Models.SummarizeDocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing the summary of a document
    /// </summary>
    public sealed partial class SummarizeDocumentResponse
    {
        /// <summary>
        /// The summary of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The rendered prompt sent to the LLM. Useful when `prompt_template` is sent in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_prompt")]
        public string? RenderedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeDocumentResponse" /> class.
        /// </summary>
        /// <param name="summary">
        /// The summary of the document
        /// </param>
        /// <param name="renderedPrompt">
        /// The rendered prompt sent to the LLM. Useful when `prompt_template` is sent in the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizeDocumentResponse(
            string? summary,
            string? renderedPrompt)
        {
            this.Summary = summary;
            this.RenderedPrompt = renderedPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeDocumentResponse" /> class.
        /// </summary>
        public SummarizeDocumentResponse()
        {
        }
    }
}