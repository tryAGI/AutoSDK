﻿//HintName: G.IPackagesClient.PackagesDeletePackageVersionForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Delete package version for a user<br/>
        /// Deletes a specific package version for a user. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.<br/>
        /// If the `package_type` belongs to a GitHub Packages registry that supports granular permissions, the authenticated user must have admin permissions to the package. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#granular-permissions-for-userorganization-scoped-packages)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` and `delete:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PackagesDeletePackageVersionForUserAsync(
            global::G.PackagesDeletePackageVersionForUserPackageType packageType,
            string packageName,
            string username,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}