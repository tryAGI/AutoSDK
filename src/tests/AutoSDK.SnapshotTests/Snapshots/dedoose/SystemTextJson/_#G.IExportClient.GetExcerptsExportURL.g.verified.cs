//HintName: G.IExportClient.GetExcerptsExportURL.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// GetExcerptsExportURL<br/>
        /// GetExcerptsExportURL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExcerptsExportURLAsync(
            global::G.GetExcerptsExportURLRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExcerptsExportURL<br/>
        /// GetExcerptsExportURL
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetExcerptsExportURLAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}