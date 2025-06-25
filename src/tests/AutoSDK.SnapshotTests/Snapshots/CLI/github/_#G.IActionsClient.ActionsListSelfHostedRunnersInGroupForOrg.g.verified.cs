//HintName: G.IActionsClient.ActionsListSelfHostedRunnersInGroupForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List self-hosted runners in a group for an organization<br/>
        /// Lists self-hosted runners that are in a specific organization group.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsListSelfHostedRunnersInGroupForOrgResponse> ActionsListSelfHostedRunnersInGroupForOrgAsync(
            string org,
            int runnerGroupId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}