//HintName: G.IResourceClient.GetDocumentSearchJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetDocumentSearchJobResult<br/>
        /// GetDocumentSearchJobResult
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetDocumentSearchJobResultAsync(
            global::G.GetDocumentSearchJobResultRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetDocumentSearchJobResult<br/>
        /// GetDocumentSearchJobResult
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetDocumentSearchJobResultAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}