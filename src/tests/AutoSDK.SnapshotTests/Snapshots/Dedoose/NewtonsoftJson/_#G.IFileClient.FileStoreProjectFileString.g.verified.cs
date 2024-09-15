//HintName: G.IFileClient.FileStoreProjectFileString.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// StoreProjectFileString.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileStorageType"></param>
        /// <param name="extension"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> FileStoreProjectFileStringAsync(
            string? token = default,
            global::System.Guid projectId = default,
            int fileStorageType = default,
            string? extension = default,
            string? text = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}