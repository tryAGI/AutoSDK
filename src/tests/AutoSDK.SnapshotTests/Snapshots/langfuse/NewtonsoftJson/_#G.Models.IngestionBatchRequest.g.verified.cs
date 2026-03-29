//HintName: G.Models.IngestionBatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IngestionBatchRequest
    {
        /// <summary>
        /// Batch of tracing events to be ingested. Discriminated by attribute `type`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.IngestionEvent> Batch { get; set; } = default!;

        /// <summary>
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionBatchRequest" /> class.
        /// </summary>
        /// <param name="batch">
        /// Batch of tracing events to be ingested. Discriminated by attribute `type`.
        /// </param>
        /// <param name="metadata">
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </param>
        public IngestionBatchRequest(
            global::System.Collections.Generic.IList<global::G.IngestionEvent> batch,
            object? metadata)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionBatchRequest" /> class.
        /// </summary>
        public IngestionBatchRequest()
        {
        }
    }
}