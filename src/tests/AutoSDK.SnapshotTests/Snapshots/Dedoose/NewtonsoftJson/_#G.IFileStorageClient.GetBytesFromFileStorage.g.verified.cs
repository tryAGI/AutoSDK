//HintName: G.IFileStorageClient.GetBytesFromFileStorage.g.cs
#nullable enable

namespace G
{
    public partial interface IFileStorageClient
    {
        /// <summary>
        /// Returns file data by a data path.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="dataPath"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetBytesFromFileStorageAsync(
            string? token = default,
            string? dataPath = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}