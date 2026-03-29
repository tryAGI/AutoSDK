//HintName: G.IFilesClient.FileControllerUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Update File
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> FileControllerUpdateAsync(
            string id,

            global::G.UpdateFileDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update File
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// This is the name of the file. This is just for your own reference.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.File> FileControllerUpdateAsync(
            string id,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}