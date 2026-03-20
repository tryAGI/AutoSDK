//HintName: G.IProjectsClient.ProjectsRemoveCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Remove user as a collaborator<br/>
        /// Removes a collaborator from an organization project. You must be an organization owner or a project `admin` to remove a collaborator.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsRemoveCollaboratorAsync(
            int projectId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}