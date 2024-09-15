//HintName: G.IGitClient.GitGetBlob.g.cs
#nullable enable

namespace G
{
    public partial interface IGitClient
    {
        /// <summary>
        /// Get a blob<br/>
        /// The `content` in the response will always be Base64 encoded.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw blob data.<br/>
        /// - **`application/vnd.github+json`**: Returns a JSON representation of the blob with `content` as a base64 encoded string. This is the default if no media type is specified.<br/>
        /// **Note** This endpoint supports blobs up to 100 megabytes in size.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="fileSha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Blob> GitGetBlobAsync(
            string owner,
            string repo,
            string fileSha,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}