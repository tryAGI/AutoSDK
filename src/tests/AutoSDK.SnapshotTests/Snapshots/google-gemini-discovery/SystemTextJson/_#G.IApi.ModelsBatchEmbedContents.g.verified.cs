//HintName: G.IApi.ModelsBatchEmbedContents.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Generates multiple embedding vectors from the input `Content` which consists of a batch of strings represented as `EmbedContentRequest` objects.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> ModelsBatchEmbedContentsAsync(
            string modelsId,

            global::G.BatchEmbedContentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates multiple embedding vectors from the input `Content` which consists of a batch of strings represented as `EmbedContentRequest` objects.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="requests">
        /// Required. Embed requests for the batch. The model in each of these requests must match the model specified `BatchEmbedContentsRequest.model`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> ModelsBatchEmbedContentsAsync(
            string modelsId,
            global::System.Collections.Generic.IList<global::G.EmbedContentRequest>? requests = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}