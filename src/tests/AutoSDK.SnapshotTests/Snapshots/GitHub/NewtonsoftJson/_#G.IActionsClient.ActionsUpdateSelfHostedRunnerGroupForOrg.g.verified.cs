//HintName: G.IActionsClient.ActionsUpdateSelfHostedRunnerGroupForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Update a self-hosted runner group for an organization<br/>
        /// Updates the `name` and `visibility` of a self-hosted runner group in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsUpdateSelfHostedRunnerGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a self-hosted runner group for an organization<br/>
        /// Updates the `name` and `visibility` of a self-hosted runner group in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="name">
        /// Name of the runner group.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or all private repositories.
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
        global::System.Threading.Tasks.Task<global::G.RunnerGroupsOrg> ActionsUpdateSelfHostedRunnerGroupForOrgAsync(
            string org,
            int runnerGroupId,
            string name,
            global::G.ActionsUpdateSelfHostedRunnerGroupForOrgRequestVisibility? visibility = default,
            bool? allowsPublicRepositories = default,
            bool? restrictedToWorkflows = default,
            global::System.Collections.Generic.IList<string>? selectedWorkflows = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}