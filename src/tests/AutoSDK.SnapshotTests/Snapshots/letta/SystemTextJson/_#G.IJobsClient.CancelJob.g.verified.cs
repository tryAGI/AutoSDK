//HintName: G.IJobsClient.CancelJob.g.cs
#nullable enable

namespace G
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Cancel Job<br/>
        /// Cancel a job by its job_id.<br/>
        /// This endpoint marks a job as cancelled, which will cause any associated<br/>
        /// agent execution to terminate as soon as possible.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job in the format 'job-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Job> CancelJobAsync(
            string jobId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}