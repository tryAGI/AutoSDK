//HintName: G.ITemplateClient.CreateApplicationsJobsByJobIdRetry.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Retry job execution<br/>
        /// Re-triggers the async execution of a single job previously created via the Async api and terminated in error.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/applications/jobs/{job_id}/retry \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GenerateApplicationAsyncResponse> CreateApplicationsJobsByJobIdRetryAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}