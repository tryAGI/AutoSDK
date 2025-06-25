//HintName: G.IActionsClient.ActionsRemoveSelfHostedRunnerFromGroupForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove a self-hosted runner from a group for an organization<br/>
        /// Removes a self-hosted runner from a group configured in an organization. The runner is then returned to the default group.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsRemoveSelfHostedRunnerFromGroupForOrgAsync(
            string org,
            int runnerGroupId,
            int runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}