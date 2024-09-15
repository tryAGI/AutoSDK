//HintName: G.IProjectsClient.CreateProjectUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Adds a user to the project. Users must already be members of the organization to be added to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectUser> CreateProjectUserAsync(
            string projectId,
            global::G.ProjectUserCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds a user to the project. Users must already be members of the organization to be added to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId">
        /// The ID of the user.
        /// </param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectUser> CreateProjectUserAsync(
            string projectId,
            string userId,
            global::G.ProjectUserCreateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}