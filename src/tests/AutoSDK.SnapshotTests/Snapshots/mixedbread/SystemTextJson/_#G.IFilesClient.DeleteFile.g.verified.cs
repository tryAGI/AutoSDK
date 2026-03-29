//HintName: G.IFilesClient.DeleteFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete file<br/>
        /// Delete a specific file by its ID.<br/>
        /// Args:<br/>
        ///     file_id: The ID of the file to delete.<br/>
        /// Returns:<br/>
        ///     FileDeleted: The response containing the details of the deleted file.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileDeleted> DeleteFileAsync(
            global::System.Guid fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}