//HintName: G.IActionsClient.ActionsSetRepoAccessToSelfHostedRunnerGroupInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set repository access for a self-hosted runner group in an organization<br/>
        /// Replaces the list of repositories that have access to a self-hosted runner group configured in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgAsync(
            string org,
            int runnerGroupId,

            global::G.ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set repository access for a self-hosted runner group in an organization<br/>
        /// Replaces the list of repositories that have access to a self-hosted runner group configured in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs that can access the runner group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgAsync(
            string org,
            int runnerGroupId,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}