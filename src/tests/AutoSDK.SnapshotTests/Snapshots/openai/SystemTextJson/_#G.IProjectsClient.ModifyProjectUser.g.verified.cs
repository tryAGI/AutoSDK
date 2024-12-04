//HintName: G.IProjectsClient.ModifyProjectUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectUser> ModifyProjectUserAsync(
            string projectId,
            string userId,
            global::G.ProjectUserUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectUser> ModifyProjectUserAsync(
            string projectId,
            string userId,
            global::G.ProjectUserUpdateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}