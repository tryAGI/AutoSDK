//HintName: G.IProjectClient.GetProjectImportStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetProjectImportStatus<br/>
        /// GetProjectImportStatus
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectImportStatus> GetProjectImportStatusAsync(
            global::G.GetProjectImportStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetProjectImportStatus<br/>
        /// GetProjectImportStatus
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectImportStatus> GetProjectImportStatusAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}