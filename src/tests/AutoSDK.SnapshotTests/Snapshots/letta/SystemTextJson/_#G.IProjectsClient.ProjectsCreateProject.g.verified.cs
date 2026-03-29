//HintName: G.IProjectsClient.ProjectsCreateProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create Project (Cloud-only)<br/>
        /// Create a new project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectsCreateProjectResponse> ProjectsCreateProjectAsync(

            global::G.ProjectsCreateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project (Cloud-only)<br/>
        /// Create a new project
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectsCreateProjectResponse> ProjectsCreateProjectAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}