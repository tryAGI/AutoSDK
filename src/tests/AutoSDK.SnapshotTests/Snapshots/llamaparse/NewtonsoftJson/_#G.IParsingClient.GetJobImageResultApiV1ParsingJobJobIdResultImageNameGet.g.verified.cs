//HintName: G.IParsingClient.GetJobImageResultApiV1ParsingJobJobIdResultImageNameGet.g.cs
#nullable enable

namespace G
{
    public partial interface IParsingClient
    {
        /// <summary>
        /// Get Job Image Result<br/>
        /// Get a job by id
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetJobImageResultApiV1ParsingJobJobIdResultImageNameGetAsync(
            string jobId,
            string name,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}