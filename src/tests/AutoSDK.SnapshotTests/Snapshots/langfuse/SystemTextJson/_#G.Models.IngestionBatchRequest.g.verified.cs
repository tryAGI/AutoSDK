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
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.IngestionEvent> Batch { get; set; }

        /// <summary>
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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