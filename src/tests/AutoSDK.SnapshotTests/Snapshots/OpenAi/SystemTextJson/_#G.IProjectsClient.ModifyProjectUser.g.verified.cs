//HintName: G.IProjectsClient.ModifyProjectUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectUser> ModifyProjectUserAsync(
            global::G.ProjectUserUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a user's role in the project.
        /// </summary>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectUser> ModifyProjectUserAsync(
            global::G.ProjectUserUpdateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}