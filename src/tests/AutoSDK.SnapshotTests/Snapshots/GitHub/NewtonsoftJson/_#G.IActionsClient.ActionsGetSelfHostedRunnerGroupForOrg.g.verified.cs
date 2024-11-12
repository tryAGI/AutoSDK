//HintName: G.IActionsClient.ActionsGetSelfHostedRunnerGroupForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a self-hosted runner group for an organization<br/>
        /// Gets a specific self-hosted runner group for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsGetSelfHostedRunnerGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}