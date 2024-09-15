//HintName: G.IBillingClient.BillingGetGithubPackagesBillingOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get GitHub Packages billing for an organization<br/>
        /// Gets the free and paid storage used for GitHub Packages in gigabytes.<br/>
        /// Paid minutes only apply to packages stored for private repositories. For more information, see "[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PackagesBillingUsage> BillingGetGithubPackagesBillingOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}