//HintName: G.ITasksClient.TaskResultV1ResultTaskIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Task Result
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ConvertDocumentResponse, global::G.PresignedUrlConvertDocumentResponse, global::G.ChunkDocumentResponse>> TaskResultV1ResultTaskIdGetAsync(
            string taskId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}