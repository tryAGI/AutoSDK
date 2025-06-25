//HintName: G.IWorkspaceClient.CreateWorkspaceInvitesAdd.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Invite User<br/>
        /// Sends an email invitation to join your workspace to the provided email. If the user doesn't have an account they will be prompted to create one. If the user accepts this invite they will be added as a user to your workspace and your subscription using one of your seats. This endpoint may only be called by workspace administrators. If the user is already in the workspace a 400 error will be returned.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddWorkspaceInviteResponseModel> CreateWorkspaceInvitesAddAsync(
            global::G.BodyInviteUserV1WorkspaceInvitesAddPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Invite User<br/>
        /// Sends an email invitation to join your workspace to the provided email. If the user doesn't have an account they will be prompted to create one. If the user accepts this invite they will be added as a user to your workspace and your subscription using one of your seats. This endpoint may only be called by workspace administrators. If the user is already in the workspace a 400 error will be returned.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="email">
        /// The email of the customer<br/>
        /// Example: john.doe@testmail.com
        /// </param>
        /// <param name="groupIds">
        /// The group ids of the user<br/>
        /// Example: [group_id_1, group_id_2]
        /// </param>
        /// <param name="workspacePermission">
        /// The workspace permission of the user<br/>
        /// Example: workspace_member
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddWorkspaceInviteResponseModel> CreateWorkspaceInvitesAddAsync(
            string email,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<string>? groupIds = default,
            global::G.BodyInviteUserV1WorkspaceInvitesAddPostWorkspacePermission? workspacePermission = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}