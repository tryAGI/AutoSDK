//HintName: G.IFilesClient.GetFilesByIdContent.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get file contents<br/>
        /// Get the contents of a single uploaded data file.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileObject> GetFilesByIdContentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}