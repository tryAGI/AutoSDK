//HintName: G.IApi.ModelsBatchGenerateContent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Enqueues a batch of `GenerateContent` requests for batch processing.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Operation> ModelsBatchGenerateContentAsync(
            string modelsId,

            global::G.BatchGenerateContentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enqueues a batch of `GenerateContent` requests for batch processing.
        /// </summary>
        /// <param name="modelsId"></param>
        /// <param name="batch">
        /// A resource representing a batch of `GenerateContent` requests.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Operation> ModelsBatchGenerateContentAsync(
            string modelsId,
            global::G.GenerateContentBatch? batch = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}