//HintName: G.ICodespacesClient.CodespacesAddRepositoryForSecretForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Add a selected repository to a user secret<br/>
        /// Adds a repository to the selected repositories for a user's development environment secret.<br/>
        /// The authenticated user must have Codespaces access to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` or `codespace:secrets` scope to use this endpoint.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CodespacesAddRepositoryForSecretForAuthenticatedUserAsync(
            string secretName,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}