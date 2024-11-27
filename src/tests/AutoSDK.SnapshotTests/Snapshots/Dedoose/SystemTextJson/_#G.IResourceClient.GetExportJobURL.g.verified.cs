//HintName: G.IResourceClient.GetExportJobURL.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// GetExportJobURL<br/>
        /// GetExportJobURL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportJobURLAsync(
            global::G.GetExportJobURLRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExportJobURL<br/>
        /// GetExportJobURL
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportJobURLAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}