//HintName: G.IProjectClient.GetCopyProjectStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetCopyProjectStatus<br/>
        /// GetCopyProjectStatus
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> GetCopyProjectStatusAsync(
            global::G.GetCopyProjectStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetCopyProjectStatus<br/>
        /// GetCopyProjectStatus
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> GetCopyProjectStatusAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}