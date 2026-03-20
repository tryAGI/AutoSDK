//HintName: G.ICodespacesClient.CodespacesDeleteSecretForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Delete a secret for the authenticated user<br/>
        /// Deletes a development environment secret from a user's codespaces using the secret name. Deleting the secret will remove access from all codespaces that were allowed to access the secret.<br/>
        /// The authenticated user must have Codespaces access to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` or `codespace:secrets` scope to use this endpoint.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CodespacesDeleteSecretForAuthenticatedUserAsync(
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}