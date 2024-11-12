//HintName: G.IActionsClient.ActionsCreateRegistrationTokenForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Create a registration token for a repository<br/>
        /// Returns a token that you can pass to the `config` script. The token expires after one hour.<br/>
        /// For example, you can replace `TOKEN` in the following example with the registration token provided by this endpoint to configure your self-hosted runner:<br/>
        /// ```<br/>
        /// ./config.sh --url https://github.com/octo-org --token TOKEN<br/>
        /// ```<br/>
        /// Authenticated users must have admin access to the repository to use this endpoint.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AuthenticationToken> ActionsCreateRegistrationTokenForRepoAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}