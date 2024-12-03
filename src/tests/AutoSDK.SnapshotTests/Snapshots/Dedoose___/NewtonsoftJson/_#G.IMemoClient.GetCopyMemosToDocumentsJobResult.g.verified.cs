//HintName: G.IMemoClient.GetCopyMemosToDocumentsJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// GetCopyMemosToDocumentsJobResult<br/>
        /// GetCopyMemosToDocumentsJobResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCopyMemosToDocumentsJobResultAsync(
            global::G.GetCopyMemosToDocumentsJobResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetCopyMemosToDocumentsJobResult<br/>
        /// GetCopyMemosToDocumentsJobResult
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetCopyMemosToDocumentsJobResultAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}