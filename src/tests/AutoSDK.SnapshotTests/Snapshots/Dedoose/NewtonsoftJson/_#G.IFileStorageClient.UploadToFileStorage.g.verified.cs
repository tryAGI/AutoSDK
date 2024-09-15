//HintName: G.IFileStorageClient.UploadToFileStorage.g.cs
#nullable enable

namespace G
{
    public partial interface IFileStorageClient
    {
        /// <summary>
        /// Returns data path.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="uploadType"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UploadToFileStorageAsync(
            byte[] request,
            string? token = default,
            string? name = default,
            global::System.Guid projectId = default,
            int uploadType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}