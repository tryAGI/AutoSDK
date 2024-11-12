//HintName: G.IApi.BatchEmbedContents.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Generates multiple embeddings from the model given input text in a synchronous call.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: embedding-001
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> BatchEmbedContentsAsync(
            string modelId,
            global::G.BatchEmbedContentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates multiple embeddings from the model given input text in a synchronous call.
        /// </summary>
        /// <param name="modelId">
        /// Default Value: embedding-001
        /// </param>
        /// <param name="requests">
        /// Required. Embed requests for the batch. The model in each of these requests must match the model specified `BatchEmbedContentsRequest.model`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> BatchEmbedContentsAsync(
            string modelId,
            global::System.Collections.Generic.IList<global::G.EmbedContentRequest>? requests = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}