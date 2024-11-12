//HintName: G.IWorkspacesClient.ListCurrentWorkspaceSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Current Workspace Secrets
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SecretKey>> ListCurrentWorkspaceSecretsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}