//HintName: G.IReposClient.ReposCreatePagesSite.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a GitHub Pages site<br/>
        /// Configures a GitHub Pages site. For more information, see "[About GitHub Pages](/github/working-with-github-pages/about-github-pages)."<br/>
        /// The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Page> ReposCreatePagesSiteAsync(
            string owner,
            string repo,
            global::G.ReposCreatePagesSiteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a GitHub Pages site<br/>
        /// Configures a GitHub Pages site. For more information, see "[About GitHub Pages](/github/working-with-github-pages/about-github-pages)."<br/>
        /// The authenticated user must be a repository administrator, maintainer, or have the 'manage GitHub Pages settings' permission.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="buildType">
        /// The process in which the Page will be built. Possible values are `"legacy"` and `"workflow"`.
        /// </param>
        /// <param name="source">
        /// The source branch and directory used to publish your Pages site.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Page> ReposCreatePagesSiteAsync(
            string owner,
            string repo,
            global::G.ReposCreatePagesSiteRequestBuildType? buildType = default,
            global::G.ReposCreatePagesSiteRequestSource? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}