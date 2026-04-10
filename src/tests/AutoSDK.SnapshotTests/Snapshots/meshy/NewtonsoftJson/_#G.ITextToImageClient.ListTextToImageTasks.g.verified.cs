//HintName: G.ITextToImageClient.ListTextToImageTasks.g.cs
#nullable enable

namespace G
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// List Text to Image tasks
        /// </summary>
        /// <param name="pageNum">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TextToImageTask>> ListTextToImageTasksAsync(
            int? pageNum = default,
            int? pageSize = default,
            global::G.ListTextToImageTasksSortBy? sortBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}