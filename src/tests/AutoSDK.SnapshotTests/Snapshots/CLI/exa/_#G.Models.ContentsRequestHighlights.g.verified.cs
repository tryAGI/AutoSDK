//HintName: G.Models.ContentsRequestHighlights.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text snippets the LLM identifies as most relevant from each page. We recommend you using context instead of highlights for LLMs.
    /// </summary>
    public sealed partial class ContentsRequestHighlights
    {
        /// <summary>
        /// The number of sentences to return for each snippet.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSentences")]
        public int? NumSentences { get; set; }

        /// <summary>
        /// The number of snippets to return for each result.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightsPerUrl")]
        public int? HighlightsPerUrl { get; set; }

        /// <summary>
        /// Custom query to direct the LLM's selection of highlights.<br/>
        /// Example: Key advancements
        /// </summary>
        /// <example>Key advancements</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestHighlights" /> class.
        /// </summary>
        /// <param name="numSentences">
        /// The number of sentences to return for each snippet.<br/>
        /// Example: 1
        /// </param>
        /// <param name="highlightsPerUrl">
        /// The number of snippets to return for each result.<br/>
        /// Example: 1
        /// </param>
        /// <param name="query">
        /// Custom query to direct the LLM's selection of highlights.<br/>
        /// Example: Key advancements
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestHighlights(
            int? numSentences,
            int? highlightsPerUrl,
            string? query)
        {
            this.NumSentences = numSentences;
            this.HighlightsPerUrl = highlightsPerUrl;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestHighlights" /> class.
        /// </summary>
        public ContentsRequestHighlights()
        {
        }
    }
}