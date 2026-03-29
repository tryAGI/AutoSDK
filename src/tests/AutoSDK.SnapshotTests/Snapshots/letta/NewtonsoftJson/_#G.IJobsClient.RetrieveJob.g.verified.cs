//HintName: G.IJobsClient.RetrieveJob.g.cs
#nullable enable

namespace G
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Retrieve Job<br/>
        /// Get the status of a job.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job in the format 'job-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Job> RetrieveJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}