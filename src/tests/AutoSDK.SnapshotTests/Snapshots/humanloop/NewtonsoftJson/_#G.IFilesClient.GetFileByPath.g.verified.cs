//HintName: G.IFilesClient.GetFileByPath.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get File by Path
        /// </summary>
        /// <param name="path"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileResponse> GetFileByPathAsync(
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}