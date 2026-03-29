//HintName: G.IProjectsClient.ProjectsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project by ID (requires organization-scoped API key). Project deletion is processed asynchronously.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectDeletionResponse> ProjectsDeleteAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}