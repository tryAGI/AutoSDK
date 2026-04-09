//HintName: G.IApi.ModelsAsyncBatchEmbedContent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Enqueues a batch of `EmbedContent` requests for batch processing. We have a `BatchEmbedContents` handler in `GenerativeService`, but it was synchronized. So we name this one to be `Async` to avoid confusion.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Operation> ModelsAsyncBatchEmbedContentAsync(
            string modelsId,

            global::G.AsyncBatchEmbedContentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enqueues a batch of `EmbedContent` requests for batch processing. We have a `BatchEmbedContents` handler in `GenerativeService`, but it was synchronized. So we name this one to be `Async` to avoid confusion.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="batch">
        /// A resource representing a batch of `EmbedContent` requests.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Operation> ModelsAsyncBatchEmbedContentAsync(
            string modelsId,
            global::G.EmbedContentBatch? batch = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}