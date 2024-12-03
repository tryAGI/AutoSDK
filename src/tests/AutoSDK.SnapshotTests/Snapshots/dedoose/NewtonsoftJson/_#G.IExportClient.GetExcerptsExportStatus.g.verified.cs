//HintName: G.IExportClient.GetExcerptsExportStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// GetExcerptsExportStatus<br/>
        /// GetExcerptsExportStatus
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> GetExcerptsExportStatusAsync(
            global::G.GetExcerptsExportStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExcerptsExportStatus<br/>
        /// GetExcerptsExportStatus
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> GetExcerptsExportStatusAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}