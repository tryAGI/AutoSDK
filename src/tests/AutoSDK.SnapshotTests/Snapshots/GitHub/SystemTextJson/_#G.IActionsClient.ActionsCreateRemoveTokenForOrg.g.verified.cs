//HintName: G.IActionsClient.ActionsCreateRemoveTokenForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Create a remove token for an organization<br/>
        /// Returns a token that you can pass to the `config` script to remove a self-hosted runner from an organization. The token expires after one hour.<br/>
        /// For example, you can replace `TOKEN` in the following example with the registration token provided by this endpoint to remove your self-hosted runner from an organization:<br/>
        /// ```<br/>
        /// ./config.sh remove --token TOKEN<br/>
        /// ```<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AuthenticationToken> ActionsCreateRemoveTokenForOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}