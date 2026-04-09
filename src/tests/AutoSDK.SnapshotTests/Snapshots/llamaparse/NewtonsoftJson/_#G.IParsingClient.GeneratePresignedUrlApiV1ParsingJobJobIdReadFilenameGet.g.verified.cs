//HintName: G.IParsingClient.GeneratePresignedUrlApiV1ParsingJobJobIdReadFilenameGet.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Generate Presigned Url<br/>
        /// Generate a presigned URL for a job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="filename"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PresignedUrl> GeneratePresignedUrlApiV1ParsingJobJobIdReadFilenameGetAsync(
            string jobId,
            string filename,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}