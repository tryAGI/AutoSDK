//HintName: G.IActionsClient.ActionsDownloadArtifact.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Download an artifact<br/>
        /// Gets a redirect URL to download an archive for a repository. This URL expires after 1 minute. Look for `Location:` in<br/>
        /// the response header to find the URL for the download. The `:archive_format` must be `zip`.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="artifactId"></param>
        /// <param name="archiveFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> ActionsDownloadArtifactAsync(
            string owner,
            string repo,
            int artifactId,
            string archiveFormat,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}