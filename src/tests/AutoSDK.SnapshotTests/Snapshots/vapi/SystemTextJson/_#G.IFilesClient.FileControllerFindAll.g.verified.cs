//HintName: G.IFilesClient.FileControllerFindAll.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.File>> FileControllerFindAllAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}