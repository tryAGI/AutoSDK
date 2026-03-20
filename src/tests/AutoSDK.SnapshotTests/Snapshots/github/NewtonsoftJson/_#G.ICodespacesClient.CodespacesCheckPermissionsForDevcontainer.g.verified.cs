//HintName: G.ICodespacesClient.CodespacesCheckPermissionsForDevcontainer.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Check if permissions defined by a devcontainer have been accepted by the authenticated user<br/>
        /// Checks whether the permissions defined by a given devcontainer configuration have been accepted by the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// Example: master
        /// </param>
        /// <param name="devcontainerPath">
        /// Example: .devcontainer/example/devcontainer.json
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesPermissionsCheckForDevcontainer> CodespacesCheckPermissionsForDevcontainerAsync(
            string owner,
            string repo,
            string @ref,
            string devcontainerPath,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}