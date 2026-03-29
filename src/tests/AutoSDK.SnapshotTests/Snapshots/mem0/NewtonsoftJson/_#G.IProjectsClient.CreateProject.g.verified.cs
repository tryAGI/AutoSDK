//HintName: G.IProjectsClient.CreateProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project<br/>
        /// Create a new project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateProjectResponse> CreateProjectAsync(
            string orgId,

            global::G.CreateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Create a new project within an organization.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="name">
        /// Name of the project to be created
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateProjectResponse> CreateProjectAsync(
            string orgId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}