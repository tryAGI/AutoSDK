//HintName: G.IServerlessClient.ServerlessUploadFromUrl.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Upload file from URL<br/>
        /// Creates a new file at the target path by downloading it from the provided URL.
        /// </summary>
        /// <param name="file">
        /// Target file path (including filename)<br/>
        /// Example: datasets/images/cat.jpg
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> ServerlessUploadFromUrlAsync(
            string file,

            global::G.ServerlessUploadFromUrlRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload file from URL<br/>
        /// Creates a new file at the target path by downloading it from the provided URL.
        /// </summary>
        /// <param name="file">
        /// Target file path (including filename)<br/>
        /// Example: datasets/images/cat.jpg
        /// </param>
        /// <param name="url">
        /// Publicly accessible URL for the file
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> ServerlessUploadFromUrlAsync(
            string file,
            string url,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}