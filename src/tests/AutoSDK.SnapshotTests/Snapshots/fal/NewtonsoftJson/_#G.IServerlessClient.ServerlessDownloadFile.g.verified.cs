//HintName: G.IServerlessClient.ServerlessDownloadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Download file<br/>
        /// Downloads a file by its path. Proxies the underlying storage response.
        /// </summary>
        /// <param name="file">
        /// Path of the file to download<br/>
        /// Example: datasets/images/cat.jpg
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ServerlessDownloadFileAsync(
            string file,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}