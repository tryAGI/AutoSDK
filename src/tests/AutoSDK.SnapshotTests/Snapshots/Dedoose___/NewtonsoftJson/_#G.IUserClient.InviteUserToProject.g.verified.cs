//HintName: G.IUserClient.InviteUserToProject.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// InviteUserToProject<br/>
        /// InviteUserToProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InviteUserToProjectAsync(
            global::G.InviteUserToProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// InviteUserToProject<br/>
        /// InviteUserToProject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="email"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> InviteUserToProjectAsync(
            global::System.Guid projectId,
            string email,
            global::System.Guid groupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}