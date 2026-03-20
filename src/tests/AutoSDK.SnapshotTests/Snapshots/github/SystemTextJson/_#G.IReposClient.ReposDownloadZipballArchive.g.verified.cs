//HintName: G.IReposClient.ReposDownloadZipballArchive.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Download a repository archive (zip)<br/>
        /// Gets a redirect URL to download a zip archive for a repository. If you omit `:ref`, the repository’s default branch (usually<br/>
        /// `main`) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use<br/>
        /// the `Location` header to make a second `GET` request.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; For private repositories, these links are temporary and expire after five minutes. If the repository is empty, you will receive a 404 when you follow the redirect.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDownloadZipballArchiveAsync(
            string owner,
            string repo,
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}