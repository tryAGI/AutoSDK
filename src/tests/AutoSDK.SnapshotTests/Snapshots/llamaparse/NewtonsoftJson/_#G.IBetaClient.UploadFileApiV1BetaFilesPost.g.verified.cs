//HintName: G.IBetaClient.UploadFileApiV1BetaFilesPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Upload File<br/>
        /// Upload a file using multipart/form-data.<br/>
        /// Set `purpose` to indicate how the file will be used:<br/>
        /// `user_data`, `parse`, `extract`, `classify`, `split`,<br/>
        /// `sheet`, or `agent_app`.<br/>
        /// Returns the created file metadata including its ID for use<br/>
        /// in subsequent parse, extract, or classify operations.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileV2> UploadFileApiV1BetaFilesPostAsync(

            global::G.BodyUploadFileApiV1BetaFilesPost request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Upload a file using multipart/form-data.<br/>
        /// Set `purpose` to indicate how the file will be used:<br/>
        /// `user_data`, `parse`, `extract`, `classify`, `split`,<br/>
        /// `sheet`, or `agent_app`.<br/>
        /// Returns the created file metadata including its ID for use<br/>
        /// in subsequent parse, extract, or classify operations.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="purpose">
        /// The intended purpose of the file. Valid values: 'user_data', 'parse', 'extract', 'split', 'classify', 'sheet', 'agent_app'. This determines the storage and retention policy for the file.
        /// </param>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileV2> UploadFileApiV1BetaFilesPostAsync(
            string purpose,
            byte[] file,
            string filename,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? externalFileId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}