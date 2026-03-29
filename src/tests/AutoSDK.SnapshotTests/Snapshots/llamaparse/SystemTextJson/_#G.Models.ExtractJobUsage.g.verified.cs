//HintName: G.Models.ExtractJobUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extraction usage metrics.
    /// </summary>
    public sealed partial class ExtractJobUsage
    {
        /// <summary>
        /// Number of pages extracted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_pages_extracted")]
        public int? NumPagesExtracted { get; set; }

        /// <summary>
        /// Number of document tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_document_tokens")]
        public int? NumDocumentTokens { get; set; }

        /// <summary>
        /// Number of output tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_output_tokens")]
        public int? NumOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobUsage" /> class.
        /// </summary>
        /// <param name="numPagesExtracted">
        /// Number of pages extracted
        /// </param>
        /// <param name="numDocumentTokens">
        /// Number of document tokens
        /// </param>
        /// <param name="numOutputTokens">
        /// Number of output tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractJobUsage(
            int? numPagesExtracted,
            int? numDocumentTokens,
            int? numOutputTokens)
        {
            this.NumPagesExtracted = numPagesExtracted;
            this.NumDocumentTokens = numDocumentTokens;
            this.NumOutputTokens = numOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractJobUsage" /> class.
        /// </summary>
        public ExtractJobUsage()
        {
        }
    }
}