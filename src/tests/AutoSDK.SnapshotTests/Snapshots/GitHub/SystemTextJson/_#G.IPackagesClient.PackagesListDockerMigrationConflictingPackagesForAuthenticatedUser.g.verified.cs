//HintName: G.IPackagesClient.PackagesListDockerMigrationConflictingPackagesForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Get list of conflicting packages during Docker migration for authenticated-user<br/>
        /// Lists all packages that are owned by the authenticated user within the user's namespace, and that encountered a conflict during a Docker migration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Package>> PackagesListDockerMigrationConflictingPackagesForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}