//HintName: G.IActionsClient.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove a custom label from a self-hosted runner for an organization<br/>
        /// Remove a custom label from a self-hosted runner configured<br/>
        /// in an organization. Returns the remaining labels from the runner.<br/>
        /// This endpoint returns a `404 Not Found` status if the custom label is not<br/>
        /// present on the runner.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgResponse> ActionsRemoveCustomLabelFromSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}