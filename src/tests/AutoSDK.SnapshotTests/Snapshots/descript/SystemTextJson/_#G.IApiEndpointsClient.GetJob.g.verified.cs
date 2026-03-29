//HintName: G.IApiEndpointsClient.GetJob.g.cs
#nullable enable

namespace G
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// Get job status<br/>
        /// Retrieve the status of any job.<br/>
        /// The response format varies based on job type and includes type-specific fields.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.JobStatus> GetJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}