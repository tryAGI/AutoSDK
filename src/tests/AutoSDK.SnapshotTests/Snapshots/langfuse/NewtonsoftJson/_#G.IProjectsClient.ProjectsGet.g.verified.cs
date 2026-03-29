//HintName: G.IProjectsClient.ProjectsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project associated with API key (requires project-scoped API key). You can use GET /api/public/organizations/projects to get all projects with an organization-scoped key.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Projects> ProjectsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}