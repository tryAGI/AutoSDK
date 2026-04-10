//HintName: G.IRunsClient.CreateRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Create a Run<br/>
        /// Queues a single run for ingestion. The request body must be a JSON-encoded run object that follows the Run schema.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateRunsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}