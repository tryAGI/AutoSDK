//HintName: G.IFileStorageClient.UploadToFileStorage.g.cs
#nullable enable

namespace G
{
    public partial interface IFileStorageClient
    {
        /// <summary>
        /// Upload File<br/>
        /// Uploads a file to the storage system and returns the file path.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="uploadType"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UploadToFileStorageAsync(
            string name,
            global::System.Guid projectId,
            int uploadType,
            byte[] request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}