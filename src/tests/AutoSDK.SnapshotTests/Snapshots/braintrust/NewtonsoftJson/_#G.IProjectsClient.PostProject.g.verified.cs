//HintName: G.IProjectsClient.PostProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project<br/>
        /// Create a new project. If there is an existing project with the same name as the one specified in the request, will return the existing project unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> PostProjectAsync(

            global::G.CreateProject request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Create a new project. If there is an existing project with the same name as the one specified in the request, will return the existing project unmodified
        /// </summary>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Textual description of the project
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the project belongs in.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> PostProjectAsync(
            string name,
            string? description = default,
            string? orgName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}