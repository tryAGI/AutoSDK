//HintName: G.IWorkspaceClient.CreateWorkspaceMembers.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Update Member<br/>
        /// Updates attributes of a workspace member. Apart from the email identifier, all parameters will remain unchanged unless specified. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceMembersAsync(
            global::G.BodyUpdateMemberV1WorkspaceMembersPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Member<br/>
        /// Updates attributes of a workspace member. Apart from the email identifier, all parameters will remain unchanged unless specified. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="email">
        /// Email of the target user.
        /// </param>
        /// <param name="isLocked">
        /// Whether to lock or unlock the user account.
        /// </param>
        /// <param name="workspaceRole">
        /// Role dictating permissions in the workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceMembersAsync(
            string email,
            string? xiApiKey = default,
            bool? isLocked = default,
            global::G.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? workspaceRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}