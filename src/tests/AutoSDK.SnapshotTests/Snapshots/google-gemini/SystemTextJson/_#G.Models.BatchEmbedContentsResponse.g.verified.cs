//HintName: G.Models.BatchEmbedContentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a `BatchEmbedContentsRequest`.
    /// </summary>
    public sealed partial class BatchEmbedContentsResponse
    {
        /// <summary>
        /// Output only. The embeddings for each request, in the same order as provided in the batch request.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        public global::System.Collections.Generic.IList<global::G.ContentEmbedding>? Embeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbedContentsResponse" /> class.
        /// </summary>
        /// <param name="embeddings">
        /// Output only. The embeddings for each request, in the same order as provided in the batch request.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchEmbedContentsResponse(
            global::System.Collections.Generic.IList<global::G.ContentEmbedding>? embeddings)
        {
            this.Embeddings = embeddings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbedContentsResponse" /> class.
        /// </summary>
        public BatchEmbedContentsResponse()
        {
        }
    }
}