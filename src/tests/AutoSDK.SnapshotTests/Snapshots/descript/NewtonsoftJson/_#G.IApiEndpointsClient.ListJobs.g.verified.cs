//HintName: G.IApiEndpointsClient.ListJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IApiEndpointsClient
    {
        /// <summary>
        /// List jobs<br/>
        /// List recent jobs with optional filtering by project or job type.<br/>
        /// By default, jobs created within the last 7 days are returned. Use `created_after` and<br/>
        /// `created_before` to customize the time range. The maximum lookback is 30 days.<br/>
        /// Results are paginated. Use the `cursor` from the response `pagination.next_cursor` to<br/>
        /// fetch subsequent pages.<br/>
        /// Query parameters allow you to filter the results:<br/>
        /// * Filter by `project_id` to see all jobs for a project<br/>
        /// * Filter by `type` to see specific job types (import/project_media, agent)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListJobsResponse> ListJobsAsync(
            global::System.Guid? projectId = default,
            global::G.ListJobsType? type = default,
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? createdAfter = default,
            global::System.DateTime? createdBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}