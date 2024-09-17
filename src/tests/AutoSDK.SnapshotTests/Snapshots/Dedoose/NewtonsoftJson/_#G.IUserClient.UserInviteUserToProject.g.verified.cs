//HintName: G.IUserClient.UserInviteUserToProject.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// InviteUserToProject.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="email"></param>
        /// <param name="groupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserInviteUserToProjectResponse> UserInviteUserToProjectAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? email = default,
            global::System.Guid? groupId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}