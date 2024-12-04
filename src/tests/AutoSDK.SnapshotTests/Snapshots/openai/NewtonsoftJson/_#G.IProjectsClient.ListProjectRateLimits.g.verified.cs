//HintName: G.IProjectsClient.ListProjectRateLimits.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Returns the rate limits per model for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectRateLimitListResponse> ListProjectRateLimitsAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}