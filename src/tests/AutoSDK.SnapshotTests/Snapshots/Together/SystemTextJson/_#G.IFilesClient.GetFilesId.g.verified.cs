//HintName: G.IFilesClient.GetFilesId.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List file<br/>
        /// List the metadata for a single uploaded data file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileResponse> GetFilesIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}