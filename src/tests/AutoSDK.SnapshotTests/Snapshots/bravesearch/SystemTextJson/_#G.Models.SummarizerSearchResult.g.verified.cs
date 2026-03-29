//HintName: G.Models.SummarizerSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from the summarizer endpoint.
    /// </summary>
    public sealed partial class SummarizerSearchResult
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Status of the summarization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SummarizerSearchResultStatusJsonConverter))]
        public global::G.SummarizerSearchResultStatus? Status { get; set; }

        /// <summary>
        /// Title of the summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Paragraphs of the summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::G.SummaryMessage>? Summary { get; set; }

        /// <summary>
        /// Enrichment data for the summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichments")]
        public global::G.SummarizerSearchResultEnrichments? Enrichments { get; set; }

        /// <summary>
        /// Follow-up questions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followups")]
        public global::System.Collections.Generic.IList<string>? Followups { get; set; }

        /// <summary>
        /// Information about entities mentioned in the summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities_info")]
        public global::System.Collections.Generic.Dictionary<string, global::G.EntityInfo>? EntitiesInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizerSearchResult" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="status">
        /// Status of the summarization.
        /// </param>
        /// <param name="title">
        /// Title of the summary.
        /// </param>
        /// <param name="summary">
        /// Paragraphs of the summary.
        /// </param>
        /// <param name="enrichments">
        /// Enrichment data for the summary.
        /// </param>
        /// <param name="followups">
        /// Follow-up questions.
        /// </param>
        /// <param name="entitiesInfo">
        /// Information about entities mentioned in the summary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizerSearchResult(
            string? type,
            global::G.SummarizerSearchResultStatus? status,
            string? title,
            global::System.Collections.Generic.IList<global::G.SummaryMessage>? summary,
            global::G.SummarizerSearchResultEnrichments? enrichments,
            global::System.Collections.Generic.IList<string>? followups,
            global::System.Collections.Generic.Dictionary<string, global::G.EntityInfo>? entitiesInfo)
        {
            this.Type = type;
            this.Status = status;
            this.Title = title;
            this.Summary = summary;
            this.Enrichments = enrichments;
            this.Followups = followups;
            this.EntitiesInfo = entitiesInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizerSearchResult" /> class.
        /// </summary>
        public SummarizerSearchResult()
        {
        }
    }
}