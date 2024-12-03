//HintName: G.IFileClient.StoreProjectFileString.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// StoreProjectFileString<br/>
        /// StoreProjectFileString
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StoreProjectFileStringAsync(
            global::G.StoreProjectFileStringRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StoreProjectFileString<br/>
        /// StoreProjectFileString
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileStorageType"></param>
        /// <param name="extension"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StoreProjectFileStringAsync(
            global::System.Guid projectId,
            int fileStorageType,
            string extension,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}