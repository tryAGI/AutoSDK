//HintName: G.IFilesClient.FilesApiRoutesDownloadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Download File<br/>
        /// Download a file
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> FilesApiRoutesDownloadFileAsync(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}