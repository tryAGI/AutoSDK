//HintName: G.IImportClient.Download.g.cs
#nullable enable

namespace G
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Download file<br/>
        /// Download a specific uploaded file.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DownloadAsync(
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}