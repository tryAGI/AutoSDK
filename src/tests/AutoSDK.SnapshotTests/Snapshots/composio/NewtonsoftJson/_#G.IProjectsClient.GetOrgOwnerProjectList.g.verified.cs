//HintName: G.IProjectsClient.GetOrgOwnerProjectList.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List all projects<br/>
        /// Retrieves all projects belonging to the authenticated organization. Projects are returned in descending order of creation date (newest first). This endpoint is useful for displaying project selection in dashboards or for integrations that need to list all available projects.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOrgOwnerProjectListResponse> GetOrgOwnerProjectListAsync(
            double? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}