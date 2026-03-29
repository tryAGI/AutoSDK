//HintName: G.Models.TraceEnrichmentOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for enriching trace data
    /// </summary>
    public sealed partial class TraceEnrichmentOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeSpans")]
        public bool? IncludeSpans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeTags")]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeFeedbackScores")]
        public bool? IncludeFeedbackScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeComments")]
        public bool? IncludeComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeUsage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeMetadata")]
        public bool? IncludeMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceEnrichmentOptions" /> class.
        /// </summary>
        /// <param name="includeSpans"></param>
        /// <param name="includeTags"></param>
        /// <param name="includeFeedbackScores"></param>
        /// <param name="includeComments"></param>
        /// <param name="includeUsage"></param>
        /// <param name="includeMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceEnrichmentOptions(
            bool? includeSpans,
            bool? includeTags,
            bool? includeFeedbackScores,
            bool? includeComments,
            bool? includeUsage,
            bool? includeMetadata)
        {
            this.IncludeSpans = includeSpans;
            this.IncludeTags = includeTags;
            this.IncludeFeedbackScores = includeFeedbackScores;
            this.IncludeComments = includeComments;
            this.IncludeUsage = includeUsage;
            this.IncludeMetadata = includeMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceEnrichmentOptions" /> class.
        /// </summary>
        public TraceEnrichmentOptions()
        {
        }
    }
}