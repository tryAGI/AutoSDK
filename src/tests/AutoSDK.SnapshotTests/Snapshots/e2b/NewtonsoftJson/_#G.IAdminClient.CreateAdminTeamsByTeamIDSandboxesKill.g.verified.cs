//HintName: G.IAdminClient.CreateAdminTeamsByTeamIDSandboxesKill.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// Kill all sandboxes for a team<br/>
        /// Kills all sandboxes for the specified team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminSandboxKillResult> CreateAdminTeamsByTeamIDSandboxesKillAsync(
            global::System.Guid teamID,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}