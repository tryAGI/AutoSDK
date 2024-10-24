//HintName: G.IActionsClient.ActionsListSelfHostedRunnerGroupsForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List self-hosted runner groups for an organization<br/>
        /// Lists all self-hosted runner groups configured in an organization and inherited from an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="visibleToRepository"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsListSelfHostedRunnerGroupsForOrgResponse> ActionsListSelfHostedRunnerGroupsForOrgAsync(
            string org,
            int? perPage = default,
            int? page = default,
            string? visibleToRepository = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}