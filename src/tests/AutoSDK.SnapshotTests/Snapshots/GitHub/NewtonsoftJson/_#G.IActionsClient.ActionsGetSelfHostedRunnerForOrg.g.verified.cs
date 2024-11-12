//HintName: G.IActionsClient.ActionsGetSelfHostedRunnerForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a self-hosted runner for an organization<br/>
        /// Gets a specific self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Runner> ActionsGetSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}