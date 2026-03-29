//HintName: G.IUserInvitesClient.InvitesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IUserInvitesClient
    {
        /// <summary>
        /// Invite User<br/>
        /// Send an invite to user for your organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SuccessInvite> InvitesCreateAsync(

            global::G.CreateInvite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite User<br/>
        /// Send an invite to user for your organization
        /// </summary>
        /// <param name="email"></param>
        /// <param name="workspaces"></param>
        /// <param name="role"></param>
        /// <param name="workspaceApiKeyDetails"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SuccessInvite> InvitesCreateAsync(
            string email,
            global::System.Collections.Generic.IList<global::G.WorkspaceInvite> workspaces,
            global::G.InviteRole role,
            global::G.CreateInviteWorkspaceApiKeyDetails? workspaceApiKeyDetails = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}