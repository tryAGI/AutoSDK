//HintName: G.IFileStorageClient.GetStringFromFileStorage.g.cs
#nullable enable

namespace G
{
    public partial interface IFileStorageClient
    {
        /// <summary>
        /// Get String<br/>
        /// Retrieves file data from the storage system based on the specified data path.
        /// </summary>
        /// <param name="dataPath"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetStringFromFileStorageAsync(
            string dataPath,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}