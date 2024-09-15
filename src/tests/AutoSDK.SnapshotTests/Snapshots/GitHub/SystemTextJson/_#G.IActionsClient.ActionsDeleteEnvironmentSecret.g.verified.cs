//HintName: G.IActionsClient.ActionsDeleteEnvironmentSecret.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete an environment secret<br/>
        /// Deletes a secret in an environment using the secret name.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsDeleteEnvironmentSecretAsync(
            string owner,
            string repo,
            string environmentName,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}