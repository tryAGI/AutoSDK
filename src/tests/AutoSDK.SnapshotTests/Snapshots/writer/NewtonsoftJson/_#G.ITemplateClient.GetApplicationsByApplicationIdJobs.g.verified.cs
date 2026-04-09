//HintName: G.ITemplateClient.GetApplicationsByApplicationIdJobs.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Retrieve all jobs<br/>
        /// Retrieve all jobs created via the async API, linked to the provided application ID (or alias).
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="status">
        /// The status of the job.
        /// </param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/applications/{application_id}/jobs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GetAsyncApplicationJobsResponse> GetApplicationsByApplicationIdJobsAsync(
            string applicationId,
            global::G.ApiJobStatus? status = default,
            long? offset = default,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}