//HintName: G.IWorkspaceClient.CreateWorkspaceInvitesAddBulk.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Invite Multiple Users<br/>
        /// Sends email invitations to join your workspace to the provided emails. Requires all email addresses to be part of a verified domain. If the users don't have an account they will be prompted to create one. If the users accept these invites they will be added as users to your workspace and your subscription using one of your seats. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddWorkspaceInviteResponseModel> CreateWorkspaceInvitesAddBulkAsync(
            global::G.BodyInviteMultipleUsersV1WorkspaceInvitesAddBulkPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Invite Multiple Users<br/>
        /// Sends email invitations to join your workspace to the provided emails. Requires all email addresses to be part of a verified domain. If the users don't have an account they will be prompted to create one. If the users accept these invites they will be added as users to your workspace and your subscription using one of your seats. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="emails">
        /// The email of the customer<br/>
        /// Example: john.doe@testmail.com
        /// </param>
        /// <param name="groupIds">
        /// The group ids of the user<br/>
        /// Example: [group_id_1, group_id_2]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddWorkspaceInviteResponseModel> CreateWorkspaceInvitesAddBulkAsync(
            global::System.Collections.Generic.IList<string> emails,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<string>? groupIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}