//HintName: G.IActionsClient.ActionsSetCustomLabelsForSelfHostedRunnerForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set custom labels for a self-hosted runner for an organization<br/>
        /// Remove all previous custom labels and set the new custom labels for a specific<br/>
        /// self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsSetCustomLabelsForSelfHostedRunnerForOrgResponse> ActionsSetCustomLabelsForSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::G.ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set custom labels for a self-hosted runner for an organization<br/>
        /// Remove all previous custom labels and set the new custom labels for a specific<br/>
        /// self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels">
        /// The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsSetCustomLabelsForSelfHostedRunnerForOrgResponse> ActionsSetCustomLabelsForSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}