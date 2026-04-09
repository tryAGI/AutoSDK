//HintName: G.IAdminClient.CreateAdminTeamsByTeamIDBuildsCancel.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Cancel all builds for a team<br/>
        /// Cancels all in-progress and pending builds for the specified team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminBuildCancelResult> CreateAdminTeamsByTeamIDBuildsCancelAsync(
            global::System.Guid teamID,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}