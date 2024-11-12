//HintName: G.IWorkspaceClient.DeleteWorkspaceInvites.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Existing Invitation<br/>
        /// Invalidates an existing email invitation. The invitation will still show up in the inbox it has been delivered to, but activating it to join the workspace won't work. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteWorkspaceInvitesAsync(
            global::G.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Existing Invitation<br/>
        /// Invalidates an existing email invitation. The invitation will still show up in the inbox it has been delivered to, but activating it to join the workspace won't work. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="email">
        /// Email of the target user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteWorkspaceInvitesAsync(
            string email,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}