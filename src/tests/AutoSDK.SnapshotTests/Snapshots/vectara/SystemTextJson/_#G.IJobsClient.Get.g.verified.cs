//HintName: G.IJobsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Get a job by ID<br/>
        /// Get a job by a specific `job_id`. Jobs are background processes like replacing the filterable metadata attributes.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Job> GetAsync(
            string jobId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}