//HintName: G.IFileClient.GetExportJobFileURI.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetExportJobFileURI<br/>
        /// GetExportJobFileURI
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportJobFileURIAsync(
            global::G.GetExportJobFileURIRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExportJobFileURI<br/>
        /// GetExportJobFileURI
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportJobFileURIAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}