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
        [global::Newtonsoft.Json.JsonProperty("span_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> SpanIds { get; set; } = default!;

        /// <summary>
        /// Options for enriching span data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enrichment_options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpanEnrichmentOptions EnrichmentOptions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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