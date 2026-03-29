//HintName: G.Models.CreateDatasetItemsFromSpansRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetItemsFromSpansRequest
    {
        /// <summary>
        /// Set of span IDs to add to the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SpanIds { get; set; }

        /// <summary>
        /// Options for enriching span data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichment_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpanEnrichmentOptions EnrichmentOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromSpansRequest" /> class.
        /// </summary>
        /// <param name="spanIds">
        /// Set of span IDs to add to the dataset
        /// </param>
        /// <param name="enrichmentOptions">
        /// Options for enriching span data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetItemsFromSpansRequest(
            global::System.Collections.Generic.IList<global::System.Guid> spanIds,
            global::G.SpanEnrichmentOptions enrichmentOptions)
        {
            this.SpanIds = spanIds ?? throw new global::System.ArgumentNullException(nameof(spanIds));
            this.EnrichmentOptions = enrichmentOptions ?? throw new global::System.ArgumentNullException(nameof(enrichmentOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromSpansRequest" /> class.
        /// </summary>
        public CreateDatasetItemsFromSpansRequest()
        {
        }
    }
}