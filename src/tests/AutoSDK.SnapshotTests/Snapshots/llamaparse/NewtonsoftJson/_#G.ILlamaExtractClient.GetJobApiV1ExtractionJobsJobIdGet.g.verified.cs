//HintName: G.ILlamaExtractClient.GetJobApiV1ExtractionJobsJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Get Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractJob> GetJobApiV1ExtractionJobsJobIdGetAsync(
            global::System.Guid jobId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}