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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> ModelsBatchEmbedContentsAsync(
            string modelsId,

            global::G.BatchEmbedContentsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates multiple embedding vectors from the input `Content` which consists of a batch of strings represented as `EmbedContentRequest` objects.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="requests">
        /// Required. Embed requests for the batch. The model in each of these requests must match the model specified `BatchEmbedContentsRequest.model`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchEmbedContentsResponse> ModelsBatchEmbedContentsAsync(
            string modelsId,
            global::System.Collections.Generic.IList<global::G.EmbedContentRequest>? requests = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}