//HintName: G.IActionsClient.ActionsDeleteRepoSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete a repository secret<br/>
        /// Deletes a secret in a repository using the secret name.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsDeleteRepoSecretAsync(
            string owner,
            string repo,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}