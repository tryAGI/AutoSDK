//HintName: G.IAdminClient.GetMergeStatusAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetMergeStatus<br/>
        /// GetMergeStatus
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetMergeStatusAsAdminAsync(
            global::G.GetMergeStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetMergeStatus<br/>
        /// GetMergeStatus
        /// </summary>
        /// <param name="mergedProjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetMergeStatusAsAdminAsync(
            global::System.Guid mergedProjectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}