//HintName: G.ICodeScanningClient.CodeScanningGetCodeqlDatabase.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Get a CodeQL database for a repository<br/>
        /// Gets a CodeQL database for a language in a repository.<br/>
        /// By default this endpoint returns JSON metadata about the CodeQL database. To<br/>
        /// download the CodeQL database binary content, set the `Accept` header of the request<br/>
        /// to [`application/zip`](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types), and make sure<br/>
        /// your HTTP client is configured to follow redirects or use the `Location` header<br/>
        /// to make a second request to get the redirect URL.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="language"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningCodeqlDatabase> CodeScanningGetCodeqlDatabaseAsync(
            string owner,
            string repo,
            string language,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}