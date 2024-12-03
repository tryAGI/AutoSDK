//HintName: G.IProjectsClient.ProjectsGetPermissionForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project permission for a user<br/>
        /// Returns the collaborator's permission level for an organization project. Possible values for the `permission` key: `admin`, `write`, `read`, `none`. You must be an organization owner or a project `admin` to review a user's permission level.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectCollaboratorPermission> ProjectsGetPermissionForUserAsync(
            int projectId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}