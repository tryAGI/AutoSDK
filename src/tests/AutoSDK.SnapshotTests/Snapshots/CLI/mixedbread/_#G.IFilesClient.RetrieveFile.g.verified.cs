//HintName: G.IFilesClient.RetrieveFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get file details<br/>
        /// Retrieve details of a specific file by its ID.<br/>
        /// Args:<br/>
        ///     file_id: The ID of the file to retrieve.<br/>
        /// Returns:<br/>
        ///     FileResponse: The response containing the file details.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileObject> RetrieveFileAsync(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}