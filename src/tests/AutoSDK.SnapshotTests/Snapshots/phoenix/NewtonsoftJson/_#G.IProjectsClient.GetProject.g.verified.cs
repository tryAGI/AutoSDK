//HintName: G.IProjectsClient.GetProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project by ID or name<br/>
        /// Retrieve a specific project using its unique identifier: either project ID or project name. Note: When using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetProjectResponseBody> GetProjectAsync(
            string projectIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}