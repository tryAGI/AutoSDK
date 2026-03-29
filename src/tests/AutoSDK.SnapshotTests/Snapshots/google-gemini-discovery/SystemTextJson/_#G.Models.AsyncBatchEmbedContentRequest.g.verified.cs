//HintName: G.Models.AsyncBatchEmbedContentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for an `AsyncBatchEmbedContent` operation.
    /// </summary>
    public sealed partial class AsyncBatchEmbedContentRequest
    {
        /// <summary>
        /// A resource representing a batch of `EmbedContent` requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        public global::G.EmbedContentBatch? Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncBatchEmbedContentRequest" /> class.
        /// </summary>
        /// <param name="batch">
        /// A resource representing a batch of `EmbedContent` requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncBatchEmbedContentRequest(
            global::G.EmbedContentBatch? batch)
        {
            this.Batch = batch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncBatchEmbedContentRequest" /> class.
        /// </summary>
        public AsyncBatchEmbedContentRequest()
        {
        }
    }
}