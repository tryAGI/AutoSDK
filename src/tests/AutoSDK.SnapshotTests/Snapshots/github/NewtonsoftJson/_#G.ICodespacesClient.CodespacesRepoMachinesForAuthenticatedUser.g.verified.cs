//HintName: G.ICodespacesClient.CodespacesRepoMachinesForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List available machine types for a repository<br/>
        /// List the machine types available for a given repository based on its configuration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="location">
        /// Example: WestUs2
        /// </param>
        /// <param name="clientIp"></param>
        /// <param name="ref">
        /// Example: main
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodespacesRepoMachinesForAuthenticatedUserResponse> CodespacesRepoMachinesForAuthenticatedUserAsync(
            string owner,
            string repo,
            string? location = default,
            string? clientIp = default,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}