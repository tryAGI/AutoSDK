//HintName: G.IFilesClient.ReadFileContentApiV1FilesIdContentGet.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Read File Content<br/>
        /// Get a presigned URL to download the file content.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expiresAtSeconds"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PresignedUrl> ReadFileContentApiV1FilesIdContentGetAsync(
            global::System.Guid id,
            int? expiresAtSeconds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}