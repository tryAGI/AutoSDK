//HintName: G.IReposClient.ReposUpdateInformationAboutPagesSite.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update information about a GitHub Pages site<br/>
        /// Updates information for a GitHub Pages site. For more information, see "[About GitHub Pages](/github/working-with-github-pages/about-github-pages).<br/>
        /// The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposUpdateInformationAboutPagesSiteAsync(
            string owner,
            string repo,
            global::G.ReposUpdateInformationAboutPagesSiteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update information about a GitHub Pages site<br/>
        /// Updates information for a GitHub Pages site. For more information, see "[About GitHub Pages](/github/working-with-github-pages/about-github-pages).<br/>
        /// The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cname">
        /// Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see "[Using a custom domain with GitHub Pages](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site)."
        /// </param>
        /// <param name="httpsEnforced">
        /// Specify whether HTTPS should be enforced for the repository.
        /// </param>
        /// <param name="buildType">
        /// The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.
        /// </param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReposUpdateInformationAboutPagesSiteAsync(
            string owner,
            string repo,
            string? cname = default,
            bool? httpsEnforced = default,
            global::G.ReposUpdateInformationAboutPagesSiteRequestBuildType? buildType = default,
            global::G.AnyOf<global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::G.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}