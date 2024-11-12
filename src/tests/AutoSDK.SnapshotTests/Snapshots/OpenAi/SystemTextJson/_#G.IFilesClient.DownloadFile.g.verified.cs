//HintName: G.IFilesClient.DownloadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Returns the contents of the specified file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DownloadFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}