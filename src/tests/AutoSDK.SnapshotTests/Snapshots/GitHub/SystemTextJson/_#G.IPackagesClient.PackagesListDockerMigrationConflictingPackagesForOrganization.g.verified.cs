//HintName: G.IPackagesClient.PackagesListDockerMigrationConflictingPackagesForOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Get list of conflicting packages during Docker migration for organization<br/>
        /// Lists all packages that are in a specific organization, are readable by the requesting user, and that encountered a conflict during a Docker migration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Package>> PackagesListDockerMigrationConflictingPackagesForOrganizationAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}