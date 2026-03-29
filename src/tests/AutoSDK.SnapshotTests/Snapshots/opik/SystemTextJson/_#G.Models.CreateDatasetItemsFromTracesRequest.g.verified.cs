//HintName: G.Models.CreateDatasetItemsFromTracesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetItemsFromTracesRequest
    {
        /// <summary>
        /// Set of trace IDs to add to the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TraceIds { get; set; }

        /// <summary>
        /// Options for enriching trace data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichment_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TraceEnrichmentOptions EnrichmentOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromTracesRequest" /> class.
        /// </summary>
        /// <param name="traceIds">
        /// Set of trace IDs to add to the dataset
        /// </param>
        /// <param name="enrichmentOptions">
        /// Options for enriching trace data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetItemsFromTracesRequest(
            global::System.Collections.Generic.IList<global::System.Guid> traceIds,
            global::G.TraceEnrichmentOptions enrichmentOptions)
        {
            this.TraceIds = traceIds ?? throw new global::System.ArgumentNullException(nameof(traceIds));
            this.EnrichmentOptions = enrichmentOptions ?? throw new global::System.ArgumentNullException(nameof(enrichmentOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromTracesRequest" /> class.
        /// </summary>
        public CreateDatasetItemsFromTracesRequest()
        {
        }
    }
}