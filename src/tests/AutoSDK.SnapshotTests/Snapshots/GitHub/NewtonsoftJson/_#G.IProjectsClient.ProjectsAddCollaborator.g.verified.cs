//HintName: G.IProjectsClient.ProjectsAddCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add project collaborator<br/>
        /// Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project `admin` to add a collaborator.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> ProjectsAddCollaboratorAsync(
            int projectId,
            string username,
            global::G.ProjectsAddCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add project collaborator<br/>
        /// Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project `admin` to add a collaborator.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="permission">
        /// The permission to grant the collaborator.<br/>
        /// Default Value: write<br/>
        /// Example: write
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> ProjectsAddCollaboratorAsync(
            int projectId,
            string username,
            global::G.ProjectsAddCollaboratorRequestPermission? permission = global::G.ProjectsAddCollaboratorRequestPermission.Write,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}