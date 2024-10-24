//HintName: G.IActionsClient.ActionsListRepoAccessToSelfHostedRunnerGroupInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List repository access to a self-hosted runner group in an organization<br/>
        /// Lists the repositories with access to a self-hosted runner group configured in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsListRepoAccessToSelfHostedRunnerGroupInOrgResponse> ActionsListRepoAccessToSelfHostedRunnerGroupInOrgAsync(
            string org,
            int runnerGroupId,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}