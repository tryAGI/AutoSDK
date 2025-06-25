//HintName: G.IActionsClient.ActionsCreateSelfHostedRunnerGroupForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Create a self-hosted runner group for an organization<br/>
        /// Creates a new self-hosted runner group for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsCreateSelfHostedRunnerGroupForOrgAsync(
            string org,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a self-hosted runner group for an organization<br/>
        /// Creates a new self-hosted runner group for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// Name of the runner group.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs that can access the runner group.
        /// </param>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
        /// <param name="allowsPublicRepositories">
        /// Whether the runner group can be used by `public` repositories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="restrictedToWorkflows">
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="selectedWorkflows">
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsCreateSelfHostedRunnerGroupForOrgAsync(
            string org,
            string name,
            global::G.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility? visibility = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Collections.Generic.IList<int>? runners = default,
            bool? allowsPublicRepositories = default,
            bool? restrictedToWorkflows = default,
            global::System.Collections.Generic.IList<string>? selectedWorkflows = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}