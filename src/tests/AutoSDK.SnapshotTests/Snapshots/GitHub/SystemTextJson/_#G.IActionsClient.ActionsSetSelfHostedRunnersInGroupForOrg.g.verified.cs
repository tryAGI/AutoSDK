//HintName: G.IActionsClient.ActionsSetSelfHostedRunnersInGroupForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set self-hosted runners in a group for an organization<br/>
        /// Replaces the list of self-hosted runners that are part of an organization runner group.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelfHostedRunnersInGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::G.ActionsSetSelfHostedRunnersInGroupForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set self-hosted runners in a group for an organization<br/>
        /// Replaces the list of self-hosted runners that are part of an organization runner group.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelfHostedRunnersInGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::System.Collections.Generic.IList<int> runners,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}