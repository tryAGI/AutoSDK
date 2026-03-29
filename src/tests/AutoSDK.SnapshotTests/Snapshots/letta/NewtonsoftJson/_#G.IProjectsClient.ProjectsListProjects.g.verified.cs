//HintName: G.IProjectsClient.ProjectsListProjects.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List Projects (Cloud-only)<br/>
        /// List all projects
        /// </summary>
        /// <param name="name"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectsListProjectsResponse> ProjectsListProjectsAsync(
            string? name = default,
            global::G.OneOf<string, double?>? offset = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}