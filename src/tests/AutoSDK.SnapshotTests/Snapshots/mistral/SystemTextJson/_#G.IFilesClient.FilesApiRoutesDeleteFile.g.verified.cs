//HintName: G.IFilesClient.FilesApiRoutesDeleteFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete File<br/>
        /// Delete a file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFileOut> FilesApiRoutesDeleteFileAsync(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}