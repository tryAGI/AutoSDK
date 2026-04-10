//HintName: G.IExtractionsClient.RetrieveExtractionJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExtractionsClient
    {
        /// <summary>
        /// Get extraction job result<br/>
        /// Get detailed information about a specific extraction job.<br/>
        /// Args:<br/>
        ///     job_id: The ID of the extraction job.<br/>
        /// Returns:<br/>
        ///     Detailed information about the extraction job.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the extraction job to retrieve
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractionJob> RetrieveExtractionJobAsync(
            string jobId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}