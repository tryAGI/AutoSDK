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
        [global::Newtonsoft.Json.JsonProperty("trace_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> TraceIds { get; set; } = default!;

        /// <summary>
        /// Options for enriching trace data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enrichment_options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TraceEnrichmentOptions EnrichmentOptions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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