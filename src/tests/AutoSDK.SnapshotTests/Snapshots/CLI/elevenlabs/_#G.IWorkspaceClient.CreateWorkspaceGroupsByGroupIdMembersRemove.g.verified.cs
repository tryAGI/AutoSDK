//HintName: G.IWorkspaceClient.CreateWorkspaceGroupsByGroupIdMembersRemove.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Member From User Group<br/>
        /// Removes a member from the specified group. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteWorkspaceGroupMemberResponseModel> CreateWorkspaceGroupsByGroupIdMembersRemoveAsync(
            string groupId,
            global::G.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Member From User Group<br/>
        /// Removes a member from the specified group. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="email">
        /// The email of the target workspace member.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteWorkspaceGroupMemberResponseModel> CreateWorkspaceGroupsByGroupIdMembersRemoveAsync(
            string groupId,
            string email,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}