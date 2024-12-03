//HintName: G.IPackagesClient.PackagesGetPackageForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Get a package for the authenticated user<br/>
        /// Gets a specific package for a package owned by the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Package> PackagesGetPackageForAuthenticatedUserAsync(
            global::G.PackagesGetPackageForAuthenticatedUserPackageType packageType,
            string packageName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}