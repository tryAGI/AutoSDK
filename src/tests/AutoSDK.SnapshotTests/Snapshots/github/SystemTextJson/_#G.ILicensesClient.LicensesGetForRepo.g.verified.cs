//HintName: G.ILicensesClient.LicensesGetForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface ILicensesClient
    {
        /// <summary>
        /// Get the license for a repository<br/>
        /// This method returns the contents of the repository's license file, if one is detected.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw contents of the license.<br/>
        /// - **`application/vnd.github.html+json`**: Returns the license contents in HTML. Markup languages are rendered to HTML using GitHub's open-source [Markup library](https://github.com/github/markup).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LicenseContent> LicensesGetForRepoAsync(
            string owner,
            string repo,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}