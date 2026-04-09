//HintName: G.IBetaClient.ReadFileContentApiV1BetaFilesFileIdContentGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Read File Content<br/>
        /// Get a presigned URL to download the file content.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="expiresAtSeconds"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PresignedUrl> ReadFileContentApiV1BetaFilesFileIdContentGetAsync(
            global::System.Guid fileId,
            int? expiresAtSeconds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}